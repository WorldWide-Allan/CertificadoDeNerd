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
    public partial class Pergunta4 : Form
    {
        public Pergunta4()
        {
            InitializeComponent();
        }

        private void btt_anterior4_Click(object sender, EventArgs e)
        {
            Pergunta3 pergunta3 = new Pergunta3();
            pergunta3.Show();
            this.Hide();
        }

        private void btt_proxima4_Click(object sender, EventArgs e)
        {
            if (rbtt_13.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_14.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_15.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_16.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            Form1 resultado = new Form1();
            resultado.Show();
            this.Hide();
        }

        private void Pergunta4_Load(object sender, EventArgs e)
        {
            rbtt_13.Checked = true;
            rbtt_13.Checked = false;
            rbtt_14.Checked = true;
            rbtt_14.Checked = false;
            rbtt_15.Checked = true;
            rbtt_15.Checked = false;
            rbtt_16.Checked = true;
            rbtt_16.Checked = false;
        }
    }
}
