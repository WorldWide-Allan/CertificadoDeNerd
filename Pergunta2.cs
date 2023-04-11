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
    public partial class Pergunta2 : Form
    {
        public Pergunta2()
        {
            InitializeComponent();
        }

        private void btt_anterior2_Click(object sender, EventArgs e)
        {
            Pergunta1 pergunta1 = new Pergunta1();
            pergunta1.Show();
            this.Hide();
        }

        private void btt_proxima2_Click(object sender, EventArgs e)
        {
            if (rbtt_5.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_6.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_7.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            if (rbtt_8.Checked)
            {
                ArmazemDeVariaveis.acertos = ArmazemDeVariaveis.acertos + 1;
            }
            else
            {

            }
            Pergunta3 pergunta3 = new Pergunta3();
            pergunta3.Show();
            this.Hide();
        }

        private void Pergunta2_Load(object sender, EventArgs e)
        {
            rbtt_5.Checked = true;
            rbtt_5.Checked = false;
            rbtt_6.Checked = true;
            rbtt_6.Checked = false;
            rbtt_7.Checked = true;
            rbtt_7.Checked = false;
            rbtt_8.Checked = true;
            rbtt_8.Checked = false;
        }
    }
}
