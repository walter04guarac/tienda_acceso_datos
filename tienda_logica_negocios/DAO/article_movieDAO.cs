using System;

namespace MyApp.DataAccess.DAO
{
    public class ArticleMovieDAO
    {
        public string idPelicula { get; set; }
        public string Nombre { get; set; }
        public int Descripcion { get; set; }
        public string fac_factura { get; set; }
        public int cliente_id { get; set; }
        public int empleado_id { get; set; }

        public static void Ejecutar()
        {
            ArticleMovieDAO nuevoArticulo = new ArticleMovieDAO
            {
                idPelicula = "NuevoEstado",
                Nombre = DateTime.Now.ToString(), // Asumiendo que 'Nombre' es una cadena para representar la fecha
                Descripcion = 123,
                fac_factura = "NuevaFactura",
                cliente_id = 1,
                empleado_id = 1
            };

            // Realizar operaciones con nuevoArticulo, como inserción en la base de datos.
            Console.WriteLine("Ejecutando...");
            Console.WriteLine($"ID Película: {nuevoArticulo.idPelicula}, Nombre: {nuevoArticulo.Nombre}, Descripción: {nuevoArticulo.Descripcion}, Factura: {nuevoArticulo.fac_factura}, Cliente ID: {nuevoArticulo.cliente_id}, Empleado ID: {nuevoArticulo.empleado_id}");
        }
    }
}