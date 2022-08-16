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

namespace LINQ5
{
    public partial class Form1 : Form
    {
        DataGrid Fuente;
        DataClasses1DataContext dataContext;
        public Form1()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["LINQ5.Properties.Settings.LinqString"].ConnectionString;
            dataContext =new DataClasses1DataContext(Conexion);
            insertaUsuario();
            insertatrabajador();
        }
        public void insertaUsuario() {
            usuarios datos = new usuarios();
            datos.usuario = "prueba1";
            dataContext.usuarios.InsertOnSubmit(datos);
            dataContext.SubmitChanges();
            
        }
        public void insertatrabajador() {
            usuarios user1 = dataContext.usuarios.First(us=>us.usuario.Equals("Joaquin"));
            usuarios user2 = dataContext.usuarios.First(us => us.usuario.Equals("Ludwig"));
            List<trabajador> listatrabajadores = new List<trabajador>();
            listatrabajadores.Add(new trabajador { nombre = "Antonio", apellido_pat = "Diaz", apellido_mat = "Martinez",direccion="calle", telefono="9511001234",id_usuario=user1.id });
            listatrabajadores.Add(new trabajador { nombre = "Juan", apellido_pat = "Perez", apellido_mat = "Lopez", direccion = "calle", telefono = "9511001234",id_usuario=user2.id });
            dataContext.trabajador.InsertAllOnSubmit(listatrabajadores);
            dataContext.SubmitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'linqDatos.trabajador' Puede moverla o quitarla según sea necesario.
            this.trabajadorTableAdapter.Fill(this.linqDatos.trabajador);
            // TODO: esta línea de código carga datos en la tabla 'linqDatos.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.linqDatos.usuarios);

        }
    }
}
