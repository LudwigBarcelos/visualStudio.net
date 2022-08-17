using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ6
{
    public partial class FrmAgrega : Form
    {
        DataClasses1DataContext dataContext;
        public FrmAgrega()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["LINQ6.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarios datos = new usuarios();
            datos.usuario = textBox1.Text;
            datos.passwd = textBox2.Text;
            datos.estado = comboBox1.SelectedItem.ToString();
            datos.tipo_usuario = comboBox2.SelectedItem.ToString();
            dataContext.usuarios.InsertOnSubmit(datos);
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario Guardado Con Exito!!", "Usuario Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
