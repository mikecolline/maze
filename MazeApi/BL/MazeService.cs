using MazeApi.Models;
using System;
using System.Text;

namespace MazeApi.BL
{
    public class MazeService
    {
        int[][] _moves = {
                        new int[] { -1, 0 },
                        new int[] { 0, -1 },
                        new int[] { 0, 1 },
                        new int[] { 1, 0 } };

        string myMap = string.Empty;
        

        public MazeModel SolveMaze(string maze)
        {

            var array = GetMazeArray(maze);
            var myMoves = 0;


            for (int i = 0; i < array.Length; i++)
            {
                var row = array[i];

                for (int x = 0; x < row.Length; x++)
                {
                    // Start square is here.
                    if (row[x] == 1)
                    {
                        int lowest = int.MaxValue;
                        Move(array, i, x, 0, ref lowest);

                        myMoves = lowest;
                    }
                }
            }

            //var test = myMoves;

            if (myMap.Length == 0)
            {
                myMap = "No Solution";
                myMoves = 0;
            }
            return new MazeModel { steps = myMoves, solution = myMap };
        }

        private bool IsValidPos(int[][] array, int row, int newRow, int newColumn)
        {
            if (newRow < 0) return false;
            if (newColumn < 0) return false;
            if (newRow >= array.Length) return false;
            if (newColumn >= array[row].Length) return false;

            return true;
        }
        private int Move(int[][] arrayTemp, int rowIndex, int columnIndex, int count, ref int lowest)
        {
            // Copy map so we can modify it and then abandon it.
            int[][] array = new int[arrayTemp.Length][];

            for (int i = 0; i < arrayTemp.Length; i++)
            {
                var row = arrayTemp[i];
                array[i] = new int[row.Length];
                for (int x = 0; x < row.Length; x++)
                {
                    array[i][x] = row[x];
                }
            }

            int value = array[rowIndex][columnIndex];

            if (value >= 1)
            {
                // Try all moves.
                foreach (var movePair in _moves)
                {
                    int newRow = rowIndex + movePair[0];
                    int newColumn = columnIndex + movePair[1];
                    if (IsValidPos(array, rowIndex, newRow, newColumn))
                    {
                        int testValue = array[newRow][newColumn];
                        if (testValue == 0)
                        {
                            array[newRow][newColumn] = value + 1;

                            // Try another move.
                            Move(array, newRow, newColumn, count + 1, ref lowest);
                        }
                        else if (testValue == -3)
                        {

                            if (count + 1 < lowest)
                            {
                                lowest = count + 1;
                                myMap = CreateSolution(array);

                            }
                            return 1;
                        }
                    }
                }
            }
            return -1;
        }
         

        private int[][] GetMazeArray(string maze)
        {
            string[] lines = maze.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Create array.
            int[][] array = new int[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                var row = new int[line.Length];

                for (int x = 0; x < line.Length; x++)
                {
                    switch (line[x])
                    {
                        case '#':
                            row[x] = -1;
                            break;
                        case 'A':
                            row[x] = 1;
                            break;
                        case 'B':
                            row[x] = -3;
                            break;
                        default:
                            row[x] = 0;
                            break;
                    }
                }
                array[i] = row;
            }
            return array;
        }


        // disply path
        private string CreateSolution(int[][] array)

        {
            // Loop over int data and display as characters.
            StringBuilder solutionMap = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                var row = array[i];

                for (int x = 0; x < row.Length; x++)
                {
                    switch (row[x])
                    {
                        case -1:
                            solutionMap.Append('#');
                            break;
                        case 1:
                            solutionMap.Append('A');
                            break;
                        case -3:
                            solutionMap.Append('B');
                            break;
                        case 0:
                            solutionMap.Append('.');
                            break;
                        default:
                            solutionMap.Append('@');

                            break;

                    }

                }

                solutionMap.Append(new char[] { '\n', '\r' });
            }
            return solutionMap.ToString();
        }

    }
}
