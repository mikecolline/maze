using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeApi.BL;
using MazeApi.Common;

namespace MazeTests
{
    [TestClass]
    public class MazeTests
    {
        MazeService service;

        [TestInitialize]
        public void Initialize()
        {
            service = new MazeService();

        }


        [TestMethod]
        public void SimpleMaze()
        {
           
            var mazeModel = service.SolveMaze(MazeStrings.Maze1);

            Assert.AreEqual(14, mazeModel.StepCount);
            Assert.IsTrue(mazeModel.SecondsToSolve < 1);
            Assert.AreEqual(mazeModel.MazeSolutionString, MazeStrings.Maze1SolutionString);
        }

        [TestMethod]
        public void MiddleMaze()
        {
            var mazeModel = service.SolveMaze(MazeStrings.Maze2);

            Assert.IsTrue(mazeModel.SecondsToSolve < 10);
        }

        [TestMethod]
        public void ComplexMaze()
        {
            var mazeModel = service.SolveMaze(MazeStrings.Maze3);

            Assert.IsTrue(mazeModel.SecondsToSolve < 3);
        }

        [TestMethod]
        [ExpectedException(typeof(MazeException))]
        public void MissingStartingPointException()
        {
            var stringMaze = MazeStrings.Maze2.Replace("A", "X");
            service.SolveMaze(stringMaze);
        }

        [TestMethod]
        [ExpectedException(typeof(MazeException))]
        public void MissingDestinationPointException()
        {
            var stringMaze = MazeStrings.Maze2.Replace("B", "X");
            service.SolveMaze(stringMaze);
        }
    }
}
