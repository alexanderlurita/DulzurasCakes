using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EntVenta
    {
        public int idventa { get; set; }
        public int idpersona { get; set; }
        public int idempresa { get; set; }
        public int idusuario { get; set; }
        public int idtipopago { get; set; }
        public string tipodocumento { get; set; }
        public string nrodocumento { get; set; }
        public DateTime fechaventa { get; set; }
    }
}
