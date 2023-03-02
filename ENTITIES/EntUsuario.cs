using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EntUsuario
    {
        public int idusuario { get; set; }
        public int idpersona { get; set; }
        public int idrol { get; set; }
        public string nombreusuario { get; set; }
        public string claveacceso { get; set; }
        public DateTime fechaalta { get; set; }
        public DateTime fechabaja { get; set; }
        public bool estado { get; set; }
    }
}
