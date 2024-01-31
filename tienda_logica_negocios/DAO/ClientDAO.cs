using System;
using tienda_logica_negocios.Entities;

namespace tienda_logica_negocios.DAO
{
    internal class ClientDAO
    {
        public int id_client { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public static void Ejecutar()
        {
            Client nuevoCliente = new Client
            {
                id_client = 11221, // Reemplaza con el valor adecuado
                nombre = "NuevoNombre",
                apellido = "NuevoApellido",
            };

            // Realizar operaciones con nuevoCliente, como inserción en la base de datos.
            Console.WriteLine("Ejecutando...");
            Console.WriteLine($"ID Cliente: {nuevoCliente.id_client}, Nombre: {nuevoCliente.nombre}, Apellido: {nuevoCliente.apellido}");
        }
    }
}
