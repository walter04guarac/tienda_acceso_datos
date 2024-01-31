using System;

namespace tienda_logica_negocios.DAO
{
    public class facture_from_payDAO
    {
        public string id_factura_formaPago { get; set; }
        public string factura_idFactura { get; set; }
        public DateTime factura_cliente_idCliente { get; set; }
        public int formaPago_idFormaPago { get; set; }
        public static void Ejecutar()
        {
            facture_from_payDAO nuevoArticulo = new facture_from_payDAO
            {
                id_factura_formaPago = "NuevoEstado",
                factura_idFactura = "NuevoEstado",
                factura_cliente_idCliente = DateTime.Now,
                formaPago_idFormaPago = 123,

                // Realizar operaciones con nuevoArticulo, como insertar en la base de datos.
            };
        }
    }
}