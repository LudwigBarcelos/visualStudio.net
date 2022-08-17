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
    public partial class FmElimina : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listaUsuarios;
        public FmElimina()
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
            usuarios user = dataContext.usuarios.First(us=>us.usuario.Equals(comboBox1.SelectedItem.ToString()));
            dataContext.usuarios.DeleteOnSubmit(user);
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario Eliminado Con Exito!!", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FmElimina_Load(object sender, EventArgs e)
        {       
            var lista= dataContext.usuarios.OrderBy(x=>x.id).ToList();
            
            foreach (usuarios usuario in lista)
            {
                comboBox1.Items.Add(usuario.usuario);
            }
        }
    }
}
