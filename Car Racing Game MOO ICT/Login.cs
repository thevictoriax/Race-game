using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Login : Form
    {
           

        public Login()
        {  
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        { 
            string name = textBoxRacer.Text;
            
            Racer player = new Racer(name);
            if (player.AlreadyExists(name) == true)
            {
                player.renewCoins(name);
            }
            Game game = new Game(player);
            game.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxRacer.Text;

            Racer player = new Racer(name);
            if (player.AlreadyExists(name) == true)
            {
                player.renewCoins(name);
            }
            Garage garage = new Garage(player);
            garage.Show();
            this.Close();
        }
    }
}
