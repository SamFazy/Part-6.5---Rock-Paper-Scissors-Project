namespace Part_6._5___Rock_Paper_Scissors_Project
{
    partial class frmRockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockPaperScissors));
            this.picRock = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1Middle = new System.Windows.Forms.Label();
            this.lblPcMiddle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPlayer1Left = new System.Windows.Forms.Label();
            this.lblPlayer1Right = new System.Windows.Forms.Label();
            this.lblPcLeft = new System.Windows.Forms.Label();
            this.lblPcRight = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // picRock
            // 
            this.picRock.BackColor = System.Drawing.Color.Transparent;
            this.picRock.Image = ((System.Drawing.Image)(resources.GetObject("picRock.Image")));
            this.picRock.Location = new System.Drawing.Point(119, 108);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(150, 150);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(237, 19);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(347, 31);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Choose Rock, Paper, or Scissors";
            // 
            // picPaper
            // 
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.Location = new System.Drawing.Point(334, 108);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(150, 150);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper.TabIndex = 4;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
            // 
            // picScissors
            // 
            this.picScissors.Image = ((System.Drawing.Image)(resources.GetObject("picScissors.Image")));
            this.picScissors.Location = new System.Drawing.Point(556, 108);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(150, 150);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissors.TabIndex = 5;
            this.picScissors.TabStop = false;
            this.picScissors.Click += new System.EventHandler(this.picScissors_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(119, 325);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(334, 325);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(556, 325);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 150);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // lblPlayer1Middle
            // 
            this.lblPlayer1Middle.AutoSize = true;
            this.lblPlayer1Middle.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Middle.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Middle.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer1Middle.Location = new System.Drawing.Point(357, 74);
            this.lblPlayer1Middle.Name = "lblPlayer1Middle";
            this.lblPlayer1Middle.Size = new System.Drawing.Size(101, 31);
            this.lblPlayer1Middle.TabIndex = 9;
            this.lblPlayer1Middle.Text = "Player 1";
            // 
            // lblPcMiddle
            // 
            this.lblPcMiddle.AutoSize = true;
            this.lblPcMiddle.BackColor = System.Drawing.Color.Transparent;
            this.lblPcMiddle.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcMiddle.ForeColor = System.Drawing.Color.Yellow;
            this.lblPcMiddle.Location = new System.Drawing.Point(385, 291);
            this.lblPcMiddle.Name = "lblPcMiddle";
            this.lblPcMiddle.Size = new System.Drawing.Size(42, 31);
            this.lblPcMiddle.TabIndex = 10;
            this.lblPcMiddle.Text = "PC";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(9, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(86, 31);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Result:";
            // 
            // lblPlayer1Left
            // 
            this.lblPlayer1Left.AutoSize = true;
            this.lblPlayer1Left.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Left.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Left.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer1Left.Location = new System.Drawing.Point(144, 74);
            this.lblPlayer1Left.Name = "lblPlayer1Left";
            this.lblPlayer1Left.Size = new System.Drawing.Size(101, 31);
            this.lblPlayer1Left.TabIndex = 12;
            this.lblPlayer1Left.Text = "Player 1";
            this.lblPlayer1Left.Visible = false;
            // 
            // lblPlayer1Right
            // 
            this.lblPlayer1Right.AutoSize = true;
            this.lblPlayer1Right.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Right.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Right.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer1Right.Location = new System.Drawing.Point(579, 74);
            this.lblPlayer1Right.Name = "lblPlayer1Right";
            this.lblPlayer1Right.Size = new System.Drawing.Size(101, 31);
            this.lblPlayer1Right.TabIndex = 13;
            this.lblPlayer1Right.Text = "Player 1";
            this.lblPlayer1Right.Visible = false;
            // 
            // lblPcLeft
            // 
            this.lblPcLeft.AutoSize = true;
            this.lblPcLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblPcLeft.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcLeft.ForeColor = System.Drawing.Color.Yellow;
            this.lblPcLeft.Location = new System.Drawing.Point(170, 291);
            this.lblPcLeft.Name = "lblPcLeft";
            this.lblPcLeft.Size = new System.Drawing.Size(42, 31);
            this.lblPcLeft.TabIndex = 14;
            this.lblPcLeft.Text = "PC";
            this.lblPcLeft.Visible = false;
            // 
            // lblPcRight
            // 
            this.lblPcRight.AutoSize = true;
            this.lblPcRight.BackColor = System.Drawing.Color.Transparent;
            this.lblPcRight.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcRight.ForeColor = System.Drawing.Color.Yellow;
            this.lblPcRight.Location = new System.Drawing.Point(606, 291);
            this.lblPcRight.Name = "lblPcRight";
            this.lblPcRight.Size = new System.Drawing.Size(42, 31);
            this.lblPcRight.TabIndex = 15;
            this.lblPcRight.Text = "PC";
            this.lblPcRight.Visible = false;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.BackColor = System.Drawing.Color.Transparent;
            this.lblWins.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.White;
            this.lblWins.Location = new System.Drawing.Point(706, 447);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(73, 31);
            this.lblWins.TabIndex = 16;
            this.lblWins.Text = "Wins:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.BackColor = System.Drawing.Color.Transparent;
            this.lblLosses.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.ForeColor = System.Drawing.Color.White;
            this.lblLosses.Location = new System.Drawing.Point(705, 482);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(89, 31);
            this.lblLosses.TabIndex = 17;
            this.lblLosses.Text = "Losses:";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.BackColor = System.Drawing.Color.Transparent;
            this.lblTies.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.ForeColor = System.Drawing.Color.White;
            this.lblTies.Location = new System.Drawing.Point(706, 519);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(62, 31);
            this.lblTies.TabIndex = 18;
            this.lblTies.Text = "Ties:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(3, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 561);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblPcRight);
            this.Controls.Add(this.lblPcLeft);
            this.Controls.Add(this.lblPlayer1Right);
            this.Controls.Add(this.lblPlayer1Left);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPcMiddle);
            this.Controls.Add(this.lblPlayer1Middle);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.picRock);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblPlayer1Middle;
        private System.Windows.Forms.Label lblPcMiddle;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPlayer1Left;
        private System.Windows.Forms.Label lblPlayer1Right;
        private System.Windows.Forms.Label lblPcLeft;
        private System.Windows.Forms.Label lblPcRight;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Button btnClose;
    }
}

