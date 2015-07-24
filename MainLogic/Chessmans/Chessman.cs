using MainLogic.Checker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public abstract class Chessman
    {
        public ChessmanColor ChessmanColor { get; set; }
        public CheckerPoint CheckerPoint { get; set; }

        public abstract string GetSymbol();
    }
}
