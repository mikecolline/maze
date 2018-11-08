using MazeApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MazeApi.BL
{
    public class MazeService
    {
        private string startCharacter, endCharacter, spaceCharacter, solutionPathCharacter, wallCharacter;
        private long[,] mazeArray;
        private long rowCount = 0;
        private long columnLength = 0;
        private Position startPosition;
        private Position endPosition;

        public MazeSolution SolveMaze(string rawMazeString, string solutionPathCharacter = "@", string wallDelimiter = "#", string spaceDelimiter = ".", string startCharacter = "A", string endCharacter = "B")
        {
            this.startCharacter = startCharacter;
            this.endCharacter = endCharacter;
            this.spaceCharacter = spaceDelimiter;
            this.solutionPathCharacter = solutionPathCharacter;
            this.wallCharacter = wallDelimiter;

            var startDate = DateTime.Now;

            ValidateMazeString(rawMazeString);
            ConvertMazeToTo2DArray(rawMazeString);

            CountAllSpacesDistanceFromStartPosition();

            var numberOfStepsToSolution = mazeArray[endPosition.X, endPosition.Y] - 1;
            if (numberOfStepsToSolution < 1)
            {
                throw new MazeException("Unable to solve this maze");
            }

            WalkTheMazeBackward();

            var resultString = ConvertMazeBackToAString();

            var timeToSolve = DateTime.Now - startDate;

            return new MazeSolution() { SecondsToSolve = timeToSolve.TotalSeconds, MazeSolutionString = resultString, StepCount = numberOfStepsToSolution };
        }

        private string ConvertMazeBackToAString()
        {
            string result = "";

            for (var r = 0; r < rowCount; r++)
            {
                for (var c = 0; c < columnLength; c++)
                {
                    var value = mazeArray[r, c];
                    var character = "";

                    switch (value)
                    {
                        case 0:
                            character = spaceCharacter;
                            break;
                        case -1:
                            character = wallCharacter;
                            break;
                        case -2:
                            character = endCharacter;
                            break;
                        case 1:
                            character = startCharacter;
                            break;
                        case -5:
                            character = solutionPathCharacter;
                            break;
                        default:
                            character = spaceCharacter;
                            break;
                    }

                    result += character;

                }

                if (r < rowCount - 1)
                    result += "\n";
            }

            return result;
        }

        private void WalkTheMazeBackward()
        {
            var currentPosition = endPosition;

            while (true)
            {
                if (currentPosition == null)
                {
                    break;
                }

                var currentValue = mazeArray[currentPosition.X, currentPosition.Y];
                var amFinished = currentValue == 1;

                mazeArray[currentPosition.X, currentPosition.Y] = -5;

                if (amFinished)
                {
                    break;
                }

                currentPosition = FindNeighborBasedOnItsValue(currentPosition.X, currentPosition.Y, currentValue - 1);
            }

            //Reset the start and end
            mazeArray[startPosition.X, startPosition.Y] = 1;
            mazeArray[endPosition.X, endPosition.Y] = -2;
        }

        private void CountAllSpacesDistanceFromStartPosition()
        {
            Queue<Position> positionsToWork = new Queue<Position>();
            positionsToWork.Enqueue(startPosition);

            while (positionsToWork.Count > 0)
            {
                var currentPosition = positionsToWork.Dequeue();
                if (currentPosition.X == endPosition.X && currentPosition.Y == endPosition.Y)
                {
                    break;
                }

                var currentPositionValue = mazeArray[currentPosition.X, currentPosition.Y];
                var moves = GetPotentialMoves(currentPosition.X, currentPosition.Y);

                foreach (var move in moves)
                {
                    positionsToWork.Enqueue(move);
                    mazeArray[move.X, move.Y] = currentPositionValue + 1;
                }
            }

            
        }

        private List<Position> GetPotentialMoves(long fromX, long fromY)
        {
            List<Position> result = new List<Position>();
            var directions = new string[] { "north", "south", "east", "west" };

            foreach (var direction in directions)
            {
                var position = GetPotentialMove(fromX, fromY, direction);
                if (position != null)
                {
                    result.Add(position);
                }
            }

            return result;
        }

        private Position GetPotentialMove(long fromX, long fromY, string direction)
        {
            long toX = fromX;
            long toY = fromY;

            switch (direction)
            {
                case "north":
                    toX = fromX - 1;
                    break;
                case "south":
                    toX = fromX + 1;
                    break;
                case "east":
                    toY = fromY + 1;
                    break;
                case "west":
                    toY = fromY - 1;
                    break;
                default:
                    throw new MazeException($"Method 'CountUpFromStartNeighroingPosition'.  Don't know what to do with direction '${direction}'");
                    //break;
            }

            if (toX < 0 || toY < 0 || toX >= rowCount || toY >= columnLength)
            {
                return null;
            }

            //If the neighboring position is a 'WALL' or is NOT 0 and still less than 'ME', don't update it because
            //it's part of a shorter path
            var value = mazeArray[toX, toY];
            if (value != 0 && value != -2)
            {
                return null;
            }

            return new Position() { X = toX, Y = toY };
        }

        private void ConvertMazeToTo2DArray(string mazeString)
        {
            var lineArray = mazeString.Replace("\r", "").Split('\n');

            columnLength = lineArray[0].Length;
            rowCount = lineArray.Length;

            mazeArray = new long[rowCount, columnLength];
            for (var row = 0; row < rowCount; row++)
            {
                string line = lineArray[row];

                for (var column = 0; column < columnLength; column++)
                {
                    int value = 0;
                    string charString = line.Substring(column, 1).Replace(wallCharacter, "-1").Replace(startCharacter, "1").Replace(endCharacter, "-2").Replace(spaceCharacter, "0");

                    if (charString != "\r")
                    {
                        var isNumeric = int.TryParse(charString, out value);
                        if (!isNumeric)
                        {
                            throw new MazeException($"'{charString}' is not a valid character in a maze.  Position ({row}, {column})");
                        }

                        mazeArray[row, column] = value;

                        if (value == 1)
                        {
                            startPosition = new Position() { X = row, Y = column };
                        }

                        if (value == -2)
                        {
                            endPosition = new Position() { X = row, Y = column };
                        }
                    }
                }
            }
        }

        private void ValidateMazeString(string mazeString)
        {
            if (string.IsNullOrEmpty(mazeString))
            {
                throw new MazeException("mazeString provided is null");
            }

            var charCount = mazeString.Count(j => j == startCharacter.ToCharArray()[0]);

            if (charCount != 1)
            {
                var msg = charCount == 0 ? "No start position specified in maze" : "Too many start position chars!";
                throw new MazeException(msg);
            }

            charCount = mazeString.Count(j => j == endCharacter.ToCharArray()[0]);

            if (charCount != 1)
            {
                var msg = charCount == 0 ? "No end position specified in maze" : "Too many end position chars!";
                throw new MazeException(msg);
            }

            if (mazeString.Count(j => j == spaceCharacter.ToCharArray()[0]) == 0 || mazeString.Count(j => j == wallCharacter.ToCharArray()[0]) == 0)
            {
                throw new MazeException("mazeString provided doesn't appear to be a Maze?");
            }

        }

        private Position FindNeighborBasedOnItsValue(long fromX, long fromY, long lookForValue)
        {
            var north = new Position() { X = fromX - 1, Y = fromY };
            var south = new Position() { X = fromX + 1, Y = fromY };
            var east = new Position() { X = fromX, Y = fromY + 1 };
            var west = new Position() { X = fromX, Y = fromY - 1 };

            var directions = new[] { north, south, east, west };
            foreach (var direction in directions)
            {
                try
                {
                    var value = mazeArray[direction.X, direction.Y];
                    if (value == lookForValue)
                    {
                        return direction;
                    }
                }
                catch { }
            };

            return null;
        }

       
    }
}
