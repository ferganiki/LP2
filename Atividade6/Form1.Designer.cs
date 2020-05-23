namespace Atividade6
{
    partial class frmMenu
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
            this.btnExercício1 = new System.Windows.Forms.Button();
            this.btnExercício2 = new System.Windows.Forms.Button();
            this.btnExercício3 = new System.Windows.Forms.Button();
            this.btnExercício4 = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExercício1
            // 
            this.btnExercício1.Location = new System.Drawing.Point(12, 240);
            this.btnExercício1.Name = "btnExercício1";
            this.btnExercício1.Size = new System.Drawing.Size(182, 86);
            this.btnExercício1.TabIndex = 1;
            this.btnExercício1.Text = "Exercício 1";
            this.btnExercício1.UseVisualStyleBackColor = true;
            this.btnExercício1.Click += new System.EventHandler(this.btnExercício1_Click);
            // 
            // btnExercício2
            // 
            this.btnExercício2.Location = new System.Drawing.Point(211, 240);
            this.btnExercício2.Name = "btnExercício2";
            this.btnExercício2.Size = new System.Drawing.Size(182, 86);
            this.btnExercício2.TabIndex = 3;
            this.btnExercício2.Text = "Exercício 2";
            this.btnExercício2.UseVisualStyleBackColor = true;
            this.btnExercício2.Click += new System.EventHandler(this.btnExercício2_Click);
            // 
            // btnExercício3
            // 
            this.btnExercício3.Location = new System.Drawing.Point(409, 240);
            this.btnExercício3.Name = "btnExercício3";
            this.btnExercício3.Size = new System.Drawing.Size(182, 86);
            this.btnExercício3.TabIndex = 4;
            this.btnExercício3.Text = "Exercício 3";
            this.btnExercício3.UseVisualStyleBackColor = true;
            this.btnExercício3.Click += new System.EventHandler(this.btnExercício3_Click);
            // 
            // btnExercício4
            // 
            this.btnExercício4.Location = new System.Drawing.Point(606, 240);
            this.btnExercício4.Name = "btnExercício4";
            this.btnExercício4.Size = new System.Drawing.Size(182, 86);
            this.btnExercício4.TabIndex = 5;
            this.btnExercício4.Text = "Exercício 4";
            this.btnExercício4.UseVisualStyleBackColor = true;
            this.btnExercício4.Click += new System.EventHandler(this.btnExercício4_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.45F);
            this.lblMenu.Location = new System.Drawing.Point(305, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(183, 70);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Menu";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnExercício4);
            this.Controls.Add(this.btnExercício3);
            this.Controls.Add(this.btnExercício2);
            this.Controls.Add(this.btnExercício1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "frmMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExercício1;
        private System.Windows.Forms.Button btnExercício2;
        private System.Windows.Forms.Button btnExercício3;
        private System.Windows.Forms.Button btnExercício4;
        private System.Windows.Forms.Label lblMenu;
    }
}

