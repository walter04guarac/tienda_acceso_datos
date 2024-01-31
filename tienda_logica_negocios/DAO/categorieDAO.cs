using System;
using tienda_logica_negocios.Entities;

namespace tienda_logica_negocios.DAO
{
    internal class CategorieDAO
    {
        public int IdCategoria { get; set; }
        public string estado { get; set; }
        public string codigo_categoria { get; set; }
        public string descripcionCategoria { get; set; }

        public static void Ejecutar()
        {
            Categorie nuevaCategoria = new Categorie
            {
                IdCategoria = 1, // Reemplaza con el valor adecuado
                Estado = "NuevoEstado",
                codigo_categoria = 66443,
                descripcionCategoria = 65545,
            };

            // Realizar operaciones con nuevaCategoria, como inserción en la base de datos.
            Console.WriteLine("Ejecutando...");
            Console.WriteLine($"ID Categoría: {nuevaCategoria.IdCategoria}, Estado: {nuevaCategoria.Estado}, Código: {nuevaCategoria.codigo_categoria}, Descripción: {nuevaCategoria.descripcionCategoria}");
        }
    }
}