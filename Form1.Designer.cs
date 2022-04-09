namespace TICTACTOE_MA
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpDifficulty = new System.Windows.Forms.GroupBox();
            this.rdoHardDiff = new System.Windows.Forms.RadioButton();
            this.rdoMediumDiff = new System.Windows.Forms.RadioButton();
            this.rdoEasyDiff = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lblPlayerScoreNum = new System.Windows.Forms.Label();
            this.lblComputerScoreNumber = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.lblGmeNumber = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblNumberOfDraws = new System.Windows.Forms.Label();
            this.medBattlethemePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnbtnEndGame = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbGrodus = new System.Windows.Forms.PictureBox();
            this.pcbXNaut = new System.Windows.Forms.PictureBox();
            this.pcbCrump = new System.Windows.Forms.PictureBox();
            this.pcbPlayerCharacter = new System.Windows.Forms.PictureBox();
            this.lblXNautForces = new System.Windows.Forms.Label();
            this.grpDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medBattlethemePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrodus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbXNaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCrump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1449, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(239, 102);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(1449, 193);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(239, 102);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart Battle on New Difficulty";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grpDifficulty
            // 
            this.grpDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.grpDifficulty.Controls.Add(this.rdoHardDiff);
            this.grpDifficulty.Controls.Add(this.rdoMediumDiff);
            this.grpDifficulty.Controls.Add(this.rdoEasyDiff);
            this.grpDifficulty.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDifficulty.ForeColor = System.Drawing.Color.Red;
            this.grpDifficulty.Location = new System.Drawing.Point(23, 727);
            this.grpDifficulty.Name = "grpDifficulty";
            this.grpDifficulty.Size = new System.Drawing.Size(199, 195);
            this.grpDifficulty.TabIndex = 8;
            this.grpDifficulty.TabStop = false;
            this.grpDifficulty.Text = "Difficulty";
            // 
            // rdoHardDiff
            // 
            this.rdoHardDiff.AutoSize = true;
            this.rdoHardDiff.Location = new System.Drawing.Point(19, 153);
            this.rdoHardDiff.Name = "rdoHardDiff";
            this.rdoHardDiff.Size = new System.Drawing.Size(75, 25);
            this.rdoHardDiff.TabIndex = 2;
            this.rdoHardDiff.TabStop = true;
            this.rdoHardDiff.Text = "Hard";
            this.rdoHardDiff.UseVisualStyleBackColor = true;
            // 
            // rdoMediumDiff
            // 
            this.rdoMediumDiff.AutoSize = true;
            this.rdoMediumDiff.Location = new System.Drawing.Point(19, 104);
            this.rdoMediumDiff.Name = "rdoMediumDiff";
            this.rdoMediumDiff.Size = new System.Drawing.Size(100, 25);
            this.rdoMediumDiff.TabIndex = 1;
            this.rdoMediumDiff.TabStop = true;
            this.rdoMediumDiff.Text = "Medium";
            this.rdoMediumDiff.UseVisualStyleBackColor = true;
            // 
            // rdoEasyDiff
            // 
            this.rdoEasyDiff.AutoSize = true;
            this.rdoEasyDiff.Location = new System.Drawing.Point(19, 49);
            this.rdoEasyDiff.Name = "rdoEasyDiff";
            this.rdoEasyDiff.Size = new System.Drawing.Size(72, 25);
            this.rdoEasyDiff.TabIndex = 0;
            this.rdoEasyDiff.TabStop = true;
            this.rdoEasyDiff.Text = "Easy";
            this.rdoEasyDiff.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(51, 217);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(104, 41);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerScore.Location = new System.Drawing.Point(49, 304);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(216, 26);
            this.lblPlayerScore.TabIndex = 10;
            this.lblPlayerScore.Text = "Mario and friends: ";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerScore.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.Red;
            this.lblComputerScore.Location = new System.Drawing.Point(49, 346);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(106, 26);
            this.lblComputerScore.TabIndex = 11;
            this.lblComputerScore.Text = "X-Nauts:";
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Location = new System.Drawing.Point(548, 37);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(174, 101);
            this.btn1.TabIndex = 12;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.Location = new System.Drawing.Point(739, 37);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(223, 95);
            this.btn2.TabIndex = 13;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Location = new System.Drawing.Point(985, 37);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(192, 98);
            this.btn3.TabIndex = 14;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.Location = new System.Drawing.Point(548, 154);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(168, 127);
            this.btn4.TabIndex = 15;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.Location = new System.Drawing.Point(739, 154);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(223, 127);
            this.btn5.TabIndex = 16;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.Location = new System.Drawing.Point(985, 154);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(192, 127);
            this.btn6.TabIndex = 17;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.Location = new System.Drawing.Point(547, 303);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(168, 111);
            this.btn7.TabIndex = 18;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.Location = new System.Drawing.Point(739, 303);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(223, 111);
            this.btn8.TabIndex = 19;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.Location = new System.Drawing.Point(985, 303);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(192, 111);
            this.btn9.TabIndex = 20;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // lblPlayerScoreNum
            // 
            this.lblPlayerScoreNum.AutoSize = true;
            this.lblPlayerScoreNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScoreNum.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScoreNum.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerScoreNum.Location = new System.Drawing.Point(298, 304);
            this.lblPlayerScoreNum.Name = "lblPlayerScoreNum";
            this.lblPlayerScoreNum.Size = new System.Drawing.Size(0, 26);
            this.lblPlayerScoreNum.TabIndex = 21;
            // 
            // lblComputerScoreNumber
            // 
            this.lblComputerScoreNumber.AutoSize = true;
            this.lblComputerScoreNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerScoreNumber.ForeColor = System.Drawing.Color.Red;
            this.lblComputerScoreNumber.Location = new System.Drawing.Point(174, 346);
            this.lblComputerScoreNumber.Name = "lblComputerScoreNumber";
            this.lblComputerScoreNumber.Size = new System.Drawing.Size(0, 20);
            this.lblComputerScoreNumber.TabIndex = 22;
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.BackColor = System.Drawing.Color.Transparent;
            this.lblGames.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.ForeColor = System.Drawing.Color.Red;
            this.lblGames.Location = new System.Drawing.Point(53, 468);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(227, 26);
            this.lblGames.TabIndex = 23;
            this.lblGames.Text = "Number of battles: ";
            // 
            // lblGmeNumber
            // 
            this.lblGmeNumber.AutoSize = true;
            this.lblGmeNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblGmeNumber.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmeNumber.ForeColor = System.Drawing.Color.Red;
            this.lblGmeNumber.Location = new System.Drawing.Point(298, 468);
            this.lblGmeNumber.Name = "lblGmeNumber";
            this.lblGmeNumber.Size = new System.Drawing.Size(0, 26);
            this.lblGmeNumber.TabIndex = 24;
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblDraw.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.Red;
            this.lblDraw.Location = new System.Drawing.Point(49, 388);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(81, 26);
            this.lblDraw.TabIndex = 25;
            this.lblDraw.Text = "Draws:";
            // 
            // lblNumberOfDraws
            // 
            this.lblNumberOfDraws.AutoSize = true;
            this.lblNumberOfDraws.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfDraws.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDraws.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfDraws.Location = new System.Drawing.Point(155, 388);
            this.lblNumberOfDraws.Name = "lblNumberOfDraws";
            this.lblNumberOfDraws.Size = new System.Drawing.Size(0, 26);
            this.lblNumberOfDraws.TabIndex = 26;
            // 
            // medBattlethemePlayer
            // 
            this.medBattlethemePlayer.Enabled = true;
            this.medBattlethemePlayer.Location = new System.Drawing.Point(23, 535);
            this.medBattlethemePlayer.Name = "medBattlethemePlayer";
            this.medBattlethemePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("medBattlethemePlayer.OcxState")));
            this.medBattlethemePlayer.Size = new System.Drawing.Size(151, 90);
            this.medBattlethemePlayer.TabIndex = 27;
            this.medBattlethemePlayer.Visible = false;
            // 
            // btnbtnEndGame
            // 
            this.btnbtnEndGame.BackColor = System.Drawing.SystemColors.Control;
            this.btnbtnEndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbtnEndGame.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbtnEndGame.Location = new System.Drawing.Point(25, 26);
            this.btnbtnEndGame.Name = "btnbtnEndGame";
            this.btnbtnEndGame.Size = new System.Drawing.Size(109, 47);
            this.btnbtnEndGame.TabIndex = 28;
            this.btnbtnEndGame.Text = "Close Game";
            this.btnbtnEndGame.UseVisualStyleBackColor = false;
            this.btnbtnEndGame.Click += new System.EventHandler(this.btnFullGameRestart_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(547, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(630, 10);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(547, 138);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(630, 10);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(968, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 375);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(722, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 375);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pcbGrodus
            // 
            this.pcbGrodus.BackColor = System.Drawing.Color.Transparent;
            this.pcbGrodus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbGrodus.Location = new System.Drawing.Point(1388, 417);
            this.pcbGrodus.Name = "pcbGrodus";
            this.pcbGrodus.Size = new System.Drawing.Size(259, 308);
            this.pcbGrodus.TabIndex = 29;
            this.pcbGrodus.TabStop = false;
            // 
            // pcbXNaut
            // 
            this.pcbXNaut.BackColor = System.Drawing.Color.Transparent;
            this.pcbXNaut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbXNaut.Location = new System.Drawing.Point(1071, 576);
            this.pcbXNaut.Name = "pcbXNaut";
            this.pcbXNaut.Size = new System.Drawing.Size(150, 175);
            this.pcbXNaut.TabIndex = 30;
            this.pcbXNaut.TabStop = false;
            // 
            // pcbCrump
            // 
            this.pcbCrump.BackColor = System.Drawing.Color.Transparent;
            this.pcbCrump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbCrump.Location = new System.Drawing.Point(1227, 518);
            this.pcbCrump.Name = "pcbCrump";
            this.pcbCrump.Size = new System.Drawing.Size(178, 233);
            this.pcbCrump.TabIndex = 31;
            this.pcbCrump.TabStop = false;
            // 
            // pcbPlayerCharacter
            // 
            this.pcbPlayerCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pcbPlayerCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbPlayerCharacter.Location = new System.Drawing.Point(384, 468);
            this.pcbPlayerCharacter.Name = "pcbPlayerCharacter";
            this.pcbPlayerCharacter.Size = new System.Drawing.Size(204, 257);
            this.pcbPlayerCharacter.TabIndex = 32;
            this.pcbPlayerCharacter.TabStop = false;
            // 
            // lblXNautForces
            // 
            this.lblXNautForces.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lblXNautForces.AutoSize = true;
            this.lblXNautForces.BackColor = System.Drawing.Color.Transparent;
            this.lblXNautForces.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXNautForces.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblXNautForces.Location = new System.Drawing.Point(1355, 806);
            this.lblXNautForces.Name = "lblXNautForces";
            this.lblXNautForces.Size = new System.Drawing.Size(0, 39);
            this.lblXNautForces.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::TICTACTOE_MA.Properties.Resources.Stage_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1737, 982);
            this.Controls.Add(this.pcbCrump);
            this.Controls.Add(this.pcbXNaut);
            this.Controls.Add(this.lblXNautForces);
            this.Controls.Add(this.pcbPlayerCharacter);
            this.Controls.Add(this.btnbtnEndGame);
            this.Controls.Add(this.medBattlethemePlayer);
            this.Controls.Add(this.lblNumberOfDraws);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblGmeNumber);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lblComputerScoreNumber);
            this.Controls.Add(this.lblPlayerScoreNum);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.grpDifficulty);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pcbGrodus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDifficulty.ResumeLayout(false);
            this.grpDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medBattlethemePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrodus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbXNaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCrump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox grpDifficulty;
        private System.Windows.Forms.RadioButton rdoHardDiff;
        private System.Windows.Forms.RadioButton rdoMediumDiff;
        private System.Windows.Forms.RadioButton rdoEasyDiff;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label lblPlayerScoreNum;
        private System.Windows.Forms.Label lblComputerScoreNumber;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Label lblGmeNumber;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblNumberOfDraws;
        private AxWMPLib.AxWindowsMediaPlayer medBattlethemePlayer;
        private System.Windows.Forms.Button btnbtnEndGame;
        private System.Windows.Forms.PictureBox pcbGrodus;
        private System.Windows.Forms.PictureBox pcbXNaut;
        private System.Windows.Forms.PictureBox pcbCrump;
        private System.Windows.Forms.PictureBox pcbPlayerCharacter;
        private System.Windows.Forms.Label lblXNautForces;
    }
}

