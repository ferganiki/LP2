namespace Atividade7
{
    partial class Form1
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
            this.btnLer = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMercadoria = new System.Windows.Forms.Button();
            this.btnVariável = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnMédia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(12, 12);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(126, 52);
            this.btnLer.TabIndex = 0;
            this.btnLer.Text = "Ler 20 números (ex1)";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(144, 12);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(126, 52);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "Use Reverse (exe2)";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnMercadoria
            // 
            this.btnMercadoria.Location = new System.Drawing.Point(276, 12);
            this.btnMercadoria.Name = "btnMercadoria";
            this.btnMercadoria.Size = new System.Drawing.Size(126, 52);
            this.btnMercadoria.TabIndex = 2;
            this.btnMercadoria.Text = "Mercadorias";
            this.btnMercadoria.UseVisualStyleBackColor = true;
            this.btnMercadoria.Click += new System.EventHandler(this.btnMercadoria_Click);
            // 
            // btnVariável
            // 
            this.btnVariável.Location = new System.Drawing.Point(12, 79);
            this.btnVariável.Name = "btnVariável";
            this.btnVariável.Size = new System.Drawing.Size(126, 52);
            this.btnVariável.TabIndex = 3;
            this.btnVariável.Text = "Variável Total";
            this.btnVariável.UseVisualStyleBackColor = true;
            this.btnVariável.Click += new System.EventHandler(this.btnVariável_Click);
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(144, 79);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(126, 52);
            this.btnArray.TabIndex = 4;
            this.btnArray.Text = "Use ArrayList";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnMédia
            // 
            this.btnMédia.Location = new System.Drawing.Point(276, 79);
            this.btnMédia.Name = "btnMédia";
            this.btnMédia.Size = new System.Drawing.Size(126, 52);
            this.btnMédia.TabIndex = 5;
            this.btnMédia.Text = "Média";
            this.btnMédia.UseVisualStyleBackColor = true;
            this.btnMédia.Click += new System.EventHandler(this.btnMédia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMédia);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnVariável);
            this.Controls.Add(this.btnMercadoria);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnLer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnMercadoria;
        private System.Windows.Forms.Button btnVariável;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnMédia;
    }
}

