using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Checker
{
    public class CheckerPoint
    {
        public int X 
        {
            get 
            {
                return X;
            }
            set
            {
                if (value < 0 || value > 7) throw new Exception("Invalid Checker Coordinates!"); 
                X = value;
            }
        }

        public int Y
        {
            get 
            {
                return Y;
            }
            set
            {
                if (value < 0 || value > 7) throw new Exception("Invalid Checker Coordinates!"); 
                Y = value;
            }
        }
    }
}
