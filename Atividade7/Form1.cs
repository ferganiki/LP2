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

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            int x = 0;

            string auxiliar = "";
            string valor = "";

            for (x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado" +" " + (x+1) , "Entrado de dados");

                if (int.TryParse(valor, out vetor[x]))
                    auxiliar = vetor[x].ToString() + "\n" + auxiliar;
                else
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";

            for (x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado da posição" + (x + 1), "Digitação dos dados");
                if (!int.TryParse(valor, out vetor[x]))
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                }
            }
            Array.Reverse(vetor);

            for (x = 0; x < 20; x++)
                auxiliar += vetor[x] + "\n";
            MessageBox.Show(auxiliar);
        }

        private void btnMercadoria_Click(object sender, EventArgs e)
        {
            int x;
            double[] vetorqnt = new double[10];
            double[] vetorvalor = new double[10];
            double valor1, valor2;
            string valor = "";
            string auxiliar1 = "";
            string auxiliar2 = "";

            for (x = 0; x < 10; x++)
            {
                valor = Interaction.InputBox("Digite a quantidade da mercadoria" + " " + (x + 1), "Digitação das quantidades");
                if (double.TryParse(valor, out vetorqnt[x]))
                {
                    auxiliar1 = vetorqnt[x].ToString() + "\n" + auxiliar1;
                }
                else
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                    continue;
                }
                valor = Interaction.InputBox("Digite o valor da mercadoria" + " " + (x + 1), "Digitação dos valores");
                if (double.TryParse(valor, out vetorvalor[x]))
                {
                    auxiliar2 = vetorvalor[x].ToString() + "\n" + auxiliar2;
                }
                else
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                    continue;
                }
            }
            double.TryParse(auxiliar1, out valor1);
            double.TryParse(auxiliar1, out valor2);
            valor1 = valor1 * valor2;
            MessageBox.Show("O faturamento mensal é" + " " + "R$" + valor1);


        }

        private void btnVariável_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior" + 
                                "Leonardo", "Jose", "Nelma", "Tobby"};

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
                Total += Alunos[I].Length;
            string P = Total.ToString();
            MessageBox.Show(P);
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList Alunos = new System.Collections.ArrayList();

            Alunos.Add("Ana");
            Alunos.Add("André");
            Alunos.Add("Débora");
            Alunos.Add("Fátima");
            Alunos.Add("João");
            Alunos.Add("Janete");
            Alunos.Add("Otávio");
            Alunos.Add("Marcelo");
            Alunos.Add("Pedro");
            Alunos.Add("Thais");

            Alunos.Remove("Otávio");

            string nomes = "";
            foreach (string nome in Alunos)
            {
                nomes += nome + "\n";
            }
            MessageBox.Show(nomes);
        }

        private void btnMédia_Click(object sender, EventArgs e)
        {
            int i, j, k = 1;
            double media = 0;
            double[,] Alunos = new double[20, 3];
            string valor = "";
            string auxiliar1 = "";


            for (i = 0; i < 20; i++)
                for (j = 0; j < 3; j++)
                {
                    valor = Interaction.InputBox("Digite a nota" + " " + (j + 1) + " " + "do" + " " + (i+1) +" " + "aluno", "Digitação das quantidades");
                    if (double.TryParse(valor, out Alunos[i,j]))
                    {
                        auxiliar1 = Alunos[i,j].ToString() + "\n" + auxiliar1;
                    }
                    else
                    {
                        MessageBox.Show("Número inválido!");
                        j--;
                        continue;
                    }
                }
            for (i = 0; i < 20; i++)
            {
                media = 0;
                for (j = 0; j < 3; j++)
                {
                    media = media + Alunos[i, j];
                }
                media = media / 3;
 
                MessageBox.Show("A media do aluno" + " " + k + " " + "é" + media);
                k++;
            }
        }

        private void btnExercício7_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Form2"];
            if (fc != null)
                fc.Close();
            Form2 frm2 = new Form2();
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }
    }
}
