using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificadoDeNerd
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        private void btt_comecar_Click(object sender, EventArgs e)
        {
            Pergunta1 pergunta1 = new Pergunta1();
            pergunta1.Show();
            this.Hide();
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }
    }
}
