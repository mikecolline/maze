using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MazeApi.Common
{
    public class MazeException : Exception
    {
        public MazeException(string message) : base(message) { }
    }
}
