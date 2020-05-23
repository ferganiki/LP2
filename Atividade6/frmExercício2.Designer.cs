namespace Atividade6
{
    partial class frmExercício2
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalculaH = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(42, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnCalculaH
            // 
            this.btnCalculaH.Location = new System.Drawing.Point(42, 54);
            this.btnCalculaH.Name = "btnCalculaH";
            this.btnCalculaH.Size = new System.Drawing.Size(100, 23);
            this.btnCalculaH.TabIndex = 1;
            this.btnCalculaH.Text = "Calcular H";
            this.btnCalculaH.UseVisualStyleBackColor = true;
            this.btnCalculaH.Click += new System.EventHandler(this.btnCalculaH_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 12);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(18, 13);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "N:";
            // 
            // frmExercício2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 123);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnCalculaH);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmExercício2";
            this.Text = "frmExercício2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalculaH;
        private System.Windows.Forms.Label lblN;
    }
}