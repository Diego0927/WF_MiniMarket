using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class OrdenCompra
    {
        public int IDOrdenCompra { get; set; }
        public int CodigoOrden { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal SinIVA { get; set; }
        public int IDEmpleado { get; set; }
        public int IDProveedor { get; set; }
    }
}
