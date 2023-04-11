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
    public partial class Pergunta3 : Form
    {
        public Pergunta3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtt_9.Checked = true;
            rbtt_9.Checked = false;
            rbtt_10.Checked = true;
            rbtt_10.Checked = false;
            rbtt_11.Checked = true;
            rbtt_11.Checked = false;
            rbtt_12.Checked = true;
            rbtt_12.Checked = false;
        }

        private void btt_anterior3_Click(object sender, EventArgs e)
        {
            Pergunta2 pergunta2 = new Pergunta2();
            pergunta2.Show();
            this.Hide();
        }

        private void btt_proxima3_Click(object sender, EventArgs e)
        {
            if (rbtt_9.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_10.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_11.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_12.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            Pergunta4 pergunta4 = new Pergunta4();
            pergunta4.Show();
            this.Hide();
        }
    }
}
