using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeApi.Common
{
    public class MazeSolution
    {
        public long StepCount { get; set; }
        public string MazeSolutionString { get; set; }
        public double SecondsToSolve { get; set; }
    }
}
