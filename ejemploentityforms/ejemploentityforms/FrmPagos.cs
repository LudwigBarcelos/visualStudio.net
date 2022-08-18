using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemploentityforms.Modelo;
using System.Windows.Forms;

namespace ejemploentityforms
{
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            using (ejercicioEntities db = new ejercicioEntities())
            {
                var lista = db.trabajador;
                foreach (var t1 in lista)
                {
                    comboBox1.Items.Add(t1.id_trabajador + " - " + t1.nombre);
                }
            }
            DateTime aDate = DateTime.Now;
            lblFecha.Text = aDate.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Show();//abriendo el formulario principal
            comboBox1.Items.Clear();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pago;
            int sem=Convert.ToInt32(txtSemanas.Text.Trim());
            pago = sem * 10000;
            textBox2.Text = pago.ToString();
        }
    }
}
