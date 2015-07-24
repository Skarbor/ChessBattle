using MainLogic.Checker;
using MainLogic.Chessmans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesBattleConsoleTest
{
    class Program
    {
        static void DisplayChecker(Chessman[,] checkerTab)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (checkerTab[i, j] != null)
                    {
                        Console.Write(checkerTab[i, j].GetSymbol());
                    }
                    else Console.Write(" ");      
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Checker checker = new Checker();

            checker.InitializeCheckerTab();

            var checkerTab = checker.GetCheckerTab();

            DisplayChecker(checkerTab);

            Console.Read();
        }
    }
}
