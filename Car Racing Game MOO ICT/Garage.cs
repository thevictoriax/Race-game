using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Garage : Form
    {

        public Racer Racer { get; set; }
        public Garage(Racer racer)
        {
            Racer = racer;
            InitializeComponent();
        }
        private int selectedCarValue = 0;

        private void Garage_Load(object sender, EventArgs e)
        {
            txtCoins.Text = "Coins: " + Racer.Coins;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarInfoDialog carDialog = new CarInfoDialog("Ford F150", 5, 180);
            carDialog.Coins = Racer.Coins;

            carDialog.CarPurchased += (s, args) => BuyCar(Racer, carDialog.Price);
            DialogResult result = carDialog.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CarInfoDialog carDialog = new CarInfoDialog("Ford Mustang", 100, 210);
            carDialog.Coins = Racer.Coins;

            carDialog.CarPurchased += (s, args) => BuyCar(Racer, carDialog.Price);
            DialogResult result = carDialog.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CarInfoDialog carDialog = new CarInfoDialog("Lotus F1", 300, 321);
            carDialog.Coins = Racer.Coins;

            carDialog.CarPurchased += (s, args) => BuyCar(Racer, carDialog.Price);
            DialogResult result = carDialog.ShowDialog();
        }

        public void BuyCar(Racer racer, int carPrice)
        {

            if (carPrice == 5 && racer.CheckCarExists("Ford F150"))
            {
                MessageBox.Show("You already own this car!");
                selectedCarValue = 1;
                return;
            }
            else if (carPrice == 100 && racer.CheckCarExists("Ford Mustang"))
            {
                MessageBox.Show("You already own this car!");
                selectedCarValue = 2;

                return;
            }
            else if (carPrice == 300 && racer.CheckCarExists("Lotus F1"))
            {
                MessageBox.Show("You already own this car!");
                selectedCarValue = 3;

                return;
            }
            if (racer.Coins >= carPrice)
            {
                racer.Coins -= carPrice;

                MessageBox.Show("Car purchased! Remaining coins: " + racer.Coins);

                txtCoins.Text = "Coins: " + racer.Coins;

                if (carPrice == 5)
                {
                    selectedCarValue = 1; 
                    racer.PurchasedCars.Add("Ford F150");
                    button2.Enabled = true;
                }
                else if (carPrice == 100)
                {
                    selectedCarValue = 2; 
                    racer.PurchasedCars.Add("Ford Mustang");
                    button3.Enabled = true;

                }
                else if (carPrice == 300)
                {
                    selectedCarValue = 3; 
                    racer.PurchasedCars.Add("Lotus F1");
                    button4.Enabled = true;

                }

                racer.AddCarsToFile(); 
            }
            else
            {
                MessageBox.Show("Insufficient coins to buy the car!");
            }
        }



        private void CarDialog_CarPurchased(object sender, EventArgs e)
        {
            CarInfoDialog carDialog = (CarInfoDialog)sender;
            int carPrice = carDialog.Price;

            if (Racer.Coins >= carPrice)
            {
                Racer.Coins -= carPrice;

                MessageBox.Show("Car purchased! Remaining coins: " + Racer.Coins);
            }
            else
            {
                MessageBox.Show("Insufficient coins to buy the car!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Racer != null)
            {
                Game game = new Game(Racer);
                game.Show();
                game.changePlayerCar(this); 

                this.Close();
            }
            else
            {
                MessageBox.Show("Please login before playing the game.");
            }
        }

        public int GetSelectedCarValue()
        {
            return selectedCarValue;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (Racer.CheckCarExists("Ford F150"))
            {
                selectedCarValue = 1;
                Game game = new Game(Racer);
                game.Show();
                game.changePlayerCar(this); 

                this.Close();
            }
            else
            {
                MessageBox.Show("You need to buy car before choosing it.");
                button2.Enabled= false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Racer.CheckCarExists("Ford Mustang"))
            {
                selectedCarValue = 2;
                Game game = new Game(Racer);
                game.Show();
                game.changePlayerCar(this); 

                this.Close();
            }
            else
            {
                MessageBox.Show("You need to buy car before choosing it.");
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Racer.CheckCarExists("Lotus F1"))
            {
                selectedCarValue = 3;
                Game game = new Game(Racer);
                game.Show();
                game.changePlayerCar(this); 

                this.Close();
            }
            else
            {
                MessageBox.Show("You need to buy car before choosing it.");
                button4.Enabled = false;
            }
        }
    }
}
