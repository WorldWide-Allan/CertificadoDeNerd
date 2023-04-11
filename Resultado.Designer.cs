namespace CertificadoDeNerd
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbox_resultado = new System.Windows.Forms.PictureBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btt_gabarito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_resultado
            // 
            this.picbox_resultado.Location = new System.Drawing.Point(149, 153);
            this.picbox_resultado.Name = "picbox_resultado";
            this.picbox_resultado.Size = new System.Drawing.Size(263, 182);
            this.picbox_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_resultado.TabIndex = 7;
            this.picbox_resultado.TabStop = false;
            this.picbox_resultado.Click += new System.EventHandler(this.picbox_resultado_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(61, 95);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 20);
            this.lbl_resultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ver Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt_gabarito
            // 
            this.btt_gabarito.Location = new System.Drawing.Point(278, 384);
            this.btt_gabarito.Name = "btt_gabarito";
            this.btt_gabarito.Size = new System.Drawing.Size(134, 39);
            this.btt_gabarito.TabIndex = 9;
            this.btt_gabarito.Text = "Ver Gabarito";
            this.btt_gabarito.UseVisualStyleBackColor = true;
            this.btt_gabarito.Click += new System.EventHandler(this.btt_gabarito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.btt_gabarito);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picbox_resultado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_resultado;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btt_gabarito;
    }
}