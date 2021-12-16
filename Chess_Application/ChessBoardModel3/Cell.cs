using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel3
{
    public class Cell
    {
        public string Piece { get; set; }
        public int SquareNumber { get; set; }
        public bool LegalNextMove { get; set; }

        public Cell(int SQ, string Pieces)
        {
            SquareNumber = SQ;
            Piece = Pieces;
        }

    }
}
