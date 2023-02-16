using System;

namespace primerexamen.Modelos
{
    public class Cliente
    {
        public string NombreCompleto { get; set; }
        public TipoCliente Tipo { get; set; }
        public List<Habitacion> HabitacionesRegistradas { get; set; }

        public Cliente(string nombreCompleto, TipoCliente tipo)
        {
            NombreCompleto = nombreCompleto;
            Tipo = tipo;
            HabitacionesRegistradas = new List<Habitacion>();
        }
    }

    public class ClienteNormal : Cliente
    {
        public ClienteNormal(string nombreCompleto) : base(nombreCompleto, new TipoCliente { Tipo = "Normal" })
        {
        }
    }

    public class ClienteVIP : Cliente
    {
        public ClienteVIP(string nombreCompleto) : base(nombreCompleto, new TipoCliente { Tipo = "VIP" })
        {
        }
    }
}
