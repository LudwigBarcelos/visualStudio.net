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
    public partial class FrmModifica : Form
    {
        int identificador;
        public FrmModifica()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Show();//abriendo el formulario principal
            comboBox1.Items.Clear();
            this.Hide();
        }

        private void FrmModifica_Load(object sender, EventArgs e)
        {
            using (ejercicioEntities db = new ejercicioEntities())
            {
                var lista = db.usuarios;
                foreach (var t1 in lista)
                {
                    comboBox1.Items.Add(t1.id + " - " + t1.usuario);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sel;
            string cadena;
            string[] corta;
            cadena = comboBox1.SelectedItem.ToString();
            corta = cadena.Split('-');
            sel = Int32.Parse(corta[0]);
            identificador = sel;
            using (ejercicioEntities db = new ejercicioEntities())
            {
                usuarios usuario1 = db.usuarios.Find(sel);
                txtuser.Text =usuario1.usuario;
                txtpass.Text =usuario1.passwd;
                comboBox3.Text =usuario1.estado;
                comboBox2.Text =usuario1.tipo_usuario;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (ejercicioEntities db = new ejercicioEntities())
            {
                usuarios usuario1 = db.usuarios.Find(identificador);
                usuario1.usuario = txtuser.Text;
                usuario1.passwd = txtpass.Text;
                usuario1.estado = comboBox3.SelectedItem.ToString();
                usuario1.tipo_usuario = comboBox2.SelectedItem.ToString();
                db.Entry(usuario1).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Usuario Modificado Con Exito!!", "Usuario Modificado", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                FrmModifica_Load(sender, e);
                txtuser.Text = "";
                txtpass.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
            }

        }
    }
}
