using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificadoDeNerd
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void btt_anterior1_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void btt_proxima1_Click(object sender, EventArgs e)
        {
            if (rbtt_1.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_2.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_3.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_4.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            Pergunta2 pergunta2 = new Pergunta2();
            pergunta2.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {
            rbtt_1.Checked = true;
            rbtt_1.Checked = false;
            rbtt_2.Checked = true;
            rbtt_2.Checked = false;
            rbtt_3.Checked = true;
            rbtt_3.Checked = false;
            rbtt_4.Checked = true;
            rbtt_4.Checked = false;
        }
    }
}
