using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Factura
    {
        public int IDFactura { get; set; }
        public string CodigoFactura { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public int IVA { get; set; }
        public int SinIVA { get; set; }
        public int Total { get; set; }
        public int IDEmpleado { get; set; }
        public int IDCliente { get; set; }
    }
}
