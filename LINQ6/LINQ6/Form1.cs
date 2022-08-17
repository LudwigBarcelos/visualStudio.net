using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ6
{
   

    public partial class FrmPrincipal : Form
    {
          public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgrega frm1 = new FrmAgrega();
            frm1.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmElimina frm2 = new FmElimina();
            frm2.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmModifica frm3 = new FrmModifica();
            frm3.Show();
            this.Hide();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMuestra frm4 = new FrmMuestra();
            frm4.Show();
            this.Hide();
        }
    }
}
