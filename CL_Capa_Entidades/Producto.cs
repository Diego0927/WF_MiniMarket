using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Producto
    {
        public int IDProducto { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Stock { get; set; }
        public int PVP { get; set; }
        public string Descripcion { get; set; }
        public string UnidadDeMedida { get; set; }
        public int IDCategoria { get; set; }
    }
}
