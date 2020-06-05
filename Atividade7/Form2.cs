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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rchText_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int x;
            string vetorqnt;



            for (x = 0; x < 10; x++)
            {
                vetorqnt = Interaction.InputBox("Digite o nome completo" + " " + (x + 1), "Digitação dos nomes");
                vetorqnt = vetorqnt.Replace(" ", "");
                MessageBox.Show("o nome" + " " + vetorqnt + "tem" + " " + vetorqnt.Length + "caracteres");
            }
            

        }
    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
