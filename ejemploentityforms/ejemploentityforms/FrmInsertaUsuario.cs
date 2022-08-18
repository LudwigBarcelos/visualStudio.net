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
    public partial class FrmInsertaUsuario : Form
    {
        public FrmInsertaUsuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Show();//abriendo el formulario principal
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ejercicioEntities db = new ejercicioEntities())
            {

                usuarios usuarios1= new usuarios();

                usuarios1.usuario = txtuser.Text.Trim();
                usuarios1.passwd = txtpass.Text.Trim();
                usuarios1.estado = comboBox1.SelectedItem.ToString();
                usuarios1.tipo_usuario = comboBox2.SelectedItem.ToString();

                db.usuarios.Add(usuarios1);
                db.SaveChanges();
                MessageBox.Show("Usuario Guardado Con Exito!!", "Usuario Guardado", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                button2_Click(sender,e);
            }                         
            
               
            
        }

        private void FrmInsertaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
