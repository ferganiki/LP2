using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace P0030481921040
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] Vetor = new double[10, 4];
            double totalmes = 0, totalano = 0;
            int i, j;

            string auxiliar = "";
            string valor = "";

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    valor = Interaction.InputBox("Digite o total do mês:" + " " + (i + 1) + " " + "da" + " " + "semana:" + " " + (j + 1), "Digitação dos lucros");
                    if (double.TryParse(valor, out Vetor[i, j]))
                    {
                        auxiliar = Vetor[i, j].ToString() + "\n" + auxiliar;
                        totalmes += Vetor[i, j];
                        lstResultado.Items.Add("Total mês:" + " " + (i + 1) + " " + "da semana:" + " " + (j + 1) + " " + "R$" + Math.Round(Vetor[i, j], 2));
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido!");
                        j--;
                        continue;
                    }
                }
                lstResultado.Items.Add("Total mês: R$" + " " + Math.Round(totalmes, 2));
                lstResultado.Items.Add("----------------------------------");
                totalano += totalmes;
                totalmes = 0;
            }
       
            lstResultado.Items.Add("Total ano:" + " " + "R$" + Math.Round(totalano, 2));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
        }
    }
}
    