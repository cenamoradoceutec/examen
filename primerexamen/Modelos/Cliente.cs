using System;

namespace primerexamen.Modelos
{
    public class Cliente : IRegistrable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoCliente { get; set; }

        public List<Habitacion> HistorialHabitaciones { get; set; } = new List<Habitacion>();

        public virtual double ObtenerDescuento()
        {
            return 0;
        }

        public void Registrar()
        {
            Console.WriteLine("Cliente registrado con éxito. Nombre: " + Nombre + " " + Apellido + " Tipo: " + TipoCliente);
        }

        public void MostrarHistorialHabitaciones()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Historial de Habitaciones de " + Nombre + " " + Apellido + ":");
            Console.WriteLine("=================================================");
            foreach (var habitacion in HistorialHabitaciones)
            {
                Console.WriteLine("Hubo un registro:");
                Console.WriteLine("- Número de Habitación: " + habitacion.Numero);
                Console.WriteLine("- Tipo de Habitación: " + habitacion.GetType().Name);
            }
        }
    }
}
