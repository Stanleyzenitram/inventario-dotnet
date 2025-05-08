using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario.Models
{
    class ClienteRequest
    {
        public int codcli { get; set; }
        public string nomcli { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }

        public bool status { get; set; }
    }
}
