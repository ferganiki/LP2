namespace Atividade2
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.rdbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rdbtnFeminino = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpbxSexo = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.grpbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 24);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(48, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura(m)";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 58);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(50, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso(Kg)";
            // 
            // rdbtnMasculino
            // 
            this.rdbtnMasculino.AutoSize = true;
            this.rdbtnMasculino.Checked = true;
            this.rdbtnMasculino.Location = new System.Drawing.Point(6, 19);
            this.rdbtnMasculino.Name = "rdbtnMasculino";
            this.rdbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbtnMasculino.TabIndex = 3;
            this.rdbtnMasculino.TabStop = true;
            this.rdbtnMasculino.Text = "Masculino";
            this.rdbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbtnFeminino
            // 
            this.rdbtnFeminino.AutoSize = true;
            this.rdbtnFeminino.Location = new System.Drawing.Point(6, 39);
            this.rdbtnFeminino.Name = "rdbtnFeminino";
            this.rdbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbtnFeminino.TabIndex = 4;
            this.rdbtnFeminino.Text = "Feminino";
            this.rdbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 31);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpbxSexo
            // 
            this.grpbxSexo.Controls.Add(this.rdbtnFeminino);
            this.grpbxSexo.Controls.Add(this.rdbtnMasculino);
            this.grpbxSexo.Location = new System.Drawing.Point(132, 19);
            this.grpbxSexo.Name = "grpbxSexo";
            this.grpbxSexo.Size = new System.Drawing.Size(98, 62);
            this.grpbxSexo.TabIndex = 7;
            this.grpbxSexo.TabStop = false;
            this.grpbxSexo.Text = "Sexo";
            this.grpbxSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(132, 96);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 31);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Location = new System.Drawing.Point(60, 24);
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.Size = new System.Drawing.Size(66, 20);
            this.mtxtAltura.TabIndex = 13;
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Location = new System.Drawing.Point(60, 58);
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.Size = new System.Drawing.Size(66, 20);
            this.mtxtPeso.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 314);
            this.Controls.Add(this.mtxtPeso);
            this.Controls.Add(this.mtxtAltura);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpbxSexo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxSexo.ResumeLayout(false);
            this.grpbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.RadioButton rdbtnMasculino;
        private System.Windows.Forms.RadioButton rdbtnFeminino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpbxSexo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mtxtAltura;
        private System.Windows.Forms.MaskedTextBox mtxtPeso;
    }
}

