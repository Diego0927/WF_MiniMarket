using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_DetalleFactura : DA_BASE
    {
        public static bool InsertarDetalleFactura(DetalleFactura objDetalleFactura)
        {
            string strSQL = "Insert into detalleFactura (cantidadProductos,precioUnitario,subtotal,idFactura,idProducto) values (";
            strSQL += "'" + objDetalleFactura.CantidadProductos + "',";
            strSQL += "'" + objDetalleFactura.PrecioUnitario + "',";
            strSQL += "'" + objDetalleFactura.Subtotal + "',";
            strSQL += "'" + objDetalleFactura.IDFactura + "',";
            strSQL += "'" + objDetalleFactura.IDProducto + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
