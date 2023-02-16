using System;

namespace primerexamen.Modelos
{
    public class HabitacionSuite : Habitacion
    {
        public bool Cocina { get; set; }
        public bool Terraza { get; set; }
        public bool Jacuzzi { get; set; }

        public override string GetTipo()
        {
            return "Habitación Suite";
        }
    }
}
