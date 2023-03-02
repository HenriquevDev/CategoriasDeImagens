using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriasDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureIphone1.Visible = true;
            this.pictureIphone2.Visible = true;
            this.pictureIphone3.Visible = true;
            this.pictureIphone4.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureXiaomi1.Visible = true;
            this.pictureXiaomi2.Visible = true;
            this.pictureXiaomi3.Visible = true;
            this.pictureXiaomi4.Visible = true;
        }

        private void radioButtonI1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureIphone1.Visible = true;
        }

        private void radioButtonI2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureIphone2.Visible = true;
        }

        private void radioButtonI3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureIphone3.Visible=true;
        }

        private void radioButtonI4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureIphone4.Visible=true;
        }

        private void radioButtonX1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureXiaomi1.Visible = true;
        }

        private void radioButtonX2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureXiaomi2.Visible = true;
        }

        private void radioButtonX3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureXiaomi3.Visible = true;
        }

        private void radioButtonX4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureXiaomi4.Visible = true;
        }

        private void buttonSelec_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonApague_Click(object sender, EventArgs e)
        {

        }
    }
}
