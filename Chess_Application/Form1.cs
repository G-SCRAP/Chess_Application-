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
        public Form1()
        {
            InitializeComponent();
        }
       
        
        public static void ChessBoard()
        {

        }
        public static void CopyFrom()
        {

        }
        public static void ReadBoard()
        {

        }
        public static void SaveBoard()
        {

        }
        public static void LoadBoard()
        {

        }
        public static void ResetBoard()
        {

        }
        public static void IsCheck()
        {

        }
      


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFirstPlayer_Click(object sender, EventArgs e)
        {
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
    }
}
