﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            Login racer = new Login();
            racer.Show();
            this.Hide();
            

        }

        private void garagebutton_Click(object sender, EventArgs e)
        {
            Login racer = new Login();
            racer.Show();
            this.Hide();
            
        }
    }
}
