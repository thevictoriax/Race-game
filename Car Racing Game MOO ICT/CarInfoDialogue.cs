using System;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{


    public class CarInfoDialog : Form
    {
        private Label nameLabel;
        private Label priceLabel;
        private Label speedLabel;
        private Button buyButton;
        private Button cancelButton;

        public int Price { get; private set; }
        public int Coins { get; set; }

        public event EventHandler CarPurchased;

        public CarInfoDialog(string carName, int carPrice, int carSpeed)
        {
            // Initialize the Form
            this.Text = "Car Information";
            this.Width = 300;
            this.Height = 200;

            Price = carPrice;

            // Create labels for car information
            nameLabel = new Label();
            nameLabel.Text = carName;
            nameLabel.Location = new Point(20, 20);
            this.Controls.Add(nameLabel);

            priceLabel = new Label();
            priceLabel.Text = "Price: " + carPrice + " coins";
            priceLabel.Location = new Point(20, 50);
            this.Controls.Add(priceLabel);

            speedLabel = new Label();
            speedLabel.Text = "Speed: " + carSpeed + " km/h";
            speedLabel.Location = new Point(20, 80);
            this.Controls.Add(speedLabel);

            // Create buy button
            buyButton = new Button();
            buyButton.Text = "Buy";
            buyButton.Location = new Point(50, 120);
            buyButton.Click += BuyButton_Click;
            this.Controls.Add(buyButton);

            // Create cancel button
            cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Location = new Point(150, 120);
            cancelButton.Click += CancelButton_Click;
            this.Controls.Add(cancelButton);
        }

        // Event handler for buy button click
        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (Coins >= Price)
            {
                // Deduct the car price from the coins
                Coins -= Price;
                // Update the coin count in your application

                //MessageBox.Show("Car purchased! Remaining coins: " + Coins);
                CarPurchased?.Invoke(this, EventArgs.Empty);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //MessageBox.Show("Insufficient coins to buy the car!");
                this.DialogResult = DialogResult.None;
            }
        }


        // Event handler for cancel button click
        private void CancelButton_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CarInfoDialog
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "CarInfoDialog";
            this.Load += new System.EventHandler(this.CarInfoDialog_Load);
            this.ResumeLayout(false);

        }

        private void CarInfoDialog_Load(object sender, EventArgs e)
        {

        }
    }

    

}