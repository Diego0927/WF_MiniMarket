using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Factura : DA_BASE
    {
        public static bool InsertarFactura(Factura objFactura)
        {
            string strSQL = "Insert into factura (codigoFactura,fechaGeneracion,iva,sinIva,total,idEmpleado,idCliente) values (";
            strSQL += "'" + objFactura.CodigoFactura + "',";
            strSQL += "'" + objFactura.FechaGeneracion + "',";
            strSQL += "'" + objFactura.IVA + "',";
            strSQL += "'" + objFactura.SinIVA + "',";
            strSQL += "'" + objFactura.Total + "',";
            strSQL += "'" + objFactura.IDEmpleado + "',";
            strSQL += "'" + objFactura.IDCliente + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
