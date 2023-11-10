using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Categoria : DA_BASE
    {
        public static bool InsertarCategoria(Categoria objCategoria)
        {
            string strSQL = "Insert into categoria (nombre, descripcion) values (";
            strSQL += "'" + objCategoria.Nombre + "',";
            strSQL += "'" + objCategoria.Descripcion + "');";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable consultarCategoria()
        {
            DataTable dt = new DataTable();
            string strSQL = "select * from categoria;";
            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarCategoria(Categoria objCategoria)
        {
            string strSQL = "UPDATE categoria SET ";
            strSQL += "descripcion = '" + objCategoria.Descripcion + "' ";
            strSQL += "WHERE nombre = '" + objCategoria.Nombre + "';";

            return RealizarTransaccion(strSQL);
        }

    }
}
