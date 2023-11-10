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
    public class CN_Factura
    {
        public static bool ExisteFacturaConCodigo(string codigoFactura)
        {
            bool existe = false;

            // Consulta SQL para verificar la existencia de una factura con el código dado
            string consulta = "SELECT COUNT(*) FROM Factura WHERE CodigoFactura = @CodigoFactura";
            using (MySqlConnection conexion = new MySqlConnection(DA_BASE.CadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@CodigoFactura", codigoFactura);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count > 0)
                    {
                        existe = true;
                    }
                }
            }

            return existe;
        }


        public static bool InsertarFactura(Factura objFactura)
        {
            return DA_Factura.InsertarFactura(objFactura);
        }
    }
}
