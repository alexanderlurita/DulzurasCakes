﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EntPersona
    {
        public int idpersona { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
    }
}
