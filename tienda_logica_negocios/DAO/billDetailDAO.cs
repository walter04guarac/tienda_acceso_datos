using System;
using tienda_logica_negocios.Entities;

namespace tienda_logica_negocios.DAO
{
    internal class billDetailDAO
    {
        public int IdDetailFacture { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
        public int Movie_IdMovie { get; set; }
        public int MovieCategoryIdCategory { get; set; }
        public int FactureIdFacture { get; set; }
        public int FactureCliente_IdCliente { get; set; }

        public static void Ejecutar()
        {
            billDetailDAO nuevoDetalleFactura = new billDetailDAO
            {
                IdDetailFacture = 1, // Reemplaza con el valor adecuado
                Cantidad = 5, // Reemplaza con el valor adecuado
                Observacion = "NuevaObservacion",
                Movie_IdMovie = 2, // Reemplaza con el valor adecuado
                MovieCategoryIdCategory = 3, // Reemplaza con el valor adecuado
                FactureIdFacture = 4, // Reemplaza con el valor adecuado
                FactureCliente_IdCliente = 1 // Reemplaza con el valor adecuado
            };

            // Realizar operaciones con nuevoDetalleFactura, como inserción en la base de datos.
            Console.WriteLine("Ejecutando...");
            Console.WriteLine($"ID Detalle Factura: {nuevoDetalleFactura.IdDetailFacture}, Cantidad: {nuevoDetalleFactura.Cantidad}, Observacion: {nuevoDetalleFactura.Observacion}, " +
                              $"ID Película: {nuevoDetalleFactura.Movie_IdMovie}, ID Categoría Película: {nuevoDetalleFactura.MovieCategoryIdCategory}, " +
                              $"ID Factura: {nuevoDetalleFactura.FactureIdFacture}, ID Cliente Factura: {nuevoDetalleFactura.FactureCliente_IdCliente}");
        }
    }

