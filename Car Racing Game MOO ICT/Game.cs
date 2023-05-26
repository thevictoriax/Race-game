﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Game : Form
    {
        public Racer Racer { get; set; }
        //public string racerName;
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        //int score;
        int carImage;
        bool coinVisible = false;
        //int collectedCoins = 0;
        bool endOfTHeGame = false;
        List<Point> coinPositions = new List<Point>();




        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

       

        public Game(Racer racer)
        {
            Racer= racer;

            InitializeComponent();

            ResetGame();
        }

       

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + Racer.Points;
            Racer.Points++;
            txtCoins.Text = "Coins: " + Racer.Coins;
            //collectedCoins++;


            if (goleft == true && player.Left > 147)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;


            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            if (Racer.Points > 40 && Racer.Points < 500)
            {
                award.Image = Properties.Resources.bronze;
            }


            if (Racer.Points > 500 && Racer.Points < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (Racer.Points > 2000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }

            if (coinVisible && player.Bounds.IntersectsWith(coin.Bounds))
            {
                Racer.Coins++;
                coinVisible = false;
            }

            if (coinVisible)
            {
                coin.Top += roadSpeed;

                if (coin.Top > 530)
                {
                    coinVisible = false;
                }
            }
            for (int i = 0; i < coinPositions.Count; i++)
            {
                coinPositions[i] = new Point(coinPositions[i].X, coinPositions[i].Y + roadSpeed);

                if (coinPositions[i].Y > 530)
                {
                    coinPositions.RemoveAt(i);
                    i--;
                }
                else
                {
                    coin.Location = coinPositions[i];

                    if (player.Bounds.IntersectsWith(coin.Bounds))
                    {
                        Racer.Coins++;
                        coinPositions.RemoveAt(i);
                        break;
                    }
                }
            }

            // ...

            // Draw the coins on the road
            foreach (Point position in coinPositions)
            {
                coin.Location = position;
                coin.Visible = true;

                if (player.Bounds.IntersectsWith(coin.Bounds))
                {
                    Racer.Coins++;
                    coinPositions.Remove(position);
                    break;
                }
            }
            if(endOfTHeGame == true)
            {
                Racer.AddToFile();
            }
        }
        private void GenerateCoinPosition()
        {
            coinPositions.Clear();

            for (int i = 0; i < 10; i++) // Adjust the number of coins as needed
            {
                Point coinPosition;

                do
                {
                    coinPosition = new Point(rand.Next(167, 423), carPosition.Next(100, 400) * -1);
                } while (CoinCollidesWithCars(coinPosition));

                coinPositions.Add(coinPosition);
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {

            carImage = rand.Next(1, 9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }


            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(167, 213);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(406, 423);
            }

            if (rand.Next(0, 3) == 0) // Adjust the probability of a coin appearing
            {
                coinPositions.Add(new Point(tempCar.Left, tempCar.Top));
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;
            endOfTHeGame = true;




        }

        private void ResetGame()
        {

            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            Racer.Points = 0;
            award.Image = Properties.Resources.bronze;
            coinVisible = false;


            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(167, 213);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(406, 423);

            GenerateCoinPosition();

            coinPositions.Clear();

            for (int i = 0; i < 5; i++) // Adjust the number of coins as needed
            {
                coinPositions.Add(new Point(rand.Next(167, 423), carPosition.Next(100, 400) * -1));
            }

            gameTimer.Start();




        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //coin.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();

        }
        private bool CoinCollidesWithCars(Point coinPosition)
        {
            foreach (Point position in coinPositions)
            {
                if (Math.Abs(position.X - coinPosition.X) < coin.Width && Math.Abs(position.Y - coinPosition.Y) < coin.Height)
                {
                    return true; // Collision detected
                }
            }

            return false;
        }
        
    }
}
