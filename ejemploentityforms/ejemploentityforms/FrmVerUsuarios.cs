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
    public partial class FrmVerUsuarios : Form
    {
        public FrmVerUsuarios()
        {
            InitializeComponent();
        }

        private void FrmVerUsuarios_Load(object sender, EventArgs e)
        {
            using (ejercicioEntities db=new ejercicioEntities()) {
                var lista = from d in db.usuarios select d;
                dataGridView1.DataSource = lista.ToList();
            }
        }

        private void FrmVerUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }
    }
}
