using System;

namespace primerexamen.Modelos
{
    public class Habitacion : IRegistrable
    {
        public int Numero { get; set; }

        public void Registrar()
        {
            Console.WriteLine("Habitación registrada con éxito. Número: " + Numero);
        }
    }
}
