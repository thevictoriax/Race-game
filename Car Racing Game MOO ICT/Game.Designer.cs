﻿namespace Car_Racing_Game_MOO_ICT
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.coin = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.txtCoins = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.coin);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 638);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(249, 726);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(-134, 657);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(633, 46);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 780);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 170);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press Left and Right to move the car. \r\n\r\nDon\'t hit any other cars in the game an" +
    "d survive as long as you can";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // coin
            // 
            this.coin.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.coin;
            this.coin.Location = new System.Drawing.Point(548, 371);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(50, 50);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 6;
            this.coin.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AI2.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(563, 76);
            this.AI2.Margin = new System.Windows.Forms.Padding(4);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 5;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AI1.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(167, 76);
            this.AI1.Margin = new System.Windows.Forms.Padding(4);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // award
            // 
            this.award.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(269, 257);
            this.award.Margin = new System.Windows.Forms.Padding(4);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(101, 462);
            this.explosion.Margin = new System.Windows.Forms.Padding(4);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(315, 539);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.background_1_0;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Margin = new System.Windows.Forms.Padding(4);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(780, 639);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 4;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.background_1_0;
            this.roadTrack1.Location = new System.Drawing.Point(0, -639);
            this.roadTrack1.Margin = new System.Windows.Forms.Padding(4);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(780, 639);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // txtCoins
            // 
            this.txtCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoins.Location = new System.Drawing.Point(305, 657);
            this.txtCoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCoins.Name = "txtCoins";
            this.txtCoins.Size = new System.Drawing.Size(509, 46);
            this.txtCoins.TabIndex = 4;
            this.txtCoins.Text = "Coins: 0";
            this.txtCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCoins.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 961);
            this.Controls.Add(this.txtCoins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Car Racing Game MOO ICT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label txtCoins;
    }
}

