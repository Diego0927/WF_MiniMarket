using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class DetalleFactura
    {
        public int IDDetalleFactura { get; set; }
        public int CantidadProductos { get; set; }
        public int PrecioUnitario { get; set; }
        public int Subtotal { get; set; }
        public int IDFactura { get; set; }
        public int IDProducto { get; set; }
    }
}
