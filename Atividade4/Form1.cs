using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtnCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mtxtINSS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e) // usar vírgula
        {
            double salariobruto, salariofamilia, descontoINSS, descontoIRPF, salarioliquido;
            byte Filhos;
            if (string.IsNullOrWhiteSpace(mtxtNome.Text))
                MessageBox.Show("Falta o nome");
            if (double.TryParse(mtxtBruto.Text, out salariobruto))
            {
                if (salariobruto <= 800.47)
                {
                    mtxtINSS.Text = "7.65%";
                    descontoINSS = 7.65 / 100 * salariobruto;
                    mtxtDescontoINSS.Text = descontoINSS.ToString("N2");
                }
                if (salariobruto > 800.47 && salariobruto <= 1050)
                { 
                    mtxtINSS.Text = "8.65%";
                    descontoINSS = 8.65 / 100 * salariobruto;
                    mtxtDescontoINSS.Text = descontoINSS.ToString("N2");
                }
                if (salariobruto > 1050 && salariobruto <= 1400.77)
                { 
                    mtxtINSS.Text = "9.00%";
                    descontoINSS = 9.00 / 100 * salariobruto;
                    mtxtDescontoINSS.Text = descontoINSS.ToString("N2");
                }
                if (salariobruto > 1400.77 && salariobruto <= 2801.56)
                { 
                    mtxtINSS.Text = "11.00%";
                    descontoINSS = 11.00 / 100 * salariobruto;
                    mtxtDescontoINSS.Text = descontoINSS.ToString("N2");
                }
                if (salariobruto > 2801.56)
                { 
                    mtxtINSS.Text = "Teto";
                    descontoINSS = 308.17;
                    mtxtDescontoINSS.Text = descontoINSS.ToString("N2");
                }
                if (salariobruto <= 1257.12)
                {
                    mtxtIRPF.Text = "Isento";
                    descontoIRPF = 0;
                    mtxtDescontoIRPF.Text = descontoIRPF.ToString("N2");
                }
                if (salariobruto > 1257.12 && salariobruto <= 2512.08)
                { 
                    mtxtIRPF.Text = "15.00%";
                    descontoIRPF = 15.00 / 100 * salariobruto;
                    mtxtDescontoIRPF.Text = descontoIRPF.ToString("N2");
                }
                if (salariobruto > 2512.08)
                { 
                    mtxtIRPF.Text = "27.50%";
                    descontoIRPF = 27.50 / 100 * salariobruto;
                    mtxtDescontoIRPF.Text = descontoIRPF.ToString("N2");
                }
                if (byte.TryParse(mtxtFilhos.Text, out Filhos))
                {
                    if (salariobruto <= 435.52)
                    {
                        salariofamilia = Filhos * 22.33;
                        mtxtFamilia.Text = salariofamilia.ToString("N2");
                    }
                    if (salariobruto > 435.52 && salariobruto <= 654.61)
                    {
                        salariofamilia = Filhos * 15.74;
                        mtxtFamilia.Text = salariofamilia.ToString("N2");
                    }
                    if (salariobruto > 654.61)
                    {
                        salariofamilia = 0;
                        mtxtFamilia.Text = salariofamilia.ToString("N2");
                    }

                }
                if (double.TryParse(mtxtFamilia.Text, out salariofamilia) && double.TryParse(mtxtDescontoINSS.Text, out descontoINSS) && double.TryParse(mtxtDescontoIRPF.Text, out descontoIRPF))
                {
                    salarioliquido = salariobruto + salariofamilia - descontoINSS - descontoIRPF;
                    mtxtLiquido.Text = salarioliquido.ToString("N2");
                }
                if (rdbtnMasculino.Checked)
                    if (rdbtnCasado.Checked)
                        txtResultado.Text = "Os descontos do salário do " + mtxtNome.Text + " que é casado e que tem " + mtxtFilhos.Text + " filhos são:";
                    else
                        txtResultado.Text = "Os descontos do salário do " + mtxtNome.Text + " que é solteiro e que tem " + mtxtFilhos.Text + " filhos são:";
                if (rdbtnFeminino.Checked)
                    if (rdbtnCasado.Checked)
                        txtResultado.Text = "Os descontos do salário da " + mtxtNome.Text + " que é casada e que tem " + mtxtFilhos.Text + " filhos são:";
                    else
                        txtResultado.Text = "Os descontos do salário da " + mtxtNome.Text + " que é solteira e que tem " + mtxtFilhos.Text + " filhos são:";
            }
            else
                MessageBox.Show("Dados inválidos!");
        }
    }
}
