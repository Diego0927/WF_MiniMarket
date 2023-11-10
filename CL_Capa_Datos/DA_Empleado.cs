using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Empleado : DA_BASE
    {
        public static bool InsertarEmpleado(Empleado objEmpleado)
        {
            string strSQL = "Insert into empleado (tipoDoc,identificacion,nombres,apellidos,correo,celular,clave,idMinimarket) values (";
            strSQL += "'" + objEmpleado.TipoDoc + "',";
            strSQL += "'" + objEmpleado.Identificacion + "',";
            strSQL += "'" + objEmpleado.Nombres + "',";
            strSQL += "'" + objEmpleado.Apellidos + "',";
            strSQL += "'" + objEmpleado.Correo + "',";
            strSQL += "'" + objEmpleado.Celular + "',";
            strSQL += "'" + objEmpleado.Clave + "',";
            strSQL += "'" + objEmpleado.IDMiniMarket + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
