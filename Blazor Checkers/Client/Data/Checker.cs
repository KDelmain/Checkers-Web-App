using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Client.Data
{
    public class Checker
    {
        public int boardRow { get; set; }
        public int boardColumn { get; set; }
        public CheckerDirection direction { get; set; }
        public string checkerColor { get; set; }
    }

    public enum CheckerDirection
    {
        Down, Up, Both
    }
}
