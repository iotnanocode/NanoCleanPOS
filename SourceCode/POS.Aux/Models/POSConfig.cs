using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Aux.Models
{
    public class POSConfig
    {
        private bool isOchoMM1;

        public string ID { get; set; }
        public string FK_Licencia { get; set; }
        public string FK_Tienda { get; set; }
        public string FK_Almacen { get; set; }
        public int OchoMM { get; set; }
        public int PermiteTeclado { get; set; }
        public int PermiteAgregarProductos { get; set; }
        public int PermiteOtrosMetodosPago { get; set; }
        public byte[] FondoPantalla { get; set; }
        public byte[] MembreteTicket { get; set; }
        public string LastSync { get; set; }
    }
}
