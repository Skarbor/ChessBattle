using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Chessmans
{
    public class Tower : Chessman
    {
        public ChessmanType ChessmanType { get; set; }

        public Tower() : base()
        {
            ChessmanType = ChessmanType.Tower;
        }

        public override string GetSymbol()
        {
            return "T";
        }

        public override void Move(CheckerLogic.Checker checker, CheckerLogic.CheckerPoint point)
        {
            //sprawdzenie czy pole jest wolne
            if (!checker.CheckIfFieldIsEmpty(point)) { } //wyjatek? Blad? Do przemyslenia

            //sprawdzenie czy figura może się tak poruszać
            if (!MoveRequirements.CheckTowerMovement(Field, point)) { } //wyjatek? Blad? Do przemyslenia

            //sprawdzenie czy ruch dozwolony w kontekście ustawienia szachownicy, czy król nie zostałby szachowany itp.
            //TODO

            //wykonanie ruchu
            //TODO
        }
    }
}
