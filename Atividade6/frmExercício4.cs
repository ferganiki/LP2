using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salariobruto;
            float gratificações, A;
            int B, C, D, producao;
            if(float.TryParse(txtSalário.Text, out A) && (int.TryParse(txtProdução.Text, out producao) && (float.TryParse(txtGratificação.Text, out gratificações))))
            {
                if (producao >= 100)
                    B = 1;
                else
                    B = 0;
                if (producao >= 120)
                    C = 1;
                else
                    C = 0;  
                if (producao >= 150)
                    D = 1;
                else
                    D = 0;
                salariobruto = A + A*((0.05*B)+(0.1*C)+(0.1*D)) + gratificações;
                if (salariobruto > 7000 && producao >= 150)
                    MessageBox.Show("O salario bruto e:" + salariobruto);
                if (salariobruto > 7000 && producao < 150)
                    MessageBox.Show("O salario bruto e: 7000,00");
                else
                    MessageBox.Show("O salario bruto e:" + salariobruto);

            }
            

            
        }
    }
}
