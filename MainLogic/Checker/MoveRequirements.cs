using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Checker
{
    public static class MoveRequirements
    {
        public static Boolean TowerMovement(CheckerPoint start, CheckerPoint end)
        {
            if (start.X == end.X) return true;

            if (start.Y == end.Y) return true;

            return false;
        }

        public static Boolean JumperMovement(CheckerPoint start, CheckerPoint end)
        {
            if (end.X == start.X + 2 && (end.Y == start.Y + 1 || end.Y == start.Y - 1)) return true;    //left and up, left and down
            if (end.X == start.X - 2 && (end.Y == start.Y + 1 || end.Y == start.Y - 1)) return true;    //right and up, right and down
            if (end.Y == start.Y + 2 && (end.X == start.X + 1 || end.X == start.X - 1)) return true;    // up and right, up and left
            if (end.Y == start.Y - 2 && (end.X == start.X + 1 || end.X == start.X - 1)) return true;    // down and right, up and left

            return false;
        }

        public static Boolean BishopMovement(CheckerPoint start, CheckerPoint end)
        {
            int x_move = end.X - start.X;
            int y_move = end.X - start.X;

            if (x_move < 0) x_move = - x_move;
            if (y_move < 0) y_move = - y_move;

            if (x_move == y_move) return true;
            else return false;
        }

        public static Boolean HetmanMovement(CheckerPoint start, CheckerPoint end)
        {
            //Hetman's movement is tower + bishop movement
            
            if (TowerMovement(start, end)) return true;
            if (BishopMovement(start, end)) return true;

            return false;
        }

        //public static Boolean PownMovement(CheckerPoint start, CheckerPoint end, bool isKilling, bool isInOriginalPosition, ChessmanColor color)
        //{
        //    //2 steps forward
        //    if (color == ChessmanColor.White)
        //    {
        //        if (end.Y == start.Y + 2)
        //        {
        //            if (start.Y == 1) return true;
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        if (end.Y == start.Y - 2)
        //        {
        //            if (start.Y == 7) return true;
        //            return false;
        //        }
        //    }


        //    if (isInOriginalPosition)
        //    {
        //        if (isKilling)
        //        {
        //            if (color == ChessmanColor.Black)
        //            {

        //            }
        //            else
        //            { 
                    
        //            }
        //        }
        //        else
        //        {

        //        }
        //    }
        //    else
        //    {
        //        if (isKilling)
        //        {

        //        }
        //        else
        //        {

        //        }
        //    }
        //}
    }
}
