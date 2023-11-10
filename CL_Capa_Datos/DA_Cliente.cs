using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Cliente : DA_BASE
    {
        public static bool InsertarCliente(Cliente objCliente)
        {
            string strSQL = "Insert into cliente (tipoDoc,identificacion,nombres,apellidos,correo,celular) values (";
            strSQL += "'" + objCliente.TipoDoc + "',";
            strSQL += "'" + objCliente.Identificacion + "',";
            strSQL += "'" + objCliente.Nombres + "',";
            strSQL += "'" + objCliente.Apellidos + "',";
            strSQL += "'" + objCliente.Correo + "',";
            strSQL += "'" + objCliente.Celular + "');";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable consultarCliente()
        {
            DataTable dt = new DataTable();
            string strSQL = "select * from cliente;";
            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarCliente(Cliente objCliente)
        {
            string strSQL = "UPDATE cliente SET ";
            strSQL += "tipoDoc = '" + objCliente.TipoDoc + "', ";
            strSQL += "nombres = '" + objCliente.Nombres + "', ";
            strSQL += "apellidos = '" + objCliente.Apellidos + "', ";
            strSQL += "correo = '" + objCliente.Correo + "', ";
            strSQL += "celular = '" + objCliente.Celular + "' ";
            strSQL += "WHERE identificacion = '" + objCliente.Identificacion + "';";

            return RealizarTransaccion(strSQL);
        }

    }
}
