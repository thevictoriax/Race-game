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

            if (result != DialogResult.OK)
            {
                // User clicked the "Cancel" button or closed the dialog
                // Perform further actions if needed
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CarInfoDialog carDialog = new CarInfoDialog("Ford Mustang", 100, 210);
            carDialog.Coins = Racer.Coins;

            carDialog.CarPurchased += (s, args) => BuyCar(Racer, carDialog.Price);
            DialogResult result = carDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                // User clicked the "Cancel" button or closed the dialog
                // Perform further actions if needed
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CarInfoDialog carDialog = new CarInfoDialog("Lotus F1", 300, 321);
            carDialog.Coins = Racer.Coins;

            carDialog.CarPurchased += (s, args) => BuyCar(Racer, carDialog.Price);
            DialogResult result = carDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                // User clicked the "Cancel" button or closed the dialog
                // Perform further actions if needed
            }
        }

        public void BuyCar(Racer racer, int carPrice)
        {

            
            if (carPrice == 5 && racer.CheckCarExists("Ford F150")== true)
            {
                MessageBox.Show("You already own this car!");
                return;
            }
            else if (carPrice == 100 && racer.CheckCarExists("Ford Mustang"))
            {
                MessageBox.Show("You already own this car!");
                return;
            }
            else if (carPrice == 300 && racer.CheckCarExists("Lotus F1"))
            {
                MessageBox.Show("You already own this car!");
                return;
            }
            if (racer.Coins >= carPrice)
            {
                // Perform buy car logic here
                // Deduct the car price from the racer's coins
                racer.Coins -= carPrice;
                // Update the racer's coin count in your application

                MessageBox.Show("Car purchased! Remaining coins: " + racer.Coins);

                // Set the value of selectedCarValue based on the purchased car
                if (carPrice == 5)
                {
                    selectedCarValue = 1; // Ford F150
                    racer.PurchasedCars.Add("Ford F150");
                }
                else if (carPrice == 100)
                {
                    selectedCarValue = 2; // Ford Mustang
                    racer.PurchasedCars.Add("Ford Mustang");
                }
                else if (carPrice == 300)
                {
                    selectedCarValue = 3; // Lotus F1
                    racer.PurchasedCars.Add("Lotus F1");
                }

                racer.AddCarsToFile(); // Write the purchased cars to the file
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
                // Deduct the car price from the racer's coins
                Racer.Coins -= carPrice;
                // Update the racer's coin count in your application

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
                game.changePlayerCar(this); // Pass the current Garage object

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



    }
}
