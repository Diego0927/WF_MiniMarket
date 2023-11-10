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
    public class CN_MiniMarket
    {
        public static bool InsertarMiniMarket(Minimarket objMiniMarket)
        {
            return DA_MiniMarket.InsertarMiniMarket(objMiniMarket);
        }

        public static bool ActualizarMiniMarket(Minimarket objMiniMarket)
        {
            return DA_MiniMarket.ActualizarMiniMarket(objMiniMarket);
        }

        public static DataTable ConsultarMiniMarket()
        {
            return DA_MiniMarket.ConsultarMinimarket();
        }
    }
}
