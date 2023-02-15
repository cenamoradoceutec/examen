using primerexamen.Modelos;
using System;
using System.Collections.Generic;

Hotel hotel = new Hotel();

Console.WriteLine("Se registraran Los clientes");
Cliente cliente1 = new ClienteVIP { Nombre = "Juan", Apellido = "Perez", TipoCliente = "VIP", Descuento = 0.10 };
Cliente cliente2 = new Cliente { Nombre = "María", Apellido = "Rodriguez", TipoCliente = "Normal" };

Console.WriteLine("Cliente registrado con éxito. Nombre: " + cliente1.Nombre + " " + cliente1.Apellido + " Tipo: " + cliente1.TipoCliente);
Console.WriteLine("Cliente registrado con éxito. Nombre: " + cliente2.Nombre + " " + cliente2.Apellido + " Tipo: " + cliente2.TipoCliente);
Console.WriteLine("=================================================");


HabitacionSencilla habitacionSencilla = new HabitacionSencilla { Numero = 101 };
HabitacionDoble habitacionDoble = new HabitacionDoble { Numero = 201 };
Suite suite = new Suite { Numero = 301, NivelLujos = 5 };
Console.WriteLine("Se registraron Las Habitaciones");
Console.WriteLine("=================================================");

Console.WriteLine("Se registraran los clientes en sus Habitaciones");
hotel.RegistrarClienteHabitacion(cliente1, habitacionSencilla);
Console.WriteLine("***" + cliente1.Nombre+" "+cliente1.Apellido+ " Se Registro en la Habitacion: " +habitacionSencilla.Numero);
hotel.RegistrarClienteHabitacion(cliente2, habitacionDoble);
Console.WriteLine("***" + cliente2.Nombre+" "+cliente2.Apellido + " Se Registro en la Habitacion: " + habitacionDoble.Numero);
hotel.RegistrarClienteHabitacion(cliente1, suite);
Console.WriteLine("***" + cliente1.Nombre+" "+cliente1.Apellido + " Se Registro en la Habitacion: " + suite.Numero);

Console.WriteLine("=================================================");

Console.WriteLine("Se Mostraran el Historial de los Clientes");

Console.WriteLine("=================================================");
Console.WriteLine("Historial de Habitaciones de " + cliente1.Nombre + " " + cliente1.Apellido + ":");
Console.WriteLine("=================================================");
foreach (var habitacion in cliente1.HistorialHabitaciones)
{
    Console.WriteLine("Hubo un registro:");
    Console.WriteLine("- Número de Habitación: " + habitacion.Numero);
    Console.WriteLine("- Tipo de Habitación: " + habitacion.GetType().Name);
}

Console.WriteLine("=================================================");
Console.WriteLine("Historial de Habitaciones de " + cliente2.Nombre + " " + cliente2.Apellido + ":");
Console.WriteLine("=================================================");
foreach (var habitacion in cliente2.HistorialHabitaciones)
{
    Console.WriteLine("Hubo un registro:");
    Console.WriteLine("- Número de Habitación: " + habitacion.Numero);
    Console.WriteLine("- Tipo de Habitación: " + habitacion.GetType().Name);
}

Console.ReadKey();