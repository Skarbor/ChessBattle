using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public class King : Chessman
    {
        public ChessmanType ChessmanType { get; set; }

        public King() : base()
        {
            ChessmanType = ChessmanType.King;
        }
        public override string GetSymbol()
        {
            return "K";
        }
    }
}
