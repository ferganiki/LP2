namespace Atividade6
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblIncrição = new System.Windows.Forms.Label();
            this.lblProdrução = new System.Windows.Forms.Label();
            this.lblSalário = new System.Windows.Forms.Label();
            this.lblGratificação = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtProdução = new System.Windows.Forms.TextBox();
            this.txtSalário = new System.Windows.Forms.TextBox();
            this.txtGratificação = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(12, 45);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblIncrição
            // 
            this.lblIncrição.AutoSize = true;
            this.lblIncrição.Location = new System.Drawing.Point(12, 71);
            this.lblIncrição.Name = "lblIncrição";
            this.lblIncrição.Size = new System.Drawing.Size(104, 13);
            this.lblIncrição.TabIndex = 2;
            this.lblIncrição.Text = "Numero de inscrição";
            // 
            // lblProdrução
            // 
            this.lblProdrução.AutoSize = true;
            this.lblProdrução.Location = new System.Drawing.Point(12, 97);
            this.lblProdrução.Name = "lblProdrução";
            this.lblProdrução.Size = new System.Drawing.Size(53, 13);
            this.lblProdrução.TabIndex = 3;
            this.lblProdrução.Text = "Produção";
            // 
            // lblSalário
            // 
            this.lblSalário.AutoSize = true;
            this.lblSalário.Location = new System.Drawing.Point(12, 128);
            this.lblSalário.Name = "lblSalário";
            this.lblSalário.Size = new System.Drawing.Size(39, 13);
            this.lblSalário.TabIndex = 4;
            this.lblSalário.Text = "Salário";
            // 
            // lblGratificação
            // 
            this.lblGratificação.AutoSize = true;
            this.lblGratificação.Location = new System.Drawing.Point(12, 158);
            this.lblGratificação.Name = "lblGratificação";
            this.lblGratificação.Size = new System.Drawing.Size(64, 13);
            this.lblGratificação.TabIndex = 5;
            this.lblGratificação.Text = "Gratificação";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(122, 38);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(122, 64);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // txtProdução
            // 
            this.txtProdução.Location = new System.Drawing.Point(122, 90);
            this.txtProdução.Name = "txtProdução";
            this.txtProdução.Size = new System.Drawing.Size(100, 20);
            this.txtProdução.TabIndex = 9;
            // 
            // txtSalário
            // 
            this.txtSalário.Location = new System.Drawing.Point(122, 121);
            this.txtSalário.Name = "txtSalário";
            this.txtSalário.Size = new System.Drawing.Size(100, 20);
            this.txtSalário.TabIndex = 10;
            // 
            // txtGratificação
            // 
            this.txtGratificação.Location = new System.Drawing.Point(122, 151);
            this.txtGratificação.Name = "txtGratificação";
            this.txtGratificação.Size = new System.Drawing.Size(100, 20);
            this.txtGratificação.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(207, 33);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular salário bruto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtGratificação);
            this.Controls.Add(this.txtSalário);
            this.Controls.Add(this.txtProdução);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGratificação);
            this.Controls.Add(this.lblSalário);
            this.Controls.Add(this.lblProdrução);
            this.Controls.Add(this.lblIncrição);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblIncrição;
        private System.Windows.Forms.Label lblProdrução;
        private System.Windows.Forms.Label lblSalário;
        private System.Windows.Forms.Label lblGratificação;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtProdução;
        private System.Windows.Forms.TextBox txtSalário;
        private System.Windows.Forms.TextBox txtGratificação;
        private System.Windows.Forms.Button btnCalcular;
    }
}