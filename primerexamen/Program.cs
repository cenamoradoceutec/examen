using primerexamen.Modelos;
using System;
using System.Collections.Generic;



Hotel hotel = new Hotel();

HabitacionNormal habitacionNormal = new HabitacionNormal
{
    NumeroCuarto = 101,
    Precio = 50.00,
    CantidadCamas = 2,
    Ducha = "Sí",
    Microondas = true,
    Ventanas = true
};

HabitacionSuite habitacionSuite = new HabitacionSuite
{
    NumeroCuarto = 201,
    Precio = 100.00,
    CantidadCamas = 1,
    Cocina = true,
    Terraza = true,
    Jacuzzi = true
};

hotel.RegistrarHabitacion(habitacionNormal);
hotel.RegistrarHabitacion(habitacionSuite);

ClienteVIP clienteVIP = new ClienteVIP("Juan Pérez");
ClienteNormal clienteNormal = new ClienteNormal("María González");

hotel.RegistrarCliente(clienteVIP, habitacionSuite);
hotel.RegistrarCliente(clienteNormal, habitacionNormal);
hotel.RegistrarCliente(clienteVIP, habitacionNormal);

Console.WriteLine("Habitaciones registradas en el hotel:");
foreach (Habitacion habitacion in hotel.Habitaciones)
{
    Console.WriteLine("{0}: {1}, precio: {2:C}, camas: {3}", habitacion.GetTipo(), habitacion.NumeroCuarto, habitacion.Precio, habitacion.CantidadCamas);
}

Console.WriteLine("\nClientes registrados en el hotel:");
foreach (Registro registro in hotel.Registros)
{
    Console.WriteLine("{0} ({1}) ha registrado la habitación {2} el {3}", registro.Cliente.NombreCompleto, registro.Cliente.Tipo.Tipo, registro.Habitacion.NumeroCuarto, registro.Fecha.ToString("dd/MM/yyyy"));
}

Console.ReadLine();