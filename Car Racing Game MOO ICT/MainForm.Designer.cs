namespace Car_Racing_Game_MOO_ICT
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.playbutton = new System.Windows.Forms.Button();
            this.garagebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(171, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Racing game";
            
            // 
            // playbutton
            // 
            this.playbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.Location = new System.Drawing.Point(265, 208);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(242, 58);
            this.playbutton.TabIndex = 2;
            this.playbutton.Text = "Play";
            this.playbutton.UseVisualStyleBackColor = true;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // garagebutton
            // 
            this.garagebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garagebutton.Location = new System.Drawing.Point(265, 304);
            this.garagebutton.Name = "garagebutton";
            this.garagebutton.Size = new System.Drawing.Size(242, 58);
            this.garagebutton.TabIndex = 3;
            this.garagebutton.Text = "Garage";
            this.garagebutton.UseVisualStyleBackColor = true;
            this.garagebutton.Click += new System.EventHandler(this.garagebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Racing_Game_MOO_ICT.Properties.Resources.BSicon_RACE_svg;
            this.pictureBox1.Location = new System.Drawing.Point(577, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 476);
            this.Controls.Add(this.garagebutton);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button garagebutton;
    }
}