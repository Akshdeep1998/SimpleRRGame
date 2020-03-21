namespace RussianRoulette
{
    partial class PlayGameForm
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
            this.Spin = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.LoadImg = new System.Windows.Forms.PictureBox();
            this.ShootAway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.Red;
            this.Spin.Enabled = false;
            this.Spin.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.ForeColor = System.Drawing.Color.White;
            this.Spin.Location = new System.Drawing.Point(821, 187);
            this.Spin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(204, 73);
            this.Spin.TabIndex = 2;
            this.Spin.Text = "SPIN";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Fire
            // 
            this.Fire.BackColor = System.Drawing.Color.Red;
            this.Fire.Enabled = false;
            this.Fire.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.ForeColor = System.Drawing.Color.White;
            this.Fire.Location = new System.Drawing.Point(821, 288);
            this.Fire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(204, 68);
            this.Fire.TabIndex = 3;
            this.Fire.Text = "FIRE!!";
            this.Fire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fire.UseVisualStyleBackColor = false;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.Red;
            this.PlayAgain.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.Ivory;
            this.PlayAgain.Location = new System.Drawing.Point(131, 487);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(257, 52);
            this.PlayAgain.TabIndex = 4;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Red;
            this.LoadBtn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.Location = new System.Drawing.Point(821, 85);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(204, 71);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // LoadImg
            // 
            this.LoadImg.BackgroundImage = global::RussianRoulette.Resource1.Background;
            this.LoadImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadImg.Location = new System.Drawing.Point(102, 102);
            this.LoadImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadImg.Name = "LoadImg";
            this.LoadImg.Size = new System.Drawing.Size(610, 333);
            this.LoadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadImg.TabIndex = 6;
            this.LoadImg.TabStop = false;
            // 
            // ShootAway
            // 
            this.ShootAway.BackColor = System.Drawing.Color.Red;
            this.ShootAway.Enabled = false;
            this.ShootAway.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.ForeColor = System.Drawing.Color.White;
            this.ShootAway.Location = new System.Drawing.Point(821, 388);
            this.ShootAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(204, 73);
            this.ShootAway.TabIndex = 8;
            this.ShootAway.Text = "ShootAway";
            this.ShootAway.UseVisualStyleBackColor = false;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // PlayGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.LoadImg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayGameForm";
            this.Text = "PlayGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.PictureBox LoadImg;
        private System.Windows.Forms.Button ShootAway;
    }
}