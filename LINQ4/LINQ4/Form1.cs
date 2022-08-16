using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LINQ4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Trabajador> listaTrabajadores;
            private void button1_Click(object sender, EventArgs e)
        {
            listaTrabajadores = new List<Trabajador>();
            listaTrabajadores.Add(new Trabajador { Id = Convert.ToInt32(textBox1.Text), Nombre = textBox2.Text, ApellidoPat = textBox3.Text, ApellidoMat = textBox4.Text, Sueldo = Convert.ToInt32(textBox5.Text), Puesto= comboBox1.SelectedItem.ToString() });
            llenaText();
        }

        private void llenaText()
        {
            IEnumerable<Trabajador> t1 = from Trabajador in listaTrabajadores orderby Trabajador.Nombre select Trabajador;
            foreach (Trabajador trabaja in t1)
            {
                textBox6.AppendText(Convert.ToString(trabaja.getId()));
                textBox6.AppendText(" "+trabaja.getNombre());
                textBox6.AppendText(" " + trabaja.getApellidoPat());
                textBox6.AppendText(" " + trabaja.getApellidoMat());
                textBox6.AppendText(" "+Convert.ToString(trabaja.getSueldo()));
                textBox6.AppendText(" " + trabaja.getPuesto());
                textBox6.AppendText(Environment.NewLine);
            }
        }
    }
}
