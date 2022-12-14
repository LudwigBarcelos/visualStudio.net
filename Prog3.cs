using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlPersonas con1= new ControlPersonas();
            con1.getLista();
            int id =Convert.ToInt32( Console.ReadLine());
            con1.getPersona(id);

        }
    }
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Nota { get; set; }
        public void getNota() {
            Console.WriteLine("Nota: {0} con Id {1} y Nombre {2}",Nota,Id,Nombre);
        }
        public void getNombre() {
            Console.WriteLine("Nombre: {0} con Nota {1}", Nombre, Nota);
        }
        public void getDatos() {
            Console.WriteLine("Id: {0} Nombre:  {1}  Edad: {2} Nota:{3} ", Id, Nombre,Edad, Nota);
        }
    }
    class ControlPersonas
    {
       
        public ControlPersonas()
        {
            listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona { Id = 1, Nombre = "Pedro", Edad = 13, Nota = 5 });
            listaPersonas.Add(new Persona { Id = 2, Nombre = "Jorge", Edad = 13, Nota = 8 });
            listaPersonas.Add(new Persona { Id = 3, Nombre = "Andres", Edad = 14, Nota = 6 });
        }
        public List<Persona> listaPersonas;
        public void getLista()
        {
            IEnumerable<Persona> per1 = from Persona in listaPersonas where Persona.Nombre== "Pedro" select Persona;
            IEnumerable<Persona> per2 = from Persona in listaPersonas where Persona.Nota > 5 select Persona;
            foreach (Persona persona1 in per1) {
                persona1.getNombre();
            }
            Console.ReadKey();
             foreach (Persona persona2 in per2)
            {
                persona2.getNota();
            }
            Console.ReadKey();
            IEnumerable<Persona> per3 = from Persona in listaPersonas orderby Persona.Nombre select Persona;
            foreach (Persona persona3 in per3)
            {
                persona3.getNombre();
            }
            //Console.ReadKey();
        }
        public void getPersona(int  Id) {
            IEnumerable<Persona> per = from Persona in listaPersonas where Persona.Id==Id select Persona;
            foreach (Persona persona in per)
            {
                persona.getDatos();
            }
            Console.ReadKey();
        }
            

    }
    

}
