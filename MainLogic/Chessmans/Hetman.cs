using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public class Hetman : Chessman
    {
        public ChessmanType ChessmanType { get; set; }

        public Hetman() : base()
        {
            ChessmanType = ChessmanType.Hetman;
        }
        public override string GetSymbol()
        {
            return "H";
        }
    }
}
