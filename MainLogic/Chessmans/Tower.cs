using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public class Tower : Chessman
    {
        public ChessmanType ChessmanType { get; set; }

        public Tower() : base()
        {
            ChessmanType = ChessmanType.Tower;
        }
        public override string GetSymbol()
        {
            return "T";
        }
    }
}
