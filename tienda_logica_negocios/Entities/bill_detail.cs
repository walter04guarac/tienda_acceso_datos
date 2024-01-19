using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda_logica_negocios.Entities
{
    internal class bill_detail
    {
        private int idDetailFacture {  get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
        public int Movie_IdMovie { get; set;}
        public int movieCategoryIdCategory { get; set; }
        public int factureIdfacture { get; set; }
        public int facturaCliente_idCliente { get; set; }


    }
}
