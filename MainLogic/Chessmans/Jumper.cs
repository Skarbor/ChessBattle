using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public class Jumper : Chessman
    {
        public ChessmanType ChessmanType { get; set; }

        public Jumper() : base()
        {
            ChessmanType = ChessmanType.Jumper;
        }
        public override string GetSymbol()
        {
            return "J";
        }
    }
}
