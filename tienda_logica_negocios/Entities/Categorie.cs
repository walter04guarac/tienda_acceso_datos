using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda_logica_negocios.Entities
{
    internal class Categorie
    {
        private int idCategoria { get; set; }
        public string Estado { get; set; }
        public int codigo_categoria { get; set; }
        public int descripcionCategoria { get; set; }
    }
}
