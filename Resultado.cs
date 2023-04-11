using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificadoDeNerd
{
    public partial class Form1 : Form
    {
        Double acerto;
        public Form1()
        {
            InitializeComponent();
        }

        private void picbox_resultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            acerto = ArmazemDeVariaveis.acertos;
            if (acerto <= 4)
            {
                lbl_resultado.Text = "Você é descolado e nada nerd, acertou só: " + acerto;
                picbox_resultado.ImageLocation = "descolado.jpg";
            }
            else if (acerto >=5 && acerto <=8)
            {
                lbl_resultado.Text = "Você é um pouquinho nerd, acertou: " + acerto;
                picbox_resultado.ImageLocation = "nadanerd.jpg";
            }
            else if (acerto >=9 && acerto <= 12)
            {
                lbl_resultado.Text = "Você é bem nerd já mas ainda é perdoável, acertou: " + acerto;
                picbox_resultado.ImageLocation = "nerdzinho.jpg";
            }
            else
            {
                lbl_resultado.Text = "Você é simplesmente o maior NERDOLA do mundo, acertou: " + acerto;
                picbox_resultado.ImageLocation = "nerdsupremo.jpg";
            }
        }

        private void btt_gabarito_Click(object sender, EventArgs e)
        {
            Gabarito gabarito = new Gabarito();
            gabarito.Show();
            this.Hide();
        }
    }
}
