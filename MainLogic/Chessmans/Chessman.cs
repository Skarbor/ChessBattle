using MainLogic.CheckerLogic;
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
        public CheckerPoint Field { get; set; }

        public abstract void Move(CheckerLogic.Checker checker, CheckerPoint point);
        public abstract string GetSymbol();
    }
}
