using System;

namespace tienda_logica_negocios.DAO
{
    internal class AdminEmployeeDAO
    {
        public int IdAdmin { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }


        public static void Ejecutar()
        {
            AdminEmployeeDAO nuevoAdmin = new AdminEmployeeDAO
            {
                IdAdmin = 1, // Reemplaza con el valor adecuado
                Nombre = "NuevoNombre",
                Cargo = "NuevoCargo",

            };

            // Realizar operaciones con nuevoAdmin, como inserción en la base de datos.
            Console.WriteLine("Ejecutando...");
            Console.WriteLine($"ID Admin: {nuevoAdmin.IdAdmin}, Nombre: {nuevoAdmin.Nombre}, Cargo: {nuevoAdmin.Cargo}");
        }
    }
}