using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ4
{
    public class Trabajador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public int Sueldo { get; set; }
        public string Puesto { get; set; }
        public int getId()
        {
            return Id;
        }
        public string getNombre()
        {
            return Nombre;
        }        
        public string getApellidoPat()
        {
            return ApellidoPat;
        }
        public string getApellidoMat()
        {
            return ApellidoMat;
        }
        public int getSueldo()
        {
            return Id;
        }
        public string getPuesto()
        {
            return Puesto;
        }
        public string getDatos(int id)
        {
            string Datos = Convert.ToString("Id:{0} ");
                //"Nombre:{1} ApellidoPaterno:{2} ApellidoMaterno:{3} Sueldo:{4} Puesto:{5} ",Id,Nombre,ApellidoPat,ApellidoMat,Sueldo,Puesto);
            //Console.WriteLine("Id:{0} Nombre:{1} ApellidoPaterno:{2} ApellidoMaterno:{3} Sueldo:{4} Puesto:{5} ", Id, Nombre, ApellidoPat, ApellidoMat, Sueldo, Puesto);
           return Datos;
        }
    }
}
