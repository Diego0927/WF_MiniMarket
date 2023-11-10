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
    public class CN_Cliente
    {
        public static bool InsertarCliente(Cliente objCliente)
        {
            return DA_Cliente.InsertarCliente(objCliente);
        }

        public static bool ActualizarCliente(Cliente objCliente)
        {
            return DA_Cliente.ActualizarCliente(objCliente);
        }

        public static DataTable ConsultarCliente()
        {
            return DA_Cliente.consultarCliente();
        }
    }
}
