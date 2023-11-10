using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Proveedor : DA_BASE
    {
        public static bool InsertarProveedor(Proveedor objProveedor)
        {
            string strSQL = "Insert into proveedor (nit,razonSocial,telefono,correo,nomenclatura,ciudad,departamento) values (";
            strSQL += "'" + objProveedor.Nit + "',";
            strSQL += "'" + objProveedor.RazonSocial + "',";
            strSQL += "'" + objProveedor.Telefono + "',";
            strSQL += "'" + objProveedor.Correo + "',";
            strSQL += "'" + objProveedor.Nomenclatura + "',";
            strSQL += "'" + objProveedor.Ciudad + "',";
            strSQL += "'" + objProveedor.Departamento + "');";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable consultarProveedores()
        {
            DataTable dt = new DataTable();
            string strSQL = "select * from proveedor;";
            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarProveedor(Proveedor objProveedor)
        {
            string strSQL = "UPDATE proveedor SET ";
            strSQL += "razonSocial = '" + objProveedor.RazonSocial + "',";
            strSQL += "telefono = '" + objProveedor.Telefono + "',";
            strSQL += "correo = '" + objProveedor.Correo + "',";
            strSQL += "nomenclatura = '" + objProveedor.Nomenclatura + "',";
            strSQL += "ciudad = '" + objProveedor.Ciudad + "',";
            strSQL += "departamento = '" + objProveedor.Departamento + "'";
            strSQL += "WHERE nit = '" + objProveedor.Nit + "';";

            return RealizarTransaccion(strSQL);
        }

    }
}
