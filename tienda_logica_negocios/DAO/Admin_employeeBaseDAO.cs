using System;
using tienda_logica_negocios.Entities;

namespace tienda_logica_negocios.DAO
{
    internal class AdminEmployeeBaseDAO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public static void Ejecutar()
        {
            Admin_employeeBase nuevoAdminBase = new Admin_employeeBase
            {
                Id = 1, // Reemplaza con el valor adecuado
                Nombre = "NuevoNombre",
                Cargo = "NuevoCargo"
            };

            // Realizar operaciones con nuevoAdminBase, como inserción en la base de datos.
            Console.WriteLine("Ejecutando...");
            Console.WriteLine($"ID Admin Base: {nuevoAdminBase.Id}, Nombre: {nuevoAdminBase.Nombre}, Cargo: {nuevoAdminBase.Cargo}");
        }
    }
}