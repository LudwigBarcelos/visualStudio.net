using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejemploentityforms.Modelo;

namespace ejemploentityforms
{
    public partial class FrmVerTrabajadores : Form
    {
        public FrmVerTrabajadores()
        {
            InitializeComponent();
        }

        private void FrmVerTrabajadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioDataSet.trabajador' Puede moverla o quitarla según sea necesario.
            this.trabajadorTableAdapter.Fill(this.ejercicioDataSet.trabajador);
            using (ejercicioEntities db = new ejercicioEntities())
            {
                var lista = from d in db.trabajador select d;
                dataGridView1.DataSource = lista.ToList();
            }
        }

        private void FrmVerTrabajadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }
    }
}
