using System;

namespace primerexamen.Modelos
{
    public class Hotel
    {
        public List<IRegistrable> Registros { get; set; } = new List<IRegistrable>();

        public void Registrar(IRegistrable registro)
        {
            Registros.Add(registro);
            registro.Registrar();
        }

        public void RegistrarClienteHabitacion(Cliente cliente, Habitacion habitacion)
        {
            cliente.HistorialHabitaciones.Add(habitacion);
            //Console.WriteLine("Cliente y Habitación registrados con éxito.");
        }
    }
}
