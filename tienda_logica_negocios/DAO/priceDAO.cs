using System;
using System.Diagnostics;
using tienda_logica_negocios.Entities;

namespace tienda_logica_negocios.DAO
{
    internal class PriceDAO
    {
        public int IdPrecio { get; set; }
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }

        public static void Ejecutar()
        {
            PriceDAO nuevoPrecio = new PriceDAO
            {
                IdPrecio = 1, // Reemplaza con el valor adecuado
                Valor = 99.99M, // Reemplaza con el valor adecuado
                Fecha = DateTime.Now, // Puedes ajustar la fecha según tus necesidades
            };

            // Realizar operaciones con nuevoPrecio, como inserción en la base de datos.
            Console.WriteLine("Ejecutando...");
            Console.WriteLine($"ID Precio: {nuevoPrecio.IdPrecio}, Valor: {nuevoPrecio.Valor}, Fecha: {nuevoPrecio.Fecha}");
        }
    }
}
