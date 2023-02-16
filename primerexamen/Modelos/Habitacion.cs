using System;

namespace primerexamen.Modelos
{
    public class Habitacion
    {
        public int NumeroCuarto { get; set; }
        public double Precio { get; set; }
        public int CantidadCamas { get; set; }

        public virtual string GetTipo()
        {
            return "Habitación";
        }
    }
}
