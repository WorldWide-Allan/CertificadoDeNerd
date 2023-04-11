namespace CertificadoDeNerd
{
    partial class Intro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_comecar = new System.Windows.Forms.Button();
            this.picbox_intro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_intro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teste de Nerd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Será que você tem o que é necessário para ser um nerd???\r\nVamos descobrir com ess" +
    "e pequeno Quizz de 16 perguntinhas";
            // 
            // btt_comecar
            // 
            this.btt_comecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_comecar.Location = new System.Drawing.Point(223, 363);
            this.btt_comecar.Name = "btt_comecar";
            this.btt_comecar.Size = new System.Drawing.Size(154, 56);
            this.btt_comecar.TabIndex = 2;
            this.btt_comecar.Text = "Começar";
            this.btt_comecar.UseVisualStyleBackColor = true;
            this.btt_comecar.Click += new System.EventHandler(this.btt_comecar_Click);
            // 
            // picbox_intro
            // 
            this.picbox_intro.Image = ((System.Drawing.Image)(resources.GetObject("picbox_intro.Image")));
            this.picbox_intro.Location = new System.Drawing.Point(165, 162);
            this.picbox_intro.Name = "picbox_intro";
            this.picbox_intro.Size = new System.Drawing.Size(263, 182);
            this.picbox_intro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_intro.TabIndex = 3;
            this.picbox_intro.TabStop = false;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.picbox_intro);
            this.Controls.Add(this.btt_comecar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Intro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_intro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btt_comecar;
        private System.Windows.Forms.PictureBox picbox_intro;
    }
}

