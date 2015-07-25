using MainLogic.Chessmans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.CheckerLogic
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
            CheckerTab[0, 7] = new Tower()  { Field = new CheckerPoint { X = 0, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[1, 7] = new Jumper() { Field = new CheckerPoint { X = 1, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[2, 7] = new Bishop() { Field = new CheckerPoint { X = 2, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[3, 7] = new Hetman() { Field = new CheckerPoint { X = 3, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[4, 7] = new King()   { Field = new CheckerPoint { X = 4, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[5, 7] = new Bishop() { Field = new CheckerPoint { X = 5, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[6, 7] = new Jumper() { Field = new CheckerPoint { X = 6, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            CheckerTab[7, 7] = new Tower()  { Field = new CheckerPoint { X = 7, Y = 7 }, ChessmanColor = ChessmanColor.Black };

            // black pawns
            for (int i = 0; i < 8; i++)
            {
                CheckerTab[i, 6] = new Pawn() { Field = new CheckerPoint { X = i, Y = 7 }, ChessmanColor = ChessmanColor.Black };
            }


            
            // init white
            CheckerTab[0, 0] = new Tower()  { Field = new CheckerPoint { X = 0, Y = 0 }, ChessmanColor = ChessmanColor.White };
            CheckerTab[1, 0] = new Jumper() { Field = new CheckerPoint { X = 1, Y = 0 }, ChessmanColor = ChessmanColor.White };
            CheckerTab[2, 0] = new Bishop() { Field = new CheckerPoint { X = 2, Y = 0 }, ChessmanColor = ChessmanColor.White };
            CheckerTab[3, 0] = new Hetman() { Field = new CheckerPoint { X = 3, Y = 0 }, ChessmanColor = ChessmanColor.White };
            CheckerTab[4, 0] = new King()   { Field = new CheckerPoint { X = 4, Y = 0 }, ChessmanColor = ChessmanColor.White };
            CheckerTab[5, 0] = new Bishop() { Field = new CheckerPoint { X = 5, Y = 0 }, ChessmanColor = ChessmanColor.White };
            CheckerTab[6, 0] = new Jumper() { Field = new CheckerPoint { X = 6, Y = 0 }, ChessmanColor = ChessmanColor.White };
            CheckerTab[7, 0] = new Tower()  { Field = new CheckerPoint { X = 7, Y = 0 }, ChessmanColor = ChessmanColor.White };

            // white pawns
            for (int i = 0; i < 8; i++)
            {
                CheckerTab[i, 1] = new Pawn() { Field = new CheckerPoint { X = i, Y = 1 }, ChessmanColor = ChessmanColor.White };
            }
        }

        public Chessman[,] GetCheckerTab()
        {
            return CheckerTab;
        }

        public bool CheckIfFieldIsEmpty(CheckerPoint point)
        {
            if (CheckerTab[point.X, point.Y] == null) return true;
            else return false;
        }
        public bool CheckIfFieldIsEmpty(int x, int y)
        {
            if (CheckerTab[x, y] == null) return true;
            else return false;
        }
    }
}
