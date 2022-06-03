using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class Producto
    {
        public string ID { get; set; }
        public string FK_Licencia { get; set; }
        public string FK_Categoria { get; set; }

        public string UPC { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public float Costo { get; set; }
        public float Precio { get; set; }
        public string FK_Envase { get; set; }
        public string FK_Unidad { get; set; }
        public int Activa { get; set; }

    }
}
