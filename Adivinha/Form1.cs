using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinha
{
    public partial class Form1 : Form
    {
        int quadro = 1;
        int adv = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Quadro " + quadro;

            switch (quadro)
            {
                case 1:
                    pictureBox1.ImageLocation = "figura1.jpg";
                    if (MessageBox.Show("Seu número está neste quadro?", "Quadro 1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adv += 1;
                    }
                    break;

                case 2:
                    pictureBox1.ImageLocation = "figura2.jpg";
                    if (MessageBox.Show("Seu número está neste quadro?", "Quadro 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adv += 2;
                    }
                    break;

                case 3:
                    pictureBox1.ImageLocation = "figura3.jpg";
                    if (MessageBox.Show("Seu número está neste quadro?", "Quadro 3", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adv += 4;
                    }
                    break;

                case 4:
                    pictureBox1.ImageLocation = "figura4.jpg";
                    if (MessageBox.Show("Seu número está neste quadro?", "Quadro 4", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adv += 8;
                    }
                    break;

                case 5:
                    pictureBox1.ImageLocation = "figura5.jpg";
                    if (MessageBox.Show("Seu número está neste quadro?", "Quadro 5", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adv += 16;
                    }
                    break;

                case 6:
                    pictureBox1.ImageLocation = "figura6.jpg";
                    if (MessageBox.Show("Seu número está neste quadro?", "Quadro 6", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        adv += 32;
                    }
                    break;

                case 7:
                    MessageBox.Show("O número que você pensou é o " + adv + "!", "ADIVINHEI");
                    break;
            }
            quadro += 1;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
