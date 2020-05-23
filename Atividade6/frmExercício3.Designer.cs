namespace Atividade6
{
    partial class frmExercício3
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
            this.lblPalavra = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnCalcularPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(12, 9);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(43, 13);
            this.lblPalavra.TabIndex = 0;
            this.lblPalavra.Text = "Palavra";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(61, 9);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra.TabIndex = 1;
            // 
            // btnCalcularPalindromo
            // 
            this.btnCalcularPalindromo.Location = new System.Drawing.Point(61, 49);
            this.btnCalcularPalindromo.Name = "btnCalcularPalindromo";
            this.btnCalcularPalindromo.Size = new System.Drawing.Size(100, 23);
            this.btnCalcularPalindromo.TabIndex = 2;
            this.btnCalcularPalindromo.Text = "Calcular Palindromo";
            this.btnCalcularPalindromo.UseVisualStyleBackColor = true;
            this.btnCalcularPalindromo.Click += new System.EventHandler(this.btnCalcularPalindromo_Click);
            // 
            // frmExercício3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 109);
            this.Controls.Add(this.btnCalcularPalindromo);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblPalavra);
            this.Name = "frmExercício3";
            this.Text = "frmExercício3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnCalcularPalindromo;
    }
}