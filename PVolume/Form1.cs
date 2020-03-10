using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Raio, Altura;

            if (double.TryParse(txtNum1.Text, out Raio) && double.TryParse(txtNum2.Text, out Altura))
            {
                double volume = ((Raio * Raio) * Math.PI) * Altura;
                txtNum3.Text = volume.ToString("N2");
            }
            else
            {
                MessageBox.Show("Falta dados!");
            }
        }
    }
}
