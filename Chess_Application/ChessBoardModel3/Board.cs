using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel3
{
    public class Board
    {

        //The grid is Intialzed
        public List<Cell> theGrid = new List<Cell>(64);

        //Creates Board with pieces 
        public Board()
        {
            //Puts Pieces on the board
            //This part represents Square spaces 0 - 8 which is black special pieces
            for (int i = 0; i < 64; i++)
            {
                if (i == 0)
                {
                    theGrid.Add(new Cell(i, "BR"));

                }
                else if (i == 1)
                {
                    theGrid.Add(new Cell(i, "BK"));
                }
                else if (i == 2)
                {
                    theGrid.Add(new Cell(i, "BB"));
                }
                else if (i == 3)
                {
                    theGrid.Add(new Cell(i, "BQ"));
                }
                else if (i == 4)
                {
                    theGrid.Add(new Cell(i, "BKG"));
                }
                else if (i == 5)
                {
                    theGrid.Add(new Cell(i, "BB"));
                }
                else if (i == 6)
                {
                    theGrid.Add(new Cell(i, "BK"));
                }
                else if (i == 7)
                {
                    theGrid.Add(new Cell(i, "BR"));

                }

                //This part represents Square spaces 9 - 15 which is black pawn pieces
                else if (i == 8)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }
                else if (i == 9)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }
                else if (i == 10)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }
                else if (i == 11)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }
                else if (i == 12)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }
                else if (i == 13)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }
                else if (i == 14)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }
                else if (i == 15)
                {
                    theGrid.Add(new Cell(i, "BP"));
                }

                //This part represents Square spaces which is whites pawn pieces

                else if (i == 48)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }
                else if (i == 49)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }
                else if (i == 50)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }
                else if (i == 51)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }
                else if (i == 52)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }
                else if (i == 53)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }
                else if (i == 54)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }
                else if (i == 55)
                {
                    theGrid.Add(new Cell(i, "WP"));
                }

                //This part represents Square spaces which is whites Special pieces
                else if (i == 56)
                {
                    theGrid.Add(new Cell(i, "WR"));
                }
                else if (i == 57)
                {
                    theGrid.Add(new Cell(i, "WK"));
                }
                else if (i == 58)
                {
                    theGrid.Add(new Cell(i, "WB"));
                }
                else if (i == 59)
                {
                    theGrid.Add(new Cell(i, "WQ"));
                }
                else if (i == 60)
                {
                    theGrid.Add(new Cell(i, "WKG"));
                }
                else if (i == 61)
                {
                    theGrid.Add(new Cell(i, "WB"));
                }
                else if (i == 62)
                {
                    theGrid.Add(new Cell(i, "WK"));
                }
                else if (i == 63)
                {
                    theGrid.Add(new Cell(i, "WR"));
                }
                //Default to empty
                else
                {
                    theGrid.Add(new Cell(i, "E"));
                }
            }
        }

        public void LegalMove(string piece, int SquareNum)
        {
            int field;
            switch (piece)
            {


                case "WR":
                case "BR":

                    field = SquareNum % 8;
                    //If statment of Piece and if it can go out of bounds
                    if (field == 0)
                    {
                        //Travel in Records
                        theGrid[SquareNum + 1].LegalNextMove = true;
                        theGrid[SquareNum + 7].LegalNextMove = true;
                        theGrid[SquareNum + 2].LegalNextMove = true;
                        theGrid[SquareNum + 3].LegalNextMove = true;
                        theGrid[SquareNum + 4].LegalNextMove = true;
                        theGrid[SquareNum + 5].LegalNextMove = true;
                        theGrid[SquareNum + 6].LegalNextMove = true;

                        //Travels through fields
                        if (SquareNum + 8 < 64)
                        {
                            theGrid[SquareNum + 8].LegalNextMove = true;
                        }
                        if (SquareNum + 16 < 64)
                        {
                            theGrid[SquareNum + 16].LegalNextMove = true;
                        }
                        if (SquareNum + 32 < 64)
                        {
                            theGrid[SquareNum + 32].LegalNextMove = true;
                        }
                        if (SquareNum + 40 < 64)
                        {
                            theGrid[SquareNum + 40].LegalNextMove = true;
                        }
                        if (SquareNum + 48 < 64)
                        {
                            theGrid[SquareNum + 48].LegalNextMove = true;
                        }
                        if (SquareNum + 56 < 64)
                        {
                            theGrid[SquareNum + 56].LegalNextMove = true;
                        }

                        else if (field == 1)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum + 4].LegalNextMove = true;
                            theGrid[SquareNum + 5].LegalNextMove = true;
                            theGrid[SquareNum + 6].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }

                        }
                        else if (field == 2)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum + 4].LegalNextMove = true;
                            theGrid[SquareNum + 5].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }

                        }
                        else if (field == 3)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum + 4].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 4)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 5)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 5].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 6)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 5].LegalNextMove = true;
                            theGrid[SquareNum - 6].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 7)
                        {
                            //Travel in Records

                            theGrid[SquareNum - 7].LegalNextMove = true;
                            theGrid[SquareNum - 6].LegalNextMove = true;
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 5].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                    }
                    break;
                case "WB":
                case "BB":

                    //Travels through fields down left Angled
                    if (SquareNum + 7 < 64)
                    {
                        theGrid[SquareNum + 7].LegalNextMove = true;
                    }
                    if (SquareNum + 14 < 64)
                    {
                        theGrid[SquareNum + 14].LegalNextMove = true;
                    }
                    if (SquareNum + 21 < 64)
                    {
                        theGrid[SquareNum + 21].LegalNextMove = true;
                    }
                    if (SquareNum + 28 < 64)
                    {
                        theGrid[SquareNum + 28].LegalNextMove = true;
                    }
                    if (SquareNum + 35 < 64)
                    {
                        theGrid[SquareNum + 35].LegalNextMove = true;
                    }
                    if (SquareNum + 42 < 64)
                    {
                        theGrid[SquareNum + 42].LegalNextMove = true;
                    }

                    //Travels through fields down right Angled
                    if (SquareNum + 9 < 64)
                    {
                        theGrid[SquareNum + 9].LegalNextMove = true;
                    }
                    if (SquareNum + 18 < 64)
                    {
                        theGrid[SquareNum + 14].LegalNextMove = true;
                    }
                    if (SquareNum + 27 < 64)
                    {
                        theGrid[SquareNum + 21].LegalNextMove = true;
                    }
                    if (SquareNum + 36 < 64)
                    {
                        theGrid[SquareNum + 28].LegalNextMove = true;
                    }
                    if (SquareNum + 45 < 64)
                    {
                        theGrid[SquareNum + 35].LegalNextMove = true;
                    }
                    if (SquareNum + 54 < 64)
                    {
                        theGrid[SquareNum + 42].LegalNextMove = true;
                    }

                    //Travels through fields Up left Angled
                    if (SquareNum - 9 > 0)
                    {
                        theGrid[SquareNum - 9].LegalNextMove = true;
                    }
                    if (SquareNum - 18 > 0)
                    {
                        theGrid[SquareNum - 14].LegalNextMove = true;
                    }
                    if (SquareNum - 27 > 0)
                    {
                        theGrid[SquareNum - 21].LegalNextMove = true;
                    }
                    if (SquareNum - 36 > 0)
                    {
                        theGrid[SquareNum - 28].LegalNextMove = true;
                    }
                    if (SquareNum - 45 > 0)
                    {
                        theGrid[SquareNum - 35].LegalNextMove = true;
                    }
                    if (SquareNum - 54 > 0)
                    {
                        theGrid[SquareNum - 42].LegalNextMove = true;
                    }


                    //Travels through fields up right Angled
                    if (SquareNum - 7 > 0)
                    {
                        theGrid[SquareNum - 7].LegalNextMove = true;
                    }
                    if (SquareNum - 14 > 0)
                    {
                        theGrid[SquareNum + 14].LegalNextMove = true;
                    }
                    if (SquareNum - 21 > 0)
                    {
                        theGrid[SquareNum + 21].LegalNextMove = true;
                    }
                    if (SquareNum - 28 > 0)
                    {
                        theGrid[SquareNum - 28].LegalNextMove = true;
                    }
                    if (SquareNum - 35 > 0)
                    {
                        theGrid[SquareNum - 35].LegalNextMove = true;
                    }
                    if (SquareNum - 42 > 0)
                    {
                        theGrid[SquareNum - 42].LegalNextMove = true;
                    }

                    break;
                case "BKG":

                    //Movement accross Records
                    if (SquareNum + 1 < 64)
                    {
                        //Movement to the right
                        theGrid[SquareNum + 1].LegalNextMove = true;
                    }
                    if (SquareNum + 7 < 64)
                    {
                        //Movement to the up left Diangonal
                        theGrid[SquareNum + 7].LegalNextMove = true;
                    }
                    if (SquareNum + 9 < 64)
                    {
                        //Movement to the up Right Diangonal
                        theGrid[SquareNum + 9].LegalNextMove = true;
                    }
                    if (SquareNum - 1 > 0)
                    {
                        //Movement to the left
                        theGrid[SquareNum - 1].LegalNextMove = true;
                    }
                    if (SquareNum - 7 > 0)
                    {
                        //Movement to the down right dianganol
                        theGrid[SquareNum - 7].LegalNextMove = true;

                    }
                    if (SquareNum - 9 > 0)
                    {
                        //Movement to the down right diaganol 
                        theGrid[SquareNum - 9].LegalNextMove = true;
                    }
                    break;

                case "WQ":
                case "BQ":

                    //Rook Controls
                    field = SquareNum % 8;
                    //If statment of Piece and if it can go out of bounds
                    if (field == 0)
                    {
                        //Travel in Records
                        theGrid[SquareNum + 1].LegalNextMove = true;
                        theGrid[SquareNum + 7].LegalNextMove = true;
                        theGrid[SquareNum + 2].LegalNextMove = true;
                        theGrid[SquareNum + 3].LegalNextMove = true;
                        theGrid[SquareNum + 4].LegalNextMove = true;
                        theGrid[SquareNum + 5].LegalNextMove = true;
                        theGrid[SquareNum + 6].LegalNextMove = true;

                        //Travels through fields
                        if (SquareNum + 8 < 64)
                        {
                            theGrid[SquareNum + 8].LegalNextMove = true;
                        }
                        if (SquareNum + 16 < 64)
                        {
                            theGrid[SquareNum + 16].LegalNextMove = true;
                        }
                        if (SquareNum + 32 < 64)
                        {
                            theGrid[SquareNum + 32].LegalNextMove = true;
                        }
                        if (SquareNum + 40 < 64)
                        {
                            theGrid[SquareNum + 40].LegalNextMove = true;
                        }
                        if (SquareNum + 48 < 64)
                        {
                            theGrid[SquareNum + 48].LegalNextMove = true;
                        }
                        if (SquareNum + 56 < 64)
                        {
                            theGrid[SquareNum + 56].LegalNextMove = true;
                        }

                        else if (field == 1)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum + 4].LegalNextMove = true;
                            theGrid[SquareNum + 5].LegalNextMove = true;
                            theGrid[SquareNum + 6].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }

                        }
                        else if (field == 2)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum + 4].LegalNextMove = true;
                            theGrid[SquareNum + 5].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }

                        }
                        else if (field == 3)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum + 4].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 4)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum + 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 5)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum + 2].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 5].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 6)
                        {
                            //Travel in Records
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum + 1].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 5].LegalNextMove = true;
                            theGrid[SquareNum - 6].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }
                        }
                        else if (field == 7)
                        {
                            //Travel in Records

                            theGrid[SquareNum - 7].LegalNextMove = true;
                            theGrid[SquareNum - 6].LegalNextMove = true;
                            theGrid[SquareNum - 1].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;
                            theGrid[SquareNum - 3].LegalNextMove = true;
                            theGrid[SquareNum - 4].LegalNextMove = true;
                            theGrid[SquareNum - 5].LegalNextMove = true;
                            theGrid[SquareNum - 2].LegalNextMove = true;

                            //Travels through fields
                            if (SquareNum + 8 < 64)
                            {
                                theGrid[SquareNum + 8].LegalNextMove = true;
                            }
                            if (SquareNum + 16 < 64)
                            {
                                theGrid[SquareNum + 16].LegalNextMove = true;
                            }
                            if (SquareNum + 32 < 64)
                            {
                                theGrid[SquareNum + 32].LegalNextMove = true;
                            }
                            if (SquareNum + 40 < 64)
                            {
                                theGrid[SquareNum + 40].LegalNextMove = true;
                            }
                            if (SquareNum + 48 < 64)
                            {
                                theGrid[SquareNum + 48].LegalNextMove = true;
                            }
                            if (SquareNum + 56 < 64)
                            {
                                theGrid[SquareNum + 56].LegalNextMove = true;
                            }

                            //Bishop Controls:


                            //Travels through fields down left Angled
                            if (SquareNum + 7 < 64)
                            {
                                theGrid[SquareNum + 7].LegalNextMove = true;
                            }
                            if (SquareNum + 14 < 64)
                            {
                                theGrid[SquareNum + 14].LegalNextMove = true;
                            }
                            if (SquareNum + 21 < 64)
                            {
                                theGrid[SquareNum + 21].LegalNextMove = true;
                            }
                            if (SquareNum + 28 < 64)
                            {
                                theGrid[SquareNum + 28].LegalNextMove = true;
                            }
                            if (SquareNum + 35 < 64)
                            {
                                theGrid[SquareNum + 35].LegalNextMove = true;
                            }
                            if (SquareNum + 42 < 64)
                            {
                                theGrid[SquareNum + 42].LegalNextMove = true;
                            }

                            //Travels through fields down right Angled
                            if (SquareNum + 9 < 64)
                            {
                                theGrid[SquareNum + 9].LegalNextMove = true;
                            }
                            if (SquareNum + 18 < 64)
                            {
                                theGrid[SquareNum + 14].LegalNextMove = true;
                            }
                            if (SquareNum + 27 < 64)
                            {
                                theGrid[SquareNum + 21].LegalNextMove = true;
                            }
                            if (SquareNum + 36 < 64)
                            {
                                theGrid[SquareNum + 28].LegalNextMove = true;
                            }
                            if (SquareNum + 45 < 64)
                            {
                                theGrid[SquareNum + 35].LegalNextMove = true;
                            }
                            if (SquareNum + 54 < 64)
                            {
                                theGrid[SquareNum + 42].LegalNextMove = true;
                            }

                            //Travels through fields Up left Angled
                            if (SquareNum - 9 > 0)
                            {
                                theGrid[SquareNum - 9].LegalNextMove = true;
                            }
                            if (SquareNum - 18 > 0)
                            {
                                theGrid[SquareNum - 14].LegalNextMove = true;
                            }
                            if (SquareNum - 27 > 0)
                            {
                                theGrid[SquareNum - 21].LegalNextMove = true;
                            }
                            if (SquareNum - 36 > 0)
                            {
                                theGrid[SquareNum - 28].LegalNextMove = true;
                            }
                            if (SquareNum - 45 > 0)
                            {
                                theGrid[SquareNum - 35].LegalNextMove = true;
                            }
                            if (SquareNum - 54 > 0)
                            {
                                theGrid[SquareNum - 42].LegalNextMove = true;
                            }


                            //Travels through fields up right Angled
                            if (SquareNum - 7 > 0)
                            {
                                theGrid[SquareNum - 7].LegalNextMove = true;
                            }
                            if (SquareNum - 14 > 0)
                            {
                                theGrid[SquareNum + 14].LegalNextMove = true;
                            }
                            if (SquareNum - 21 > 0)
                            {
                                theGrid[SquareNum + 21].LegalNextMove = true;
                            }
                            if (SquareNum - 28 > 0)
                            {
                                theGrid[SquareNum - 28].LegalNextMove = true;
                            }
                            if (SquareNum - 35 > 0)
                            {
                                theGrid[SquareNum - 35].LegalNextMove = true;
                            }
                            if (SquareNum - 42 > 0)
                            {
                                theGrid[SquareNum - 42].LegalNextMove = true;
                            }
                        }
                    }

                    break;

                case "BP":

                    if (SquareNum + 8 < 64)
                    {
                        //Movement Upward
                        theGrid[SquareNum + 8].LegalNextMove = true;
                    }
                    break;
                case "WP":

                    if (SquareNum - 8 < 64)
                    {
                        //Movement Downward
                        theGrid[SquareNum - 8].LegalNextMove = true;
                    }
                    break;


                case "WK":
                case "BK":

                    //Down 1 and 3 right 
                    if (SquareNum + 10 < 64)
                    {
                        theGrid[SquareNum + 10].LegalNextMove = true;
                    }
                    //Up 1 and 3 right
                    if (SquareNum - 6 > 0)
                    {
                        theGrid[SquareNum - 6].LegalNextMove = true;
                    }
                    //Up 1 and 3 left
                    if (SquareNum - 10 > 0)
                    {
                        theGrid[SquareNum - 10].LegalNextMove = true;
                    }
                    //Down 1 and 3 left
                    if (SquareNum + 6 < 64)
                    {
                        theGrid[SquareNum - 10].LegalNextMove = true;
                    }
                    break;
            }


        }
    }
}
