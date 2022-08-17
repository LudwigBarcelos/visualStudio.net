using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LINQ7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*  XElement documento = new XElement("Alumnos",
                  new XElement("Alumno", new XAttribute("Id", "1"),
                      new XElement("Nombre", "Luis"),
                      new XElement("Asignatura", "POO"),
                      new XElement("Calif", "9")
                  ),
                  new XElement("Alumno", new XAttribute("Id", "2"),
                      new XElement("Nombre", "Pedro"),
                      new XElement("Asignatura", "POO"),
                      new XElement("Calif", "8")
                  )
              );
              textBox1.Text = documento.ToString();
              documento.Save("Alumnos.xml");
            */
            //---------------
            /*
            XDocument doc = new XDocument(
                new XDeclaration("1.0","UTF-8","yes"),
                new XComment ("Comentario: Listado de Alumnos"),
                new XElement("Alumnos",
                    new XElement("Luis", new XAttribute("Id", "1"),
                        new XElement("Asignatura", "POO"),
                        new XElement("Calif", "9")
                    ),
                    new XElement("Pedro", new XAttribute("Id", "2"),
                        new XElement("Asignatura", "POO"),
                        new XElement("Calif", "8")
                    )
                )
             );
            textBox1.Text = doc.ToString();
            doc.Save("Alumnos1.xml");
            */
            //------------
            /*
            var lista = new List<Alumno> { new Alumno { Id = 0, Nombre = "Pedro",Calif = 5},
                                            new Alumno {Id=1,Nombre = "Jorge",Calif = 8},
                                            new Alumno {Id=2, Nombre = "Andres",Calif = 3},
                                            new Alumno {Id=3, Nombre = "Sandra",Calif = 6},
                                            new Alumno {Id=4, Nombre = "Jaime",Calif = 10}
            };
            XElement alumnos = new XElement("Alumnos",
                  from a in lista
                  select new XElement("Alumno", new XAttribute("Id", a.Id),
                      new XElement("Nombre", a.Nombre),
                      new XElement("Calif", a.Calif)
                  )                 
              );
            textBox1.Text = alumnos.ToString();
            alumnos.Save("Alumnos2.xml");
            */
            //------------------
            /*
            string texto = @"<Alumnos>
                  <Alumno Id = '1'>
                    <Asignatura > POO </Asignatura >
                    <Calif> 9 </Calif >
                  </Alumno>
                  <Alumno Id = '2' >
                     <Asignatura > POO </Asignatura >
                     <Calif> 8 </Calif >
                   </Alumno>
              </Alumnos>";
            XElement listaAlumnos = XElement.Parse(texto);
            textBox1.Text = texto.ToString();
            listaAlumnos.Save("Alumnos3.xml");
            */
            //---------
            /*
            var archivo = @"C:\Users\ludwi\source\repos\LINQ7\LINQ7\bin\Debug\archivo.xml";
            XDocument alumnos = XDocument.Load(archivo);
            textBox1.Text = alumnos.ToString();
            var listaNombres = from e in alumnos.Descendants("Nombre")select e.Value;
            foreach (string el in listaNombres) {
                textBox2.Text = textBox2.Text +" \n " +el+ String.Format(Environment.NewLine);
            }*/
            //alumnos.Descendants("Docentes").Remove();
        }
    }
}
