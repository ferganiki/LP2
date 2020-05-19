using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5REAL
{
    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumericos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var x=0; x<rchtxtTexto.Text.Length; x++)
            {
                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    contador += 1;
            }
            MessageBox.Show("Caracteres numericos:"+contador);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x<rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro carater branco:" + (x + 1));
                    break;
                }
                x += 1;
            }

        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach(char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }
            MessageBox.Show("Caracteres alfabeticos:"+contador);
        }
    }
}
