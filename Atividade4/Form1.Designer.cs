namespace Atividade4
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
            this.grpbxSexo = new System.Windows.Forms.GroupBox();
            this.rdbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rdbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rdbtnCasado = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.grpbxCasado = new System.Windows.Forms.GroupBox();
            this.mtxtNome = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBruto = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFilhos = new System.Windows.Forms.MaskedTextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.mtxtINSS = new System.Windows.Forms.MaskedTextBox();
            this.mtxtIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mtxtLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDescontoINSS = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDescontoIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.grpbxSexo.SuspendLayout();
            this.grpbxCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxSexo
            // 
            this.grpbxSexo.Controls.Add(this.rdbtnFeminino);
            this.grpbxSexo.Controls.Add(this.rdbtnMasculino);
            this.grpbxSexo.Location = new System.Drawing.Point(241, 3);
            this.grpbxSexo.Name = "grpbxSexo";
            this.grpbxSexo.Size = new System.Drawing.Size(137, 80);
            this.grpbxSexo.TabIndex = 0;
            this.grpbxSexo.TabStop = false;
            this.grpbxSexo.Text = "Sexo";
            // 
            // rdbtnFeminino
            // 
            this.rdbtnFeminino.AutoSize = true;
            this.rdbtnFeminino.Location = new System.Drawing.Point(7, 44);
            this.rdbtnFeminino.Name = "rdbtnFeminino";
            this.rdbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbtnFeminino.TabIndex = 1;
            this.rdbtnFeminino.Text = "Feminino";
            this.rdbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbtnMasculino
            // 
            this.rdbtnMasculino.AutoSize = true;
            this.rdbtnMasculino.Checked = true;
            this.rdbtnMasculino.Location = new System.Drawing.Point(7, 20);
            this.rdbtnMasculino.Name = "rdbtnMasculino";
            this.rdbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbtnMasculino.TabIndex = 0;
            this.rdbtnMasculino.TabStop = true;
            this.rdbtnMasculino.Text = "Masculino";
            this.rdbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbtnCasado
            // 
            this.rdbtnCasado.AutoSize = true;
            this.rdbtnCasado.Checked = true;
            this.rdbtnCasado.Location = new System.Drawing.Point(7, 19);
            this.rdbtnCasado.Name = "rdbtnCasado";
            this.rdbtnCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbtnCasado.TabIndex = 1;
            this.rdbtnCasado.TabStop = true;
            this.rdbtnCasado.Text = "Casado";
            this.rdbtnCasado.UseVisualStyleBackColor = true;
            this.rdbtnCasado.CheckedChanged += new System.EventHandler(this.rdbtnCasado_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome funcionário";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Location = new System.Drawing.Point(12, 44);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(66, 13);
            this.lblBruto.TabIndex = 3;
            this.lblBruto.Text = "Salário bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(12, 70);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblFilhos.TabIndex = 4;
            this.lblFilhos.Text = "Número de filhos";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(117, 108);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 30);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // grpbxCasado
            // 
            this.grpbxCasado.Controls.Add(this.rdbtnSolteiro);
            this.grpbxCasado.Controls.Add(this.rdbtnCasado);
            this.grpbxCasado.Location = new System.Drawing.Point(241, 89);
            this.grpbxCasado.Name = "grpbxCasado";
            this.grpbxCasado.Size = new System.Drawing.Size(137, 49);
            this.grpbxCasado.TabIndex = 6;
            this.grpbxCasado.TabStop = false;
            // 
            // mtxtNome
            // 
            this.mtxtNome.Location = new System.Drawing.Point(117, 12);
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.Size = new System.Drawing.Size(100, 20);
            this.mtxtNome.TabIndex = 7;
            // 
            // mtxtBruto
            // 
            this.mtxtBruto.Location = new System.Drawing.Point(117, 37);
            this.mtxtBruto.Name = "mtxtBruto";
            this.mtxtBruto.Size = new System.Drawing.Size(100, 20);
            this.mtxtBruto.TabIndex = 8;
            // 
            // mtxtFilhos
            // 
            this.mtxtFilhos.Location = new System.Drawing.Point(117, 63);
            this.mtxtFilhos.Name = "mtxtFilhos";
            this.mtxtFilhos.Size = new System.Drawing.Size(100, 20);
            this.mtxtFilhos.TabIndex = 9;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(8, 174);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(73, 13);
            this.lblINSS.TabIndex = 11;
            this.lblINSS.Text = "Aliquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(10, 201);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(72, 13);
            this.lblIRPF.TabIndex = 12;
            this.lblIRPF.Text = "Aliquota IRPF";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(8, 227);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(73, 13);
            this.lblFamilia.TabIndex = 13;
            this.lblFamilia.Text = "Salário família";
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Location = new System.Drawing.Point(8, 253);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(74, 13);
            this.lblLiquido.TabIndex = 14;
            this.lblLiquido.Text = "Salário liquído";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(191, 174);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 15;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(192, 198);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 16;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // mtxtINSS
            // 
            this.mtxtINSS.Enabled = false;
            this.mtxtINSS.Location = new System.Drawing.Point(87, 171);
            this.mtxtINSS.Name = "mtxtINSS";
            this.mtxtINSS.Size = new System.Drawing.Size(98, 20);
            this.mtxtINSS.TabIndex = 17;
            this.mtxtINSS.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtINSS_MaskInputRejected);
            // 
            // mtxtIRPF
            // 
            this.mtxtIRPF.Enabled = false;
            this.mtxtIRPF.Location = new System.Drawing.Point(88, 198);
            this.mtxtIRPF.Name = "mtxtIRPF";
            this.mtxtIRPF.Size = new System.Drawing.Size(98, 20);
            this.mtxtIRPF.TabIndex = 18;
            // 
            // mtxtFamilia
            // 
            this.mtxtFamilia.Enabled = false;
            this.mtxtFamilia.Location = new System.Drawing.Point(88, 224);
            this.mtxtFamilia.Name = "mtxtFamilia";
            this.mtxtFamilia.Size = new System.Drawing.Size(98, 20);
            this.mtxtFamilia.TabIndex = 19;
            // 
            // mtxtLiquido
            // 
            this.mtxtLiquido.Enabled = false;
            this.mtxtLiquido.Location = new System.Drawing.Point(88, 250);
            this.mtxtLiquido.Name = "mtxtLiquido";
            this.mtxtLiquido.Size = new System.Drawing.Size(98, 20);
            this.mtxtLiquido.TabIndex = 20;
            // 
            // mtxtDescontoINSS
            // 
            this.mtxtDescontoINSS.Enabled = false;
            this.mtxtDescontoINSS.Location = new System.Drawing.Point(278, 172);
            this.mtxtDescontoINSS.Name = "mtxtDescontoINSS";
            this.mtxtDescontoINSS.Size = new System.Drawing.Size(122, 20);
            this.mtxtDescontoINSS.TabIndex = 21;
            // 
            // mtxtDescontoIRPF
            // 
            this.mtxtDescontoIRPF.Enabled = false;
            this.mtxtDescontoIRPF.Location = new System.Drawing.Point(278, 198);
            this.mtxtDescontoIRPF.Name = "mtxtDescontoIRPF";
            this.mtxtDescontoIRPF.Size = new System.Drawing.Size(122, 20);
            this.mtxtDescontoIRPF.TabIndex = 22;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(11, 144);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(394, 20);
            this.txtResultado.TabIndex = 23;
            // 
            // rdbtnSolteiro
            // 
            this.rdbtnSolteiro.AutoSize = true;
            this.rdbtnSolteiro.Location = new System.Drawing.Point(74, 19);
            this.rdbtnSolteiro.Name = "rdbtnSolteiro";
            this.rdbtnSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbtnSolteiro.TabIndex = 2;
            this.rdbtnSolteiro.TabStop = true;
            this.rdbtnSolteiro.Text = "Solteiro";
            this.rdbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 283);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.mtxtDescontoIRPF);
            this.Controls.Add(this.mtxtDescontoINSS);
            this.Controls.Add(this.mtxtLiquido);
            this.Controls.Add(this.mtxtFamilia);
            this.Controls.Add(this.mtxtIRPF);
            this.Controls.Add(this.mtxtINSS);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblLiquido);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.mtxtFilhos);
            this.Controls.Add(this.mtxtBruto);
            this.Controls.Add(this.mtxtNome);
            this.Controls.Add(this.grpbxCasado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.grpbxSexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxSexo.ResumeLayout(false);
            this.grpbxSexo.PerformLayout();
            this.grpbxCasado.ResumeLayout(false);
            this.grpbxCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxSexo;
        private System.Windows.Forms.RadioButton rdbtnFeminino;
        private System.Windows.Forms.RadioButton rdbtnMasculino;
        private System.Windows.Forms.RadioButton rdbtnCasado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox grpbxCasado;
        private System.Windows.Forms.MaskedTextBox mtxtNome;
        private System.Windows.Forms.MaskedTextBox mtxtBruto;
        private System.Windows.Forms.MaskedTextBox mtxtFilhos;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.MaskedTextBox mtxtINSS;
        private System.Windows.Forms.MaskedTextBox mtxtIRPF;
        private System.Windows.Forms.MaskedTextBox mtxtFamilia;
        private System.Windows.Forms.MaskedTextBox mtxtLiquido;
        private System.Windows.Forms.MaskedTextBox mtxtDescontoINSS;
        private System.Windows.Forms.MaskedTextBox mtxtDescontoIRPF;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdbtnSolteiro;
    }
}

