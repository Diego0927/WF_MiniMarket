using CL_Capa_Datos;
using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Negocio
{
    public class CN_DetalleOrdenCompra
    {
        public static bool InsertarDetalleOrdenCompra(DetalleOrdenCompra objDetalleOrdenCompra)
        {
            return DA_DetalleOrdenCompra.InsertarDetalleOrdenCompra(objDetalleOrdenCompra);
        }
    }
}
