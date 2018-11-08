using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeApi.BL;

namespace MazeTests
{
    [TestClass]
    public class MazeTests
    {
        MazeService service;

        [TestInitialize]
        public void Initialize()
        {
            //service = new MazeService();

            //var service = new MazeApi.BL.MazeService();

        }

        [TestMethod]
        public void mike()
        {
            Assert.AreEqual("A", "A");

        }




        [TestMethod]
        public void SimpleMaze()
        {

            var service = new MazeApi.BL.MazeService();
            //var service = new BL.MazeService();
            var mazeModel = service.SolveMaze(MazeStrings.Maze1);


            //var solution = service.SolveMaze(MazeStrings.Maze1);
            //MazeApi.BL.MazeService serv;
            //serv = new MazeApi.BL.MazeService();
            //var x = serv.SolveMaze(MazeStrings.Maze1);


            //    Assert.AreEqual("A", "A");
            //    //serv.SolveMaze()
            //    //Assert.AreEqual(14, solution.StepCount);
            //    //Assert.IsTrue(solution.SecondsToSolve < 1);
            //    //Assert.AreEqual(solution.MazeSolutionString, MazeStrings.Maze1SolutionString);
        }

        //[TestMethod]
        //public void MiddleMaze()
        //{
        //    var solution = service.SolveMaze(MazeStrings.Maze2);

        //    Assert.IsTrue(solution.SecondsToSolve < 10);
        //}

        //[TestMethod]
        //public void ComplexMaze()
        //{
        //    var solution = service.SolveMaze(MazeStrings.Maze3);

        //    Assert.IsTrue(solution.SecondsToSolve < 3);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(MazeException))]
        //public void MissingStartingPointException()
        //{
        //    var stringMaze = MazeStrings.Maze2.Replace("A", "X");
        //    service.SolveMaze(stringMaze);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(MazeException))]
        //public void MissingDestinationPointException()
        //{
        //    var stringMaze = MazeStrings.Maze2.Replace("B", "X");
        //    service.SolveMaze(stringMaze);
        //}
    }
}
