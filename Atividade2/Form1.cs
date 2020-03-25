using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e) // usar , ao invés de . // Não consegui fazer com o maskedtextbox com a altura
        {                                                                                                  
            double Altura, Peso, PesoIdeal;
            PesoIdeal = 0;
            if (double.TryParse(mtxtAltura.Text, out Altura) && double.TryParse(mtxtPeso.Text, out Peso))
            {
                if (rdbtnMasculino.Checked)
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    if (Peso > PesoIdeal)
                    {
                        MessageBox.Show("Regime obrigatório já");
                    }
                    if (Peso == PesoIdeal)
                    {
                        MessageBox.Show("Você está com o peso ideal");
                    }
                    if (Peso < PesoIdeal)
                    {
                        MessageBox.Show("Coma bastante massas e doces");
                    }
                }
                if (rdbtnFeminino.Checked)
                {
                    PesoIdeal = (62.1 * Altura) -44.7;
                    if (Peso > PesoIdeal)
                        MessageBox.Show("Regime obrigatório já");
                    if (Peso == PesoIdeal)
                        MessageBox.Show("Você está com o peso ideal");
                    if (Peso < PesoIdeal)
                        MessageBox.Show("Coma bastante massas e doces");
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }
        }
    }
}
