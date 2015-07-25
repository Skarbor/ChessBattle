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

        public override void Move(CheckerLogic.Checker checker, CheckerLogic.CheckerPoint point)
        {
            //sprawdzenie czy pole jest wolne
            if (!checker.CheckIfFieldIsEmpty(point)) { } //wyjatek? Blad? Do przemyslenia

            //sprawdzenie czy figura może się tak poruszać
            //if (!MoveRequirements.CheckPawnMovement(Field, point)) { } //wyjatek? Blad? Do przemyslenia

            //sprawdzenie czy ruch dozwolony w kontekście ustawienia szachownicy, czy król nie zostałby szachowany itp.
            //TODO

            //wykonanie ruchu
            //TODO
        }
    }
}
