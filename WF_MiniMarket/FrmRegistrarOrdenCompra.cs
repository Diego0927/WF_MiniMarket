using CL_Capa_Datos;
using CL_Capa_Entidades;
using CL_Capa_Negocio;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarOrdenCompra : Form
    {
        public FrmRegistrarOrdenCompra()
        {
            InitializeComponent();
        }

        private void btnGuardarOrdenCompraR_Click(object sender, EventArgs e)
        {
            if (GuardarOrdenCompra())
            {
                MessageBox.Show("Registro exitoso");
            }
            else
            {
                MessageBox.Show("Fallo en la inserción");
            }
        }

        private bool GuardarOrdenCompra()
        {
            OrdenCompra objOrdenCompra = ObtenerOrdenCompraDesdeFormulario();

            if (objOrdenCompra == null)
            {
                return false;
            }

            if (VerificarUnicidadCodigoOrden(objOrdenCompra.CodigoOrden))
            {
                MessageBox.Show("El CodigoOrden ya existe en la base de datos.");
                return false;
            }

            if (!VerificarExistenciaEmpleado(objOrdenCompra.IDEmpleado))
            {
                MessageBox.Show("El empleado no existe en la base de datos.");
                return false;
            }

            if (!VerificarExistenciaProveedor(objOrdenCompra.IDProveedor))
            {
                MessageBox.Show("El proveedor no existe en la base de datos.");
                return false;
            }

            if (CN_OrdenCompra.InsertarOrdenCompra(objOrdenCompra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private OrdenCompra ObtenerOrdenCompraDesdeFormulario()
        {
            OrdenCompra objOrdenCompra = new OrdenCompra();

            if (int.TryParse(txtBoxEmpleadoOrdenCompraR.Text.Trim(), out int idEmpleado))
            {
                objOrdenCompra.IDEmpleado = idEmpleado;
            }
            else
            {
                MessageBox.Show("Valor de empleado no válido");
                return null;
            }

            if (int.TryParse(textBoxProveedorOrdenCompraR.Text.Trim(), out int idProveedor))
            {
                objOrdenCompra.IDProveedor = idProveedor;
            }
            else
            {
                MessageBox.Show("Valor de proveedor no válido");
                return null;
            }

            if (decimal.TryParse(txtBoxIVAOrdenCompraR.Text.Trim(), out decimal iva))
            {
                objOrdenCompra.IVA = iva;
            }
            else
            {
                MessageBox.Show("El valor del IVA no es válido.");
                return null;
            }

            if (decimal.TryParse(txtBoxTotalOrdenCompraR.Text.Trim(), out decimal total))
            {
                objOrdenCompra.Total = total;
            }
            else
            {
                MessageBox.Show("El valor del Total no es válido.");
                return null;
            }

            if (DateTime.TryParse(txtBoxFechaPedidoR.Text.Trim(), out DateTime fechaPedido))
            {
                objOrdenCompra.FechaPedido = fechaPedido;
            }
            else
            {
                MessageBox.Show("La fecha de pedido no es válida.");
                return null;
            }

            if (DateTime.TryParse(textBoxFechaEntregaR.Text.Trim(), out DateTime fechaEntrega))
            {
                objOrdenCompra.FechaEntrega = fechaEntrega;
            }
            else
            {
                MessageBox.Show("La fecha de entrega no es válida.");
                return null;
            }

            if (decimal.TryParse(textBoxSinIVAOrdenCompra.Text.Trim(), out decimal sinIVA))
            {
                objOrdenCompra.SinIVA = sinIVA;
            }
            else
            {
                MessageBox.Show("El valor sin IVA no es válido.");
                return null;
            }

            return objOrdenCompra;
        }

        private bool VerificarUnicidadCodigoOrden(int codigoOrden)
        {
            // Realiza una consulta en la base de datos para verificar si el CodigoOrden ya existe
            string consulta = "SELECT COUNT(*) FROM ordenCompra WHERE CodigoOrden = @CodigoOrden";

            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@CodigoOrden", codigoOrden);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si count es mayor que 0, el CodigoOrden ya existe
                    return count > 0;
                }
            }
        }


        private bool VerificarExistenciaEmpleado(int idEmpleado)
        {
            string consulta = "SELECT COUNT(*) FROM empleado WHERE IDEmpleado = @IDEmpleado";

            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@IDEmpleado", idEmpleado);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        private bool VerificarExistenciaProveedor(int idProveedor)
        {
            string consulta = "SELECT COUNT(*) FROM proveedor WHERE IDProveedor = @IDProveedor";

            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@IDProveedor", idProveedor);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }
    }
}
