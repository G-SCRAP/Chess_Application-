//Gavin Ogreni nt 
//12/6/2021
//Chess board game


using ChessBoardModel3;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Application
{
    public partial class Form1 : Form
    {
        Board GameBoard = new Board();
        List<int> Move = new List<int>(); 
        Board myboard = new Board();
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnFirstPlayer_Click(object sender, EventArgs e)
        {

            pnlMenu.Visible = false;
            pnlChessBoard.Visible = true; 
            PrintBoard(GameBoard);

        }
        private void PrintBoard(Board GameBoard)
        {

            if (Move.Count == 2)
            {
                //Creates new cell 
                //Check for user Pressing a piece. 
                int Move1 = Move[0];
                int Move2 = Move[1];
                Cell PieceCell = GameBoard.theGrid[Move1];
                Cell EmptyCell = GameBoard.theGrid[Move2];
                Move.Clear();
                
                //If square is empty it will do a recursuion call
                if (PieceCell.Piece == "E")
                {
                    PrintBoard(GameBoard);
                }
                //Make sure that user does select a empty space
                if (EmptyCell.Piece != "E")
                {
                    MessageBox.Show("Error: Select Empty Space", "Illegal Move", MessageBoxButtons.OK);
                    PrintBoard(GameBoard);
                }

                //Catches out of range exception. 
                try
                {
                    GameBoard.LegalMove(PieceCell.Piece, Move1);
                }
                catch (Exception e)
                {
                    PrintBoard(GameBoard);
                }
                if (EmptyCell.LegalNextMove == true)
                {

                    EmptyCell.Piece = $"{PieceCell.Piece}";

                    Image piece = null;
                    //Pices throw exception 
                    foreach (Button btn in pnlChessBoard.Controls)
                    {
                        if (Convert.ToInt32(btn.Tag) == Move1)
                        {
                            piece = btn.Image;
                            btn.Image = null;
                        }
                    }
                    foreach (Button btn in pnlChessBoard.Controls)
                    {
                        if (Convert.ToInt32(btn.Tag) == Move2)
                        {
                            btn.Image = piece;
                        }
                    }
                    PieceCell.Piece = "E";
                    PrintBoard(GameBoard);
                }
                else
                {
                    //If its a illeegal move
                    MessageBox.Show("Error: Piece cannot do Move", "Illegal Move");
                    PrintBoard(GameBoard);
                }
            }
            else if (Move.Count == 1)
            {

            }
            else
            {
                Move.Clear();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginEnter_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlStatistics.Visible = false;
            pnlNewUser.Visible = false;
            pnlChessBoard.Visible = false; 
            pnlMenu.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pnlStatistics.Visible = false; 
        }

        private void llLoginSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pnlLogin.Visible = false; 
            pnlNewUser.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNewUser.Visible = false;
            pnlLogin.Visible = true; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewUserRegister_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlNewUser.Visible = false; 
        }

        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?","Log Out", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);            
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            pnlStatistics.Visible = true;
            pnlMenu.Visible = false; 
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void TileClick(object sender, EventArgs e)
        {
            int tile = Convert.ToInt32((sender as Button).Tag);
            Console.WriteLine(tile);
            Console.WriteLine("Title Click");
            Move.Add(tile);
            if (Move.Count == 2)  
            PrintBoard(GameBoard);
           
        }

        private void btnSecondPlayer_Click(object sender, EventArgs e)
        {
            pnlChessBoard.Visible = true;
            pnlMenu.Visible = false; 
        }
    }
}
