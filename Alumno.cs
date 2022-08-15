 public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Calif { get; set; }
        public void getCalif()
        {
            Console.WriteLine("Calif: {0} con Id {1} y Nombre {2}", Calif, Id, Nombre);
        }
        public void getNombre()
        {
            Console.WriteLine("Nombre: {0} con Calif {1}", Nombre,Calif);
        }
        public void getDatos()
        {
            Console.WriteLine("Id: {0} Nombre:  {1}  Calif:{2} ", Id, Nombre, Calif);
        }
    }
