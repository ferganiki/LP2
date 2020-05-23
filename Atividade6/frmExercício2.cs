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
    public partial class frmExercício2 : Form
    {
        public frmExercício2()
        {
            InitializeComponent();
        }

        private void btnCalculaH_Click(object sender, EventArgs e)
        {
            int i, x;
            float h, j;
            j = 1;
            h = 0;
            if((int.TryParse(txtNumero.Text, out i)))
            {
                for(x = 0; x < i; x++)
                {
                    h = h + 1 / j;
                    j = j + 1;
                }
            }
            MessageBox.Show("H:" +h);
        }
    }
}
