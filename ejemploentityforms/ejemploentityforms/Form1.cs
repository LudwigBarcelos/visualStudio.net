using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploentityforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerUsuarios frmVerUsuarios = new FrmVerUsuarios();            
            frmVerUsuarios.Show();
            this.Hide();
        }

        private void verTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerTrabajadores frmVerTrabajadores = new FrmVerTrabajadores();
            frmVerTrabajadores.Show();
            this.Hide();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertaUsuario frmInsertaUsuario = new FrmInsertaUsuario();
            frmInsertaUsuario.Show();
            this.Hide();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminaUsuario frmEliminaUsuario = new FrmEliminaUsuario();
            frmEliminaUsuario.Show();
            this.Hide();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifica frmModificaUsuario = new FrmModifica();
            frmModificaUsuario.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmabout = new FrmAbout();
            frmabout.Show();
            this.Hide();
        }

        private void generarPagoATrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagos frmpago = new FrmPagos();
            frmpago.Show();
            this.Hide();
        }
    }
}
