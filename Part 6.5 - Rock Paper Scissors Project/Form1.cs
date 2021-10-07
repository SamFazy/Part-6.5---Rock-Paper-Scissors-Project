using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5___Rock_Paper_Scissors_Project
{
    public partial class frmRockPaperScissors : Form

    {
        Random generator = new Random();
        int randomResult;
        int wins = 0;
        int losses = 0;
        int ties = 0;


        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            randomResult = generator.Next(1, 4);

            lblPlayer1Left.Visible = true;
            lblPlayer1Middle.Visible = false;
            lblPlayer1Right.Visible = false;


            if (randomResult == 1)
            {
                lblPcLeft.Visible = true;
                lblPcMiddle.Visible = false;
                lblPcRight.Visible = false;

                lblResult.Text = ("Result: You Tied");
                ties = ties + 1;
                
            }

            else if (randomResult == 2)
            {
                lblPcLeft.Visible = false;
                lblPcMiddle.Visible = true;
                lblPcRight.Visible = false;

                lblResult.Text = ("Result: You Lost");
                losses = losses + 1;
            }

            else if (randomResult == 3)
            {
                lblPcLeft.Visible = false;
                lblPcMiddle.Visible = false;
                lblPcRight.Visible = true;

                lblResult.Text = ("Result: You Win");
                wins = wins + 1;
            }

            lblWins.Text = ("Wins: " + wins);
            lblLosses.Text = ("Losses: " + losses);
            lblTies.Text = ("Ties: " + ties);




        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void picPaper_Click(object sender, EventArgs e)
        {
            randomResult = generator.Next(1, 4);

            lblPlayer1Left.Visible = false;
            lblPlayer1Middle.Visible = true;
            lblPlayer1Right.Visible = false;

            if (randomResult == 1)
            {
                lblPcLeft.Visible = true;
                lblPcMiddle.Visible = false;
                lblPcRight.Visible = false;

                lblResult.Text = ("Result: You Win");
                wins = wins + 1;
            }

            else if (randomResult == 2)
            {
                lblPcLeft.Visible = false;
                lblPcMiddle.Visible = true;
                lblPcRight.Visible = false;

                lblResult.Text = ("Result: You Tied");
                ties = ties + 1;
            }

            else if (randomResult == 3)
            {
                lblPcLeft.Visible = false;
                lblPcMiddle.Visible = false;
                lblPcRight.Visible = true;

                lblResult.Text = ("Result: You Lost");
                losses = losses + 1;
            }

            lblWins.Text = ("Wins: " + wins);
            lblLosses.Text = ("Losses: " + losses);
            lblTies.Text = ("Ties: " + ties);

        }

        private void picScissors_Click(object sender, EventArgs e)
        {
            randomResult = generator.Next(1, 4);

            lblPlayer1Left.Visible = false;
            lblPlayer1Middle.Visible = false;
            lblPlayer1Right.Visible = true;

            if (randomResult == 1)
            {
                lblPcLeft.Visible = true;
                lblPcMiddle.Visible = false;
                lblPcRight.Visible = false;

                lblResult.Text = ("Result: You Lost");
                losses = losses + 1;
            }

            else if (randomResult == 2)
            {
                lblPcLeft.Visible = false;
                lblPcMiddle.Visible = true;
                lblPcRight.Visible = false;

                lblResult.Text = ("Result: You Win");
                wins = wins + 1;
            }

            else if (randomResult == 3)
            {
                lblPcLeft.Visible = false;
                lblPcMiddle.Visible = false;
                lblPcRight.Visible = true;

                lblResult.Text = ("Result: You Tied");
                ties = ties + 1;
            }

            lblWins.Text = ("Wins: " + wins);
            lblLosses.Text = ("Losses: " + losses);
            lblTies.Text = ("Ties: " + ties);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



