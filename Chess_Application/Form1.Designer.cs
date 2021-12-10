
namespace Chess_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFirstPlayer = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnSecondPlayer = new System.Windows.Forms.Button();
            this.pnlMenuHighlightbtn = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.llLoginSignUp = new System.Windows.Forms.LinkLabel();
            this.btnLoginEnter = new System.Windows.Forms.Button();
            this.grbLoginPassword = new System.Windows.Forms.GroupBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.grbLoginUsername = new System.Windows.Forms.GroupBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbLoginPassword.SuspendLayout();
            this.grbLoginUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlChessBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFirstPlayer
            // 
            this.btnFirstPlayer.BackColor = System.Drawing.Color.DimGray;
            this.btnFirstPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPlayer.Location = new System.Drawing.Point(57, 283);
            this.btnFirstPlayer.Name = "btnFirstPlayer";
            this.btnFirstPlayer.Size = new System.Drawing.Size(89, 49);
            this.btnFirstPlayer.TabIndex = 1;
            this.btnFirstPlayer.Text = "1 Player";
            this.btnFirstPlayer.UseVisualStyleBackColor = false;
            this.btnFirstPlayer.Click += new System.EventHandler(this.btnFirstPlayer_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Location = new System.Drawing.Point(194, 283);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(89, 49);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            // 
            // btnSecondPlayer
            // 
            this.btnSecondPlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSecondPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondPlayer.Location = new System.Drawing.Point(325, 283);
            this.btnSecondPlayer.Name = "btnSecondPlayer";
            this.btnSecondPlayer.Size = new System.Drawing.Size(89, 49);
            this.btnSecondPlayer.TabIndex = 3;
            this.btnSecondPlayer.Text = "2 Player";
            this.btnSecondPlayer.UseVisualStyleBackColor = false;
            // 
            // pnlMenuHighlightbtn
            // 
            this.pnlMenuHighlightbtn.BackColor = System.Drawing.Color.Black;
            this.pnlMenuHighlightbtn.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuHighlightbtn.Name = "pnlMenuHighlightbtn";
            this.pnlMenuHighlightbtn.Size = new System.Drawing.Size(18, 10);
            this.pnlMenuHighlightbtn.TabIndex = 4;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.groupBox2);
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(479, 479);
            this.pnlLogin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 479);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(220, 320);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(479, 479);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.llLoginSignUp);
            this.groupBox2.Controls.Add(this.btnLoginEnter);
            this.groupBox2.Controls.Add(this.grbLoginPassword);
            this.groupBox2.Controls.Add(this.grbLoginUsername);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // llLoginSignUp
            // 
            this.llLoginSignUp.AutoSize = true;
            this.llLoginSignUp.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLoginSignUp.Location = new System.Drawing.Point(120, 211);
            this.llLoginSignUp.Name = "llLoginSignUp";
            this.llLoginSignUp.Size = new System.Drawing.Size(66, 15);
            this.llLoginSignUp.TabIndex = 2;
            this.llLoginSignUp.TabStop = true;
            this.llLoginSignUp.Text = "Sign Up!";
            // 
            // btnLoginEnter
            // 
            this.btnLoginEnter.BackColor = System.Drawing.Color.Gold;
            this.btnLoginEnter.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginEnter.Location = new System.Drawing.Point(178, 229);
            this.btnLoginEnter.Name = "btnLoginEnter";
            this.btnLoginEnter.Size = new System.Drawing.Size(97, 40);
            this.btnLoginEnter.TabIndex = 4;
            this.btnLoginEnter.Text = "Enter";
            this.btnLoginEnter.UseVisualStyleBackColor = false;
            this.btnLoginEnter.Click += new System.EventHandler(this.btnLoginEnter_Click);
            // 
            // grbLoginPassword
            // 
            this.grbLoginPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.grbLoginPassword.Controls.Add(this.txtLoginPassword);
            this.grbLoginPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoginPassword.Location = new System.Drawing.Point(123, 164);
            this.grbLoginPassword.Name = "grbLoginPassword";
            this.grbLoginPassword.Size = new System.Drawing.Size(105, 44);
            this.grbLoginPassword.TabIndex = 3;
            this.grbLoginPassword.TabStop = false;
            this.grbLoginPassword.Text = "Password";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPassword.Location = new System.Drawing.Point(0, 16);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(105, 25);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // grbLoginUsername
            // 
            this.grbLoginUsername.BackColor = System.Drawing.Color.Cornsilk;
            this.grbLoginUsername.Controls.Add(this.txtLoginUsername);
            this.grbLoginUsername.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoginUsername.Location = new System.Drawing.Point(123, 114);
            this.grbLoginUsername.Name = "grbLoginUsername";
            this.grbLoginUsername.Size = new System.Drawing.Size(105, 44);
            this.grbLoginUsername.TabIndex = 2;
            this.grbLoginUsername.TabStop = false;
            this.grbLoginUsername.Text = "Username";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.BackColor = System.Drawing.Color.Cornsilk;
            this.txtLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginUsername.Location = new System.Drawing.Point(0, 16);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(105, 25);
            this.txtLoginUsername.TabIndex = 1;
            this.txtLoginUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 480);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlStatistics);
            this.pnlMenu.Controls.Add(this.btnStats);
            this.pnlMenu.Controls.Add(this.btnFirstPlayer);
            this.pnlMenu.Controls.Add(this.btnSecondPlayer);
            this.pnlMenu.Controls.Add(this.pnlMenuHighlightbtn);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(479, 479);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Controls.Add(this.pictureBox4);
            this.pnlStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatistics.Location = new System.Drawing.Point(0, 0);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(479, 479);
            this.pnlStatistics.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(479, 479);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Controls.Add(this.pictureBox3);
            this.pnlChessBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChessBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(479, 479);
            this.pnlChessBoard.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(479, 479);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 479);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlChessBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbLoginPassword.ResumeLayout(false);
            this.grbLoginPassword.PerformLayout();
            this.grbLoginUsername.ResumeLayout(false);
            this.grbLoginUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlChessBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFirstPlayer;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnSecondPlayer;
        private System.Windows.Forms.Panel pnlMenuHighlightbtn;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.GroupBox grbLoginUsername;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLoginEnter;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel llLoginSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

