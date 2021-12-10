
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
            this.pnlNewUser = new System.Windows.Forms.Panel();
            this.lblNewUserPassword = new System.Windows.Forms.Label();
            this.lblNewUserUsername = new System.Windows.Forms.Label();
            this.lblNewUserLastName = new System.Windows.Forms.Label();
            this.lblNewUserFirstName = new System.Windows.Forms.Label();
            this.txtNewUserUsername = new System.Windows.Forms.TextBox();
            this.txtNewUserFname = new System.Windows.Forms.TextBox();
            this.txtNewUserPassword = new System.Windows.Forms.TextBox();
            this.txtNewUserLname = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grbLoginLogin = new System.Windows.Forms.GroupBox();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grbNewUserRegister = new System.Windows.Forms.GroupBox();
            this.btnNewUserRegister = new System.Windows.Forms.Button();
            this.btnNewUserCancel = new System.Windows.Forms.Button();
            this.btnMenuLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.grbLoginLogin.SuspendLayout();
            this.grbLoginPassword.SuspendLayout();
            this.grbLoginUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlChessBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grbNewUserRegister.SuspendLayout();
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
            this.btnFirstPlayer.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPlayer.Location = new System.Drawing.Point(57, 283);
            this.btnFirstPlayer.Name = "btnFirstPlayer";
            this.btnFirstPlayer.Size = new System.Drawing.Size(89, 49);
            this.btnFirstPlayer.TabIndex = 0;
            this.btnFirstPlayer.Text = "&1 Player";
            this.btnFirstPlayer.UseVisualStyleBackColor = false;
            this.btnFirstPlayer.Click += new System.EventHandler(this.btnFirstPlayer_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(194, 283);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(89, 49);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "&Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnSecondPlayer
            // 
            this.btnSecondPlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSecondPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondPlayer.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondPlayer.Location = new System.Drawing.Point(325, 283);
            this.btnSecondPlayer.Name = "btnSecondPlayer";
            this.btnSecondPlayer.Size = new System.Drawing.Size(89, 49);
            this.btnSecondPlayer.TabIndex = 2;
            this.btnSecondPlayer.Text = "&2 Player";
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
            this.pnlLogin.Controls.Add(this.grbLoginLogin);
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(479, 479);
            this.pnlLogin.TabIndex = 0;
            // 
            // pnlNewUser
            // 
            this.pnlNewUser.Controls.Add(this.grbNewUserRegister);
            this.pnlNewUser.Controls.Add(this.pictureBox5);
            this.pnlNewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNewUser.Location = new System.Drawing.Point(0, 0);
            this.pnlNewUser.Name = "pnlNewUser";
            this.pnlNewUser.Size = new System.Drawing.Size(479, 479);
            this.pnlNewUser.TabIndex = 1;
            // 
            // lblNewUserPassword
            // 
            this.lblNewUserPassword.AutoSize = true;
            this.lblNewUserPassword.Location = new System.Drawing.Point(53, 150);
            this.lblNewUserPassword.Name = "lblNewUserPassword";
            this.lblNewUserPassword.Size = new System.Drawing.Size(53, 13);
            this.lblNewUserPassword.TabIndex = 8;
            this.lblNewUserPassword.Text = "Password";
            this.lblNewUserPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNewUserUsername
            // 
            this.lblNewUserUsername.AutoSize = true;
            this.lblNewUserUsername.Location = new System.Drawing.Point(53, 111);
            this.lblNewUserUsername.Name = "lblNewUserUsername";
            this.lblNewUserUsername.Size = new System.Drawing.Size(55, 13);
            this.lblNewUserUsername.TabIndex = 7;
            this.lblNewUserUsername.Text = "Username";
            // 
            // lblNewUserLastName
            // 
            this.lblNewUserLastName.AutoSize = true;
            this.lblNewUserLastName.BackColor = System.Drawing.Color.Silver;
            this.lblNewUserLastName.Location = new System.Drawing.Point(50, 74);
            this.lblNewUserLastName.Name = "lblNewUserLastName";
            this.lblNewUserLastName.Size = new System.Drawing.Size(58, 13);
            this.lblNewUserLastName.TabIndex = 6;
            this.lblNewUserLastName.Text = "Last Name";
            // 
            // lblNewUserFirstName
            // 
            this.lblNewUserFirstName.AutoSize = true;
            this.lblNewUserFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUserFirstName.Location = new System.Drawing.Point(51, 34);
            this.lblNewUserFirstName.Name = "lblNewUserFirstName";
            this.lblNewUserFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblNewUserFirstName.TabIndex = 5;
            this.lblNewUserFirstName.Text = "First Name";
            // 
            // txtNewUserUsername
            // 
            this.txtNewUserUsername.Location = new System.Drawing.Point(118, 108);
            this.txtNewUserUsername.Name = "txtNewUserUsername";
            this.txtNewUserUsername.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserUsername.TabIndex = 2;
            // 
            // txtNewUserFname
            // 
            this.txtNewUserFname.Location = new System.Drawing.Point(118, 34);
            this.txtNewUserFname.Name = "txtNewUserFname";
            this.txtNewUserFname.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserFname.TabIndex = 0;
            this.txtNewUserFname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNewUserPassword
            // 
            this.txtNewUserPassword.Location = new System.Drawing.Point(118, 147);
            this.txtNewUserPassword.Name = "txtNewUserPassword";
            this.txtNewUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserPassword.TabIndex = 3;
            // 
            // txtNewUserLname
            // 
            this.txtNewUserLname.Location = new System.Drawing.Point(118, 74);
            this.txtNewUserLname.Name = "txtNewUserLname";
            this.txtNewUserLname.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserLname.TabIndex = 1;
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
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // grbLoginLogin
            // 
            this.grbLoginLogin.Controls.Add(this.llLoginSignUp);
            this.grbLoginLogin.Controls.Add(this.btnLoginEnter);
            this.grbLoginLogin.Controls.Add(this.grbLoginPassword);
            this.grbLoginLogin.Controls.Add(this.grbLoginUsername);
            this.grbLoginLogin.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoginLogin.Location = new System.Drawing.Point(55, 72);
            this.grbLoginLogin.Name = "grbLoginLogin";
            this.grbLoginLogin.Size = new System.Drawing.Size(357, 330);
            this.grbLoginLogin.TabIndex = 2;
            this.grbLoginLogin.TabStop = false;
            this.grbLoginLogin.Text = "Login";
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
            this.llLoginSignUp.Text = "&Sign Up!";
            this.llLoginSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLoginSignUp_LinkClicked);
            // 
            // btnLoginEnter
            // 
            this.btnLoginEnter.BackColor = System.Drawing.Color.Gold;
            this.btnLoginEnter.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginEnter.Location = new System.Drawing.Point(178, 229);
            this.btnLoginEnter.Name = "btnLoginEnter";
            this.btnLoginEnter.Size = new System.Drawing.Size(97, 40);
            this.btnLoginEnter.TabIndex = 4;
            this.btnLoginEnter.Text = "&Enter";
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
            this.pnlMenu.Controls.Add(this.btnMenuLogOut);
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
            this.pnlStatistics.Controls.Add(this.btnBack);
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
            this.pnlChessBoard.Controls.Add(this.button2);
            this.pnlChessBoard.Controls.Add(this.button1);
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(173, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 58);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grbNewUserRegister
            // 
            this.grbNewUserRegister.Controls.Add(this.btnNewUserCancel);
            this.grbNewUserRegister.Controls.Add(this.btnNewUserRegister);
            this.grbNewUserRegister.Controls.Add(this.lblNewUserPassword);
            this.grbNewUserRegister.Controls.Add(this.txtNewUserPassword);
            this.grbNewUserRegister.Controls.Add(this.txtNewUserUsername);
            this.grbNewUserRegister.Controls.Add(this.lblNewUserUsername);
            this.grbNewUserRegister.Controls.Add(this.txtNewUserFname);
            this.grbNewUserRegister.Controls.Add(this.txtNewUserLname);
            this.grbNewUserRegister.Controls.Add(this.lblNewUserLastName);
            this.grbNewUserRegister.Controls.Add(this.lblNewUserFirstName);
            this.grbNewUserRegister.Location = new System.Drawing.Point(106, 210);
            this.grbNewUserRegister.Name = "grbNewUserRegister";
            this.grbNewUserRegister.Size = new System.Drawing.Size(257, 246);
            this.grbNewUserRegister.TabIndex = 9;
            this.grbNewUserRegister.TabStop = false;
            this.grbNewUserRegister.Text = "Register";
            // 
            // btnNewUserRegister
            // 
            this.btnNewUserRegister.BackColor = System.Drawing.Color.Gold;
            this.btnNewUserRegister.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUserRegister.Location = new System.Drawing.Point(138, 200);
            this.btnNewUserRegister.Name = "btnNewUserRegister";
            this.btnNewUserRegister.Size = new System.Drawing.Size(113, 40);
            this.btnNewUserRegister.TabIndex = 10;
            this.btnNewUserRegister.Text = "Register";
            this.btnNewUserRegister.UseVisualStyleBackColor = false;
            this.btnNewUserRegister.Click += new System.EventHandler(this.btnNewUserRegister_Click);
            // 
            // btnNewUserCancel
            // 
            this.btnNewUserCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewUserCancel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUserCancel.Location = new System.Drawing.Point(6, 200);
            this.btnNewUserCancel.Name = "btnNewUserCancel";
            this.btnNewUserCancel.Size = new System.Drawing.Size(113, 40);
            this.btnNewUserCancel.TabIndex = 11;
            this.btnNewUserCancel.Text = "Cancel";
            this.btnNewUserCancel.UseVisualStyleBackColor = false;
            this.btnNewUserCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenuLogOut
            // 
            this.btnMenuLogOut.BackColor = System.Drawing.Color.Red;
            this.btnMenuLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLogOut.Location = new System.Drawing.Point(389, 440);
            this.btnMenuLogOut.Name = "btnMenuLogOut";
            this.btnMenuLogOut.Size = new System.Drawing.Size(87, 36);
            this.btnMenuLogOut.TabIndex = 3;
            this.btnMenuLogOut.Text = "&Log Out";
            this.btnMenuLogOut.UseVisualStyleBackColor = false;
            this.btnMenuLogOut.Click += new System.EventHandler(this.btnMenuLogOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(61, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 58);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 479);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlNewUser);
            this.Controls.Add(this.pnlStatistics);
            this.Name = "Form1";
            this.Text = "Chess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlNewUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.grbLoginLogin.ResumeLayout(false);
            this.grbLoginLogin.PerformLayout();
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
            this.grbNewUserRegister.ResumeLayout(false);
            this.grbNewUserRegister.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbLoginLogin;
        private System.Windows.Forms.GroupBox grbLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLoginEnter;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel llLoginSignUp;
        private System.Windows.Forms.Panel pnlNewUser;
        private System.Windows.Forms.Label lblNewUserPassword;
        private System.Windows.Forms.Label lblNewUserUsername;
        private System.Windows.Forms.Label lblNewUserLastName;
        private System.Windows.Forms.Label lblNewUserFirstName;
        private System.Windows.Forms.TextBox txtNewUserUsername;
        private System.Windows.Forms.TextBox txtNewUserFname;
        private System.Windows.Forms.TextBox txtNewUserPassword;
        private System.Windows.Forms.TextBox txtNewUserLname;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grbNewUserRegister;
        private System.Windows.Forms.Button btnNewUserCancel;
        private System.Windows.Forms.Button btnNewUserRegister;
        private System.Windows.Forms.Button btnMenuLogOut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

