using System;

namespace tienda_logica_negocios.DAO
{
    public class FactureDAO
    {
        public string id_factura { get; set; }
        public string est_factura { get; set; }
        public DateTime fec_factura { get; set; }
        public int num_factura { get; set; }
        public string fac_factura { get; set; }
        public int cliente_id { get; set; }
        public int empleado_id { get; set; }

        public static void Ejecutar()
        {
            FactureDAO nuevoArticulo = new FactureDAO
            {
                id_factura = "NuevoEstado",
                est_factura = "NuevoEstado",
                fec_factura = DateTime.Now,
                num_factura = 123,
                fac_factura = "NuevaFactura",
                cliente_id = 1,
                empleado_id = 1
            };

            // Realizar operaciones con nuevoArticulo, como insertar en la base de datos.
        }
    }
}