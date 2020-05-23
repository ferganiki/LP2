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
    public partial class frmExercício1 : Form
    {
        public frmExercício1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0, i;
            for (i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[i]))
                {
                    x = x + 1;
                }
            }
            MessageBox.Show("A quantidade de caracteres brancos e:" + x);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int x = 0;
            int i = 0;
            while (x < rchtxtTexto.Text.Length)
            {
                if (rchtxtTexto.Text[x] == 'r' || rchtxtTexto.Text[x] == 'R')
                {
                    i = i + 1;
                }
                x += 1;

            }
            MessageBox.Show("A quantidade de R e:" + i);
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            int x = 0, i;
            for (i = 0; i < rchtxtTexto.Text.Length -1; i++)
            {
                if (rchtxtTexto.Text[i] == rchtxtTexto.Text[i+1])
                {
                    x = x + 1;
                }
            }
            MessageBox.Show("A quantidade de caracteres repetidos em sequencia e:" + x);
        }
    }
}
