using System;

namespace primerexamen.Modelos
{
    public class ClienteVIP : Cliente
    {
        public double Descuento { get; set; }

        public override double ObtenerDescuento()
        {
            return Descuento;
        }
    }
}
