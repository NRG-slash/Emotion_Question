namespace WindowsFormsApplication2
{
    partial class From1
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
            this.BTNHappy = new System.Windows.Forms.Button();
            this.BTNAngry = new System.Windows.Forms.Button();
            this.BTNSad = new System.Windows.Forms.Button();
            this.BTNZzzz = new System.Windows.Forms.Button();
            this.LBLGreeting = new System.Windows.Forms.Label();
            this.LBLFeel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNHappy
            // 
            this.BTNHappy.Location = new System.Drawing.Point(287, 273);
            this.BTNHappy.Name = "BTNHappy";
            this.BTNHappy.Size = new System.Drawing.Size(75, 23);
            this.BTNHappy.TabIndex = 0;
            this.BTNHappy.Text = "I\'m Happy";
            this.BTNHappy.UseVisualStyleBackColor = true;
            this.BTNHappy.Click += new System.EventHandler(this.BTNHappy_Click);
            // 
            // BTNAngry
            // 
            this.BTNAngry.Location = new System.Drawing.Point(448, 273);
            this.BTNAngry.Name = "BTNAngry";
            this.BTNAngry.Size = new System.Drawing.Size(75, 23);
            this.BTNAngry.TabIndex = 1;
            this.BTNAngry.Text = "I\'m Angry";
            this.BTNAngry.UseVisualStyleBackColor = true;
            this.BTNAngry.Click += new System.EventHandler(this.BTNAngry_Click);
            // 
            // BTNSad
            // 
            this.BTNSad.Location = new System.Drawing.Point(287, 350);
            this.BTNSad.Name = "BTNSad";
            this.BTNSad.Size = new System.Drawing.Size(75, 23);
            this.BTNSad.TabIndex = 2;
            this.BTNSad.Text = "I\'m Sad";
            this.BTNSad.UseVisualStyleBackColor = true;
            this.BTNSad.Click += new System.EventHandler(this.BTNSad_Click);
            // 
            // BTNZzzz
            // 
            this.BTNZzzz.Location = new System.Drawing.Point(448, 350);
            this.BTNZzzz.Name = "BTNZzzz";
            this.BTNZzzz.Size = new System.Drawing.Size(75, 23);
            this.BTNZzzz.TabIndex = 3;
            this.BTNZzzz.Text = "I\'m tired";
            this.BTNZzzz.UseVisualStyleBackColor = true;
            this.BTNZzzz.Click += new System.EventHandler(this.BTNZzzz_Click);
            // 
            // LBLGreeting
            // 
            this.LBLGreeting.AutoSize = true;
            this.LBLGreeting.Location = new System.Drawing.Point(378, 188);
            this.LBLGreeting.Name = "LBLGreeting";
            this.LBLGreeting.Size = new System.Drawing.Size(0, 13);
            this.LBLGreeting.TabIndex = 4;
            // 
            // LBLFeel
            // 
            this.LBLFeel.AutoSize = true;
            this.LBLFeel.Location = new System.Drawing.Point(358, 46);
            this.LBLFeel.Name = "LBLFeel";
            this.LBLFeel.Size = new System.Drawing.Size(90, 13);
            this.LBLFeel.TabIndex = 5;
            this.LBLFeel.Text = "How do you feel?";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 528);
            this.Controls.Add(this.LBLFeel);
            this.Controls.Add(this.LBLGreeting);
            this.Controls.Add(this.BTNZzzz);
            this.Controls.Add(this.BTNSad);
            this.Controls.Add(this.BTNAngry);
            this.Controls.Add(this.BTNHappy);
            this.Name = "From1";
            this.Text = "Challenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNHappy;
        private System.Windows.Forms.Button BTNAngry;
        private System.Windows.Forms.Button BTNSad;
        private System.Windows.Forms.Button BTNZzzz;
        private System.Windows.Forms.Label LBLGreeting;
        private System.Windows.Forms.Label LBLFeel;
    }
}

