using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Capa_Datos;
using System.Data;

namespace CL_Capa_Negocio
{
    public class CN_Categoria
    {
        public static bool InsertarCategoria(Categoria objCategoria)
        {
            return DA_Categoria.InsertarCategoria(objCategoria);
        }

        public static bool ActualizarCategoria(Categoria objCategoria)
        {
            return DA_Categoria.ActualizarCategoria(objCategoria);
        }

        public static DataTable ConsultarCategoria()
        {
            return DA_Categoria.consultarCategoria();
        }
    }
}
