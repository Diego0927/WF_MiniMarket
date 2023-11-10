using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_OrdenCompra : DA_BASE
    {
        public static bool InsertarOrdenCompra(OrdenCompra objOrdenCompra)
        {
            string strSQL = "Insert into ordenCompra (codigoOrden,iva,total,fechaPedido,fechaEntrega,sinIva,idEmpleado,idProveedor) values (";
            strSQL += "'" + objOrdenCompra.CodigoOrden + "',";
            strSQL += "'" + objOrdenCompra.IVA + "',";
            strSQL += "'" + objOrdenCompra.Total + "',";
            strSQL += "'" + objOrdenCompra.FechaPedido + "',";
            strSQL += "'" + objOrdenCompra.FechaEntrega + "',";
            strSQL += "'" + objOrdenCompra.SinIVA + "',";
            strSQL += "'" + objOrdenCompra.IDEmpleado + "',";
            strSQL += "'" + objOrdenCompra.IDProveedor + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
