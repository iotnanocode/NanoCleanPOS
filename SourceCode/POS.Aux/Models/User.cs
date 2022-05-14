using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Aux.Models
{
    public class User
    {
        public string ID { get; set; }
        public string FK_Licencia { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Pwd { get; set; }
        public string FK_Tienda { get; set; }
        public int isAdmin { get; set; }
        public int Activa { get; set; }
    }
}
