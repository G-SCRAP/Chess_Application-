using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        //The Size of the board usally 8*8
        public int Size { get; set;  }

        //2D array of the type cell 
        public Cell[,] theGrid { get; set; }

        //Construtor
        public Board (int s)
        {
            //Size of the board is defined by s.
            Size = s;

            //Create a new 2d array of type cell. 
            theGrid = new Cell[Size, Size]; 

            //Fill the 2d array with new Cells, each with a unique x and y coordinates. 
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j); 
                }
            }
        }
        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            //Clear all previous moves
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;

                    switch (chessPiece)
                    {
                        case "Knight":
                            theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                            break;
                        case "Queen":
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].LegalNextMove = true;
                            break;
                        case "Rook":
                           
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true;

                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true;

                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true;

                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true;

                            break;
                        case "Bishop":

                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;

                            theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true;

                            theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true;

                            theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true;

                            theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true;

                            theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true;

                            theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true;

                            break;
                        case "King":
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber -1, currentCell.ColumnNumber].LegalNextMove = true;
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            break;
                        default:
                            break;



                    }
                }
            }
        }
    }

}
