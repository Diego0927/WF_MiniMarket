using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_MiniMarket : DA_BASE
    {
        public static bool InsertarMiniMarket(Minimarket objMiniMarket)
        {
            string strSQL = "Insert into minimarket (nit,razonSocial,telefono,nomenclatura,ciudad,departamento,correo,sitioWeb,facebook,whatsapp) values (";
            strSQL += "'" + objMiniMarket.Nit + "',";
            strSQL += "'" + objMiniMarket.RazonSocial + "',";
            strSQL += "'" + objMiniMarket.Telefono + "',";
            strSQL += "'" + objMiniMarket.Nomenclatura + "',";
            strSQL += "'" + objMiniMarket.Ciudad + "',";
            strSQL += "'" + objMiniMarket.Departamento + "',";
            strSQL += "'" + objMiniMarket.Correo + "',";
            strSQL += "'" + objMiniMarket.SitioWeb + "',";
            strSQL += "'" + objMiniMarket.Facebook + "',";
            strSQL += "'" + objMiniMarket.Whatsapp + "');";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable ConsultarMinimarket()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select nit,razonsocial,telefono,nomenclatura, ciudad, departamento, correo, sitioweb, facebook,whatsapp from minimarket where idMinimarket=1;";
            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarMiniMarket(Minimarket objMiniMarket)
        {
            string strSQL = "Update minimarket set ";
            strSQL += "nit = '" + objMiniMarket.Nit + "', ";
            strSQL += "razonSocial = '" + objMiniMarket.RazonSocial + "', ";
            strSQL += "telefono = '" + objMiniMarket.Telefono + "', ";
            strSQL += "nomenclatura = '" + objMiniMarket.Nomenclatura + "', ";
            strSQL += "ciudad = '" + objMiniMarket.Ciudad + "', ";
            strSQL += "departamento = '" + objMiniMarket.Departamento + "', ";
            strSQL += "correo = '" + objMiniMarket.Correo + "', ";
            strSQL += "sitioWeb = '" + objMiniMarket.SitioWeb + "', ";
            strSQL += "facebook = '" + objMiniMarket.Facebook + "', ";
            strSQL += "whatsapp = '" + objMiniMarket.Whatsapp + "' ";
            strSQL += "where idMinimarket = 1;";

            return RealizarTransaccion(strSQL);
        }
    }
}
