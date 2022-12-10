using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaristo_A1_Card
{
    public partial class CardNameDisplayer : Form
    {
        public CardNameDisplayer()
        {
            InitializeComponent();
        }



        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxCardName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxCard1_Click(object sender, EventArgs e)
        {
            TextBoxCardName.Text = "Six Of Clubs";
        }

        private void pictureBoxCard2_Click(object sender, EventArgs e)
        {
            TextBoxCardName.Text = "Ace Of Hearts";
        }

        private void pictureBoxCard3_Click(object sender, EventArgs e)
        {
            TextBoxCardName.Text = "King Of Clubs";
        }

        private void pictureBoxCard4_Click(object sender, EventArgs e)
        {
            TextBoxCardName.Text = "Nine Of Hearts";
        }

        private void pictureBoxCard5_Click(object sender, EventArgs e)
        {
            TextBoxCardName.Text = "Queen Of Diamonds";
        }
    }
}
