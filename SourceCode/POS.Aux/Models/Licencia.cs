using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Aux.Models
{
    public class Licencia
    {
        public string ID { get; set; } = "";
        public string Nombre { get; set; } = "";
        public DateTime Vigencia { get; set; }
    }
}
