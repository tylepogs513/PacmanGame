namespace PacmanGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.pacman = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.AccessibleName = "playButton";
            this.playButton.BackColor = System.Drawing.Color.Blue;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(254, 231);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(271, 73);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pacman
            // 
            this.pacman.AutoSize = true;
            this.pacman.Cursor = System.Windows.Forms.Cursors.Default;
            this.pacman.Font = new System.Drawing.Font("Franklin Gothic Medium", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacman.ForeColor = System.Drawing.Color.Yellow;
            this.pacman.Location = new System.Drawing.Point(174, 108);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(449, 120);
            this.pacman.TabIndex = 1;
            this.pacman.Text = "PAC-MAN";
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.BackColor = System.Drawing.Color.Transparent;
            this.coins.Font = new System.Drawing.Font("OCRA", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coins.ForeColor = System.Drawing.Color.White;
            this.coins.Location = new System.Drawing.Point(249, 202);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(282, 26);
            this.coins.TabIndex = 2;
            this.coins.Text = "• insert coins •";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.playButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pac-Man";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label pacman;
        private System.Windows.Forms.Label coins;
    }
}

