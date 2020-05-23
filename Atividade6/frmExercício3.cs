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
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void btnCalcularPalindromo_Click(object sender, EventArgs e)// não sei tirar espaços em branco
        {
            
            if (txtPalavra.Text.Length <= 50)
            {
                txtPalavra.Text = txtPalavra.Text.ToUpper();
                string s = txtPalavra.Text;
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);

                s = "";

                foreach (char c in arr)
                {
                    s = s + c.ToString();
                }
                if (String.Compare(txtPalavra.Text, s, true) == 0)
                {
                    MessageBox.Show("Sao palindromos!");
                }
                else
                    MessageBox.Show("Nao sao palindromos!");
            }
        }
    }
}
