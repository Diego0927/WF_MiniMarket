using CL_Capa_Datos;
using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Negocio
{
    public class CN_DetalleFactura
    {
        public static bool InsertarDetalleFactura(DetalleFactura objDetalleFactura)
        {
            return DA_DetalleFactura.InsertarDetalleFactura(objDetalleFactura);
        }
    }
}
