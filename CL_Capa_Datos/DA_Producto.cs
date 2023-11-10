using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Producto : DA_BASE
    {
        public static bool InsertarProducto(Producto objProducto)
        {
            string strSQL = "Insert into producto (nombre,marca,stock,pvp,descripcion,unidadMedida,idCategoria) values (";
            strSQL += "'" + objProducto.Nombre + "',";
            strSQL += "'" + objProducto.Marca + "',";
            strSQL += "'" + objProducto.Stock + "',";
            strSQL += "'" + objProducto.PVP + "',";
            strSQL += "'" + objProducto.Descripcion + "',";
            strSQL += "'" + objProducto.UnidadDeMedida + "',";
            strSQL += "'" + objProducto.IDCategoria + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
