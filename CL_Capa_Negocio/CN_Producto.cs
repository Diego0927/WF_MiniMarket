using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Capa_Datos;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CL_Capa_Negocio
{
    public class CN_Producto
    {
        public static bool InsertarProducto(Producto objProducto)
        {
            return DA_Producto.InsertarProducto(objProducto);
        }
    }
}
