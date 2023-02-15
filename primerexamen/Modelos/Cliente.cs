using System;

namespace primerexamen.Modelos
{
    public class Cliente 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoCliente { get; set; }

        public List<Habitacion> HistorialHabitaciones { get; set; } = new List<Habitacion>();

        public virtual double ObtenerDescuento()
        {
            return 0;
        }

    }
}
