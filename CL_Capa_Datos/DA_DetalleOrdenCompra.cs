using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_DetalleOrdenCompra : DA_BASE
    {
        public static bool InsertarDetalleOrdenCompra(DetalleOrdenCompra objDetalleOrdenCompra)
        {
            string strSQL = "Insert into detalleDetalleOrdenCompra (codigoDetalleOrden,cantidadProductos,precioCompra,subtotal,idOrdenCompra,idProducto) values (";
            strSQL += "'" + objDetalleOrdenCompra.CodigoDetalleOrden + "',";
            strSQL += "'" + objDetalleOrdenCompra.CantidadProductos + "',";
            strSQL += "'" + objDetalleOrdenCompra.PrecioCompra + "',";
            strSQL += "'" + objDetalleOrdenCompra.Subtotal + "',";
            strSQL += "'" + objDetalleOrdenCompra.IDOrdenCompra + "',";
            strSQL += "'" + objDetalleOrdenCompra.IDProducto + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
