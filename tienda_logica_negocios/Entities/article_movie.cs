using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda_logica_negocios.Entities
{
    internal class article_movie
    {
        private int idMovie { get; set; } 
        public string nombre { get; set; }
        public int codigo { get; set; }
        public int descripcion { get; set;}
        public string estado { get; set;}
        public string categoria_idCategoria {  get; set; }

    }
}
