using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public class Pawn : Chessman
    {
        public ChessmanType ChessmanType { get; set; }

        public Pawn() : base()
        {
            ChessmanType = ChessmanType.Pawn;
        }

        public override string GetSymbol()
        {
            return "P";
        }
    }
}
