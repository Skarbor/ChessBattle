using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public class Bishop : Chessman
    {
        public ChessmanType ChessmanType { get; set; }

        public Bishop() : base()
        {
            ChessmanType = ChessmanType.Bishop;
        }
        public override string GetSymbol()
        {
            return "B";
        }
    }
}
