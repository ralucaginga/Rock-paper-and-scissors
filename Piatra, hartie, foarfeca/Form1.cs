using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piatra__hartie__foarfeca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int scorJucator, scorRobot = 0;

        private void Piatra_Click(object sender, EventArgs e)
        {
            PlayRound(1);
        }

        private void Hartie_Click(object sender, EventArgs e)
        {
            PlayRound(2);
        }

        private void Foarfeca_Click(object sender, EventArgs e)
        {
            PlayRound(3);
        }

        private void rrJoc_Click_1(object sender, EventArgs e)
        {
            scorJucator = 0;
            scorRobot = 0;
            playerPicture.Image = null;
            robotPicture.Image = null;
            evidenta.Text = "Joc Resetat";
            scorJucat.Text = "0";
            scorRr.Text = "0";
        }

        private void PlayRound(int playerSelection)
        {
            Random rnd = new Random();
            int robotSelection = rnd.Next(1, 4);
            SetImage(playerPicture, playerSelection);
            SetImage(robotPicture, robotSelection);

            if(robotSelection == playerSelection)
            {
                evidenta.Text = "Remiza!";
                return;
            }
            switch (playerSelection)
            {
                case 1:
                    if (robotSelection == 2)
                        UpdateScore(false);
                    else UpdateScore(true);
                    break;
                case 2:
                    if (robotSelection == 3)
                        UpdateScore(false);
                    else UpdateScore(true);
                    break;
                case 3:
                    if (robotSelection == 1)
                        UpdateScore(false);
                    else UpdateScore(true);
                    break;
            }
        }

        private void UpdateScore(bool playerWon)
        {
            if(playerWon)
            {
                scorJucator++;
                evidenta.Text = "Felicitari! Ai castigat!";
                scorJucat.Text = scorJucator.ToString();
            }
            else
            {
                scorRobot++;
                evidenta.Text = "Robotul a castigat!";
                scorRr.Text = scorRobot.ToString();
            }
        }

        private void SetImage(PictureBox pb, int img)
        {
            if (img == 1)
                pb.Image = Image.FromFile("rock.png");
            else if (img == 2)
                pb.Image = Image.FromFile("paper.png");
            else if (img == 3)
                pb.Image = Image.FromFile("scissors.png");
        }
    }
}
