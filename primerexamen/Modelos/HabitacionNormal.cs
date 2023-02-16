using System;

namespace primerexamen.Modelos
{
    public class HabitacionNormal : Habitacion
    {
        public string Ducha { get; set; }
        public bool Microondas { get; set; }
        public bool Ventanas { get; set; }

        public override string GetTipo()
        {
            return "Habitación Normal";
        }
    }
}
