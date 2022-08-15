using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlAlumnos con1 = new ControlAlumnos();
            con1.getNombres();
           
        }
    }
    class ControlAlumnos
    {
       
        public void getNombres() {
            var lista = new List<Alumno> { new Alumno { Id = 0, Nombre = "Pedro",Calif = 5},
                                            new Alumno {Id=1,Nombre = "Jorge",Calif = 8},
                                            new Alumno {Id=2, Nombre = "Andres",Calif = 3},
                                            new Alumno {Id=3, Nombre = "Sandra",Calif = 6},
                                            new Alumno {Id=4, Nombre = "Jaime",Calif = 10}
                                          };

            var nombresAlumnos = lista.Select(x => x.Nombre).ToList();
            Console.WriteLine("Lista Nombres:");
            foreach (string alumno in nombresAlumnos)
            {
                Console.WriteLine(alumno);
            }
            //----------------
            /*
                var alumnosAprobados = lista.Where(x => x.Calif > 5).ToList();
                Console.WriteLine("Lista Aprobados:");
                foreach (Alumno alumno2 in alumnosAprobados)
                {
                    alumno2.getCalif();
                }
             //----------------
                var primero = lista.First();
                Console.WriteLine("Primero:");
                primero.getDatos();           
                var ultimo = lista.Last();
                Console.WriteLine("Ultimo:");
                ultimo.getDatos();
            //----------------
                var ordenadoMayorAMenos = lista.OrderByDescending(x => x.Calif).ToList();
                Console.WriteLine("Lista OrdenadosMayorAMenor:");
                foreach (Alumno alumno3 in ordenadoMayorAMenos)
                {
                    alumno3.getDatos();
                }  
                var ordenadoMenorAMayor = lista.OrderBy(x => x.Calif).ToList();
                Console.WriteLine("Lista OrdenadosMenorAMayor:");
                foreach (Alumno alumno4 in ordenadoMenorAMayor)
                {
                    alumno4.getDatos();
                }
             //----------------
                var sumaCalif = lista.Sum(x => x.Calif);
                Console.WriteLine("SumaCalif:{0}", sumaCalif);
                var califMax = lista.Max(x => x.Calif);
                Console.WriteLine("CalifMax:{0}", califMax);
                var califMin = lista.Min(x => x.Calif);
                Console.WriteLine("CalifMin:{0}", califMin);
                var media = lista.Average(x => x.Calif);
                Console.WriteLine("Media:{0}", media);
                var todosAprobados = lista.All(x => x.Calif > 5);
                Console.WriteLine("TodosAprobados:{0}",todosAprobados);          
                var algunAprobado = lista.Any(x => x.Calif >= 5);
                Console.WriteLine("Algun Aprobados:{0}", algunAprobado);

               */
            Console.ReadKey();
        } 
    }
}
