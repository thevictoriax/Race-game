using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Garage_Load(object sender, EventArgs e)
        {
            txtCoins.Text = "Coins: " + Racer.Coins;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarInfoDialog carDialog = new CarInfoDialog("Ford F150", 0, 180);
            DialogResult result = carDialog.ShowDialog();

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

        private void BuyCar(Racer racer, int carPrice)
        {
            if (racer.Coins >= carPrice)
            {
                // Perform buy car logic here
                // Deduct the car price from the racer's coins
                racer.Coins -= carPrice;
                // Update the racer's coin count in your application

                MessageBox.Show("Car purchased! Remaining coins: " + racer.Coins);
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


    }
}
