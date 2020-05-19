namespace Atividade5REAL
{
    partial class frmExercício4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumericos = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(12, 12);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(411, 111);
            this.rchtxtTexto.TabIndex = 7;
            this.rchtxtTexto.Text = "";
            // 
            // btnNumericos
            // 
            this.btnNumericos.Location = new System.Drawing.Point(12, 142);
            this.btnNumericos.Name = "btnNumericos";
            this.btnNumericos.Size = new System.Drawing.Size(99, 53);
            this.btnNumericos.TabIndex = 8;
            this.btnNumericos.Text = "Mostra Numericos";
            this.btnNumericos.UseVisualStyleBackColor = true;
            this.btnNumericos.Click += new System.EventHandler(this.btnNumericos_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(136, 142);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(104, 53);
            this.btnPrimeiro.TabIndex = 9;
            this.btnPrimeiro.Text = "Mostra caracter branco";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Location = new System.Drawing.Point(267, 142);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(105, 53);
            this.btnAlfabeticos.TabIndex = 11;
            this.btnAlfabeticos.Text = "Mostra Alfabeticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnNumericos);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnNumericos;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAlfabeticos;
    }
}