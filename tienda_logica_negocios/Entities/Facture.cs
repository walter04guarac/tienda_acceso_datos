using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda_logica_negocios.Entities
{
    internal class Facture
    {
        private int id_factura { get; set; }
        public string Estado { get; set; }
        public string fecha { get; set; }
        public string numero_factura { get; set; }
        public string ciente_idCliente { get; set; }
        public string empleado_idEmpleado {  get; set; }

    }
}
