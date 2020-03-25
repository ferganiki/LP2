using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float A, B, C;
            if (float.TryParse(txtA.Text, out A) && float.TryParse(txtB.Text, out B) && float.TryParse(txtC.Text, out C))
            {
                if(A != 0 && B != 0 && C != 0)
                {
                    float X, Y, Z;
                    X = Y = Z = 0;
                    X = B - C;
                    if (X < 0)
                        X = X * -1;
                    Y = A - C;
                    if (Y < 0)
                        Y = Y * -1;
                    Z = A - B;
                    if (Z < 0)
                        Z = Z * -1;



                    if (X < A && A < B + C && Y < B && B < A + C && Z < C && C < A + B)
                    {
                        if(A != B && A != C && B != C)
                            MessageBox.Show("Escaleno");
                        if(A == B &&  A == C && B == C)
                            MessageBox.Show("Equilátero");
                        else
                            MessageBox.Show("Isóceles");
                    }
                    else
                        MessageBox.Show("Dados inválidos");

                }
                else
                    MessageBox.Show("Dados inválidos");
            }
            else
                MessageBox.Show("Dados inválidos");
        }
    }
}
