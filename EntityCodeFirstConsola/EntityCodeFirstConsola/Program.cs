using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirstConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicioEntities base1= new ejercicioEntities();
            {
                //Insertar
                //trabajador trabajador1 = new trabajador();
                //trabajador1.nombre = "Fernando2";
                //trabajador1.apellido_pat = "Delgadillo2";
                //trabajador1.apellido_mat = "Torres2";
                //trabajador1.direccion = "CDMX";
                //trabajador1.telefono = "551111";
                //base1.trabajador.Add(trabajador1);
                //base1.SaveChanges();
                //-----------
                //Borrar
                //trabajador trabajador2 = base1.trabajador.Find(11);
                //base1.trabajador.Remove(trabajador2);
                //base1.SaveChanges();
                //-----
                //Actualizar
                // trabajador trabajador3 = base1.trabajador.Where(d => d.nombre == "Fernando2").First();
                //// trabajador trabajador3 = base1.trabajador.Find(6);
                // trabajador3.apellido_pat = "Cortez";
                // base1.Entry(trabajador3).State = System.Data.Entity.EntityState.Modified;
                // base1.SaveChanges();
                ////Consultar
                var lista = base1.trabajador;
                foreach (var t1 in lista)
                {
                    Console.WriteLine(t1.id_trabajador + " - " + t1.nombre + "  -  " + t1.apellido_pat);
                }
                Console.ReadKey();
            }
        }
    }
}
