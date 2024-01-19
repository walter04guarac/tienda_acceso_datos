using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda_logica_negocios.Entities
{
    internal class Facture_form_pay
    {
        private int idFactura_formaPago { get; set; }
        public int factura_idFactura { get; set; }
        public int factura_cliente_idCliente { get; set; }
        public int formaPago_idFormaPago {get; set;} 

    }
}
