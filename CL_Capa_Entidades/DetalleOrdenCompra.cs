using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class DetalleOrdenCompra
    {
        public int IDDetalleOrden { get; set; }
        public int CodigoDetalleOrden { get; set; }
        public int CantidadProductos { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Subtotal { get; set; }
        public int IDOrdenCompra { get; set; }
        public int IDProducto { get; set; }
    }
}
