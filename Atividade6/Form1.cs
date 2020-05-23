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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExercício1_Click(object sender, EventArgs e)
        {
            frmExercício1 frm1 = new frmExercício1();        
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void btnExercício2_Click(object sender, EventArgs e)
        {
            frmExercício2 frm2 = new frmExercício2();
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void btnExercício3_Click(object sender, EventArgs e)
        {
            frmExercício3 frm3 = new frmExercício3();
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void btnExercício4_Click(object sender, EventArgs e)
        {
            frmExercício4 frm4 = new frmExercício4();
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }
    }
}
