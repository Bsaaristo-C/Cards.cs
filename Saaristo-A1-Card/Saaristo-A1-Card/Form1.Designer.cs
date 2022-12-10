namespace Saaristo_A1_Card
{
    partial class CardNameDisplayer
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.TextBoxCardName = new System.Windows.Forms.TextBox();
            this.pictureBoxCard2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(196, 323);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(190, 57);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // TextBoxCardName
            // 
            this.TextBoxCardName.Location = new System.Drawing.Point(161, 266);
            this.TextBoxCardName.Name = "TextBoxCardName";
            this.TextBoxCardName.Size = new System.Drawing.Size(269, 20);
            this.TextBoxCardName.TabIndex = 15;
            this.TextBoxCardName.Text = "Select A Card!";
            this.TextBoxCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxCardName.TextChanged += new System.EventHandler(this.TextBoxCardName_TextChanged);
            // 
            // pictureBoxCard2
            // 
            this.pictureBoxCard2.Image = global::Saaristo_A1_Card.Properties.Resources.Ace_Hearts;
            this.pictureBoxCard2.Location = new System.Drawing.Point(125, 12);
            this.pictureBoxCard2.Name = "pictureBoxCard2";
            this.pictureBoxCard2.Size = new System.Drawing.Size(108, 226);
            this.pictureBoxCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard2.TabIndex = 14;
            this.pictureBoxCard2.TabStop = false;
            this.pictureBoxCard2.Click += new System.EventHandler(this.pictureBoxCard2_Click);
            // 
            // pictureBoxCard3
            // 
            this.pictureBoxCard3.Image = global::Saaristo_A1_Card.Properties.Resources.King_Clubs;
            this.pictureBoxCard3.Location = new System.Drawing.Point(239, 12);
            this.pictureBoxCard3.Name = "pictureBoxCard3";
            this.pictureBoxCard3.Size = new System.Drawing.Size(108, 226);
            this.pictureBoxCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard3.TabIndex = 13;
            this.pictureBoxCard3.TabStop = false;
            this.pictureBoxCard3.Click += new System.EventHandler(this.pictureBoxCard3_Click);
            // 
            // pictureBoxCard4
            // 
            this.pictureBoxCard4.Image = global::Saaristo_A1_Card.Properties.Resources._9_Hearts;
            this.pictureBoxCard4.Location = new System.Drawing.Point(353, 12);
            this.pictureBoxCard4.Name = "pictureBoxCard4";
            this.pictureBoxCard4.Size = new System.Drawing.Size(108, 226);
            this.pictureBoxCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard4.TabIndex = 12;
            this.pictureBoxCard4.TabStop = false;
            this.pictureBoxCard4.Click += new System.EventHandler(this.pictureBoxCard4_Click);
            // 
            // pictureBoxCard5
            // 
            this.pictureBoxCard5.Image = global::Saaristo_A1_Card.Properties.Resources.Queen_Diamonds;
            this.pictureBoxCard5.Location = new System.Drawing.Point(467, 12);
            this.pictureBoxCard5.Name = "pictureBoxCard5";
            this.pictureBoxCard5.Size = new System.Drawing.Size(108, 226);
            this.pictureBoxCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard5.TabIndex = 11;
            this.pictureBoxCard5.TabStop = false;
            this.pictureBoxCard5.Click += new System.EventHandler(this.pictureBoxCard5_Click);
            // 
            // pictureBoxCard1
            // 
            this.pictureBoxCard1.Image = global::Saaristo_A1_Card.Properties.Resources._6_Clubs;
            this.pictureBoxCard1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCard1.Name = "pictureBoxCard1";
            this.pictureBoxCard1.Size = new System.Drawing.Size(108, 226);
            this.pictureBoxCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard1.TabIndex = 10;
            this.pictureBoxCard1.TabStop = false;
            this.pictureBoxCard1.Click += new System.EventHandler(this.pictureBoxCard1_Click);
            // 
            // CardNameDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 405);
            this.Controls.Add(this.TextBoxCardName);
            this.Controls.Add(this.pictureBoxCard2);
            this.Controls.Add(this.pictureBoxCard3);
            this.Controls.Add(this.pictureBoxCard4);
            this.Controls.Add(this.pictureBoxCard5);
            this.Controls.Add(this.pictureBoxCard1);
            this.Controls.Add(this.ExitButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardNameDisplayer";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBoxCard1;
        private System.Windows.Forms.PictureBox pictureBoxCard5;
        private System.Windows.Forms.PictureBox pictureBoxCard4;
        private System.Windows.Forms.PictureBox pictureBoxCard3;
        private System.Windows.Forms.PictureBox pictureBoxCard2;
        private System.Windows.Forms.TextBox TextBoxCardName;
    }
}

