using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EntProducto
    {
        public int idproducto { get; set; }
        public int idcategoria { get; set; }
        public string nombreproducto { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaelaboracion { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public bool estado { get; set; }
    }
}
