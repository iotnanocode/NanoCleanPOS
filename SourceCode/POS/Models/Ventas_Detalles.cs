using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class Ventas_Detalles
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string FK_Venta { get; set; }
        public string FK_Producto { get; set; }
        public string Descripcion { get; set; }
        public float Cantidad { get; set; }
        public string FK_Unidad { get; set; }
        public float Precio { get; set; }
    }
}
