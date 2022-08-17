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
    public partial class FrmModifica : Form
    {
        DataClasses1DataContext dataContext1;
        public List<usuarios> listaUsuarios;
        usuarios usua;
        public FrmModifica()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["LINQ6.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext1 = new DataClasses1DataContext(Conexion);
        }

        private void FrmModifica_Load(object sender, EventArgs e)
        {
            var lista = dataContext1.usuarios.OrderBy(x => x.id).ToList();
            foreach (usuarios usuario in lista)
            {
                comboBox3.Items.Add(usuario.usuario);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usua.usuario = textBox1.Text;
            usua.passwd = textBox2.Text;
            usua.estado = comboBox1.SelectedItem.ToString();
            usua.tipo_usuario = comboBox2.SelectedItem.ToString();
            dataContext1.SubmitChanges();
            MessageBox.Show("Usuario Modificado Con Exito!!", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            usuarios user = dataContext1.usuarios.First(us => us.usuario.Equals(comboBox3.SelectedItem.ToString()));
            usua = user;
            textBox1.Text = user.usuario;
            textBox2.Text = user.passwd;
            comboBox1.Items.Insert(0,user.estado);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Insert(0, user.tipo_usuario);
            comboBox2.SelectedIndex = 0;
        }
    }
}
