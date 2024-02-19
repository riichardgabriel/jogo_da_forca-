namespace jogodaforca
{
    partial class FormJogo
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
            this.lbPalavraSecreta = new System.Windows.Forms.Label();
            this.btnVerificarLetra = new System.Windows.Forms.Button();
            this.txbTentativa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPalavraSecreta
            // 
            this.lbPalavraSecreta.AutoSize = true;
            this.lbPalavraSecreta.Location = new System.Drawing.Point(58, 134);
            this.lbPalavraSecreta.Name = "lbPalavraSecreta";
            this.lbPalavraSecreta.Size = new System.Drawing.Size(81, 13);
            this.lbPalavraSecreta.TabIndex = 0;
            this.lbPalavraSecreta.Text = "Palavra secreta";
            // 
            // btnVerificarLetra
            // 
            this.btnVerificarLetra.Location = new System.Drawing.Point(314, 234);
            this.btnVerificarLetra.Name = "btnVerificarLetra";
            this.btnVerificarLetra.Size = new System.Drawing.Size(130, 23);
            this.btnVerificarLetra.TabIndex = 1;
            this.btnVerificarLetra.Text = "Verificar Letra";
            this.btnVerificarLetra.UseVisualStyleBackColor = true;
            this.btnVerificarLetra.Click += new System.EventHandler(this.btnVerificarLetra_Click);
            // 
            // txbTentativa
            // 
            this.txbTentativa.Location = new System.Drawing.Point(61, 234);
            this.txbTentativa.Name = "txbTentativa";
            this.txbTentativa.Size = new System.Drawing.Size(216, 20);
            this.txbTentativa.TabIndex = 2;
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbTentativa);
            this.Controls.Add(this.btnVerificarLetra);
            this.Controls.Add(this.lbPalavraSecreta);
            this.Name = "FormJogo";
            this.Text = "FormJogo";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPalavraSecreta;
        private System.Windows.Forms.Button btnVerificarLetra;
        private System.Windows.Forms.TextBox txbTentativa;
    }
}