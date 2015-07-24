using MainLogic.Chessmans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Checker
{
    public class Checker
    {
        private Chessman[,] CheckerTab { get; set; }

        public Checker()
        {
            CheckerTab = new Chessman[8, 8];

            ClearChecerTab();
        }


        private void ClearChecerTab()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //CheckerTab[i, j] = new Chessman() { ChessmanType = ChessmanType.Empty };
                    CheckerTab[i, j] = null;
                }
            }
        }

        public void InitializeCheckerTab()
        {
            // init black
            CheckerTab[0, 7] = new Tower()  { CheckerPoint = new CheckerPoint { X = 0, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[1, 7] = new Jumper() { CheckerPoint = new CheckerPoint { X = 1, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[2, 7] = new Bishop() { CheckerPoint = new CheckerPoint { X = 2, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[3, 7] = new Hetman() { CheckerPoint = new CheckerPoint { X = 3, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[4, 7] = new King()   { CheckerPoint = new CheckerPoint { X = 4, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[5, 7] = new Bishop() { CheckerPoint = new CheckerPoint { X = 5, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[6, 7] = new Jumper() { CheckerPoint = new CheckerPoint { X = 6, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[7, 7] = new Tower()  { CheckerPoint = new CheckerPoint { X = 7, Y = 7 }, ChessmanColor = ChessmanColor.Black };

            // black pawns
            for (int i = 0; i < 8; i++)
            {
                CheckerTab[i, 6] = new Pawn() { CheckerPoint = new CheckerPoint { X = i, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            }


            
            // init white
            CheckerTab[0, 0] = new Tower()  { ChessmanColor = ChessmanColor.White };
            CheckerTab[1, 0] = new Jumper() { ChessmanColor = ChessmanColor.White };
            CheckerTab[2, 0] = new Bishop() { ChessmanColor = ChessmanColor.White };
            CheckerTab[3, 0] = new Hetman() { ChessmanColor = ChessmanColor.White };
            CheckerTab[4, 0] = new King()   { ChessmanColor = ChessmanColor.White };
            CheckerTab[5, 0] = new Bishop() { ChessmanColor = ChessmanColor.White };
            CheckerTab[6, 0] = new Jumper() { ChessmanColor = ChessmanColor.White };
            CheckerTab[7, 0] = new Tower()  { ChessmanColor = ChessmanColor.White };

            // white pawns
            for (int i = 0; i < 8; i++)
            {
                CheckerTab[i, 1] = new Pawn() { ChessmanColor = ChessmanColor.White };
            }
        }

        public Chessman[,] GetCheckerTab()
        {
            return CheckerTab;
        }
    }
}
