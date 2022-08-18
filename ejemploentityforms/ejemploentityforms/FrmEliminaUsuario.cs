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
    public partial class FrmEliminaUsuario : Form
    {
        public FrmEliminaUsuario()
        {
            InitializeComponent();
        }

        private void FrmEliminaUsuario_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Show();//abriendo el formulario principal
            comboBox1.Items.Clear();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int borra;
            string cadena;
            string[] corta; 
            cadena = comboBox1.SelectedItem.ToString();
            corta = cadena.Split('-');
            borra = Int32.Parse(corta[0]);
            using (ejercicioEntities db = new ejercicioEntities())
            {
                usuarios  usuario1=db.usuarios.Find(borra);
                db.usuarios.Remove(usuario1);
                db.SaveChanges();
                MessageBox.Show("Usuario Eliminado Con Exito!!", "Usuario Eliminado", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                FrmEliminaUsuario_Load(sender,e);
            }
            
        }
    }
}
