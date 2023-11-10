using CL_Capa_Datos;
using CL_Capa_Entidades;
using CL_Capa_Negocio;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarDetalleCompra : Form
    {
        public FrmRegistrarDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnGuardarDetalleFacturaOrdenCompra_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int codigoDetalleOrden = ParseToInt(txtBoxDetalleOrdenR.Text.Trim());
                int cantidadProductos = ParseToInt(txtBoxCantidadProductosR.Text.Trim());
                decimal precioCompra = ParseToDecimal(textBoxPrecioDeCompraR.Text.Trim());
                decimal subtotal = ParseToDecimal(txtBoxSubtotalR.Text.Trim());
                int idOrdenCompra = ParseToInt(txtBoxOrdenDeCompra.Text.Trim());
                int idProducto = ParseToInt(textBoxProducto.Text.Trim());

                if (ExisteCodigoDetalleOrden(codigoDetalleOrden))
                {
                    MessageBox.Show("El Código de Detalle de Orden ya existe en la base de datos.");
                }
                else if (!ExisteIDOrdenCompra(idOrdenCompra))
                {
                    MessageBox.Show("El ID de Orden de Compra no existe en la base de datos.");
                }
                else if (!ExisteIDProducto(idProducto))
                {
                    MessageBox.Show("El ID de Producto no existe en la base de datos.");
                }
                else
                {
                    DetalleOrdenCompra objDetalleOrdenCompra = new DetalleOrdenCompra
                    {
                        CodigoDetalleOrden = codigoDetalleOrden,
                        CantidadProductos = cantidadProductos,
                        PrecioCompra = precioCompra,
                        Subtotal = subtotal,
                        IDOrdenCompra = idOrdenCompra,
                        IDProducto = idProducto
                    };

                    if (CN_DetalleOrdenCompra.InsertarDetalleOrdenCompra(objDetalleOrdenCompra))
                    {
                        MessageBox.Show("Registro exitoso");
                    }
                    else
                    {
                        MessageBox.Show("Fallo en la inserción");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos.");
            }
        }

        private bool ValidarCampos()
        {
            return int.TryParse(txtBoxDetalleOrdenR.Text.Trim(), out _) &&
                int.TryParse(txtBoxCantidadProductosR.Text.Trim(), out _) &&
                decimal.TryParse(textBoxPrecioDeCompraR.Text.Trim(), out _) &&
                decimal.TryParse(txtBoxSubtotalR.Text.Trim(), out _) &&
                int.TryParse(txtBoxOrdenDeCompra.Text.Trim(), out _) &&
                int.TryParse(textBoxProducto.Text.Trim(), out _);
        }

        private int ParseToInt(string value)
        {
            if (int.TryParse(value, out int result))
            {
                return result;
            }
            return 0; // Valor por defecto o manejo de error
        }

        private decimal ParseToDecimal(string value)
        {
            if (decimal.TryParse(value, out decimal result))
            {
                return result;
            }
            return 0; // Valor por defecto o manejo de error
        }

        // Métodos ExisteCodigoDetalleOrden, ExisteIDOrdenCompra y ExisteIDProducto
        public static bool ExisteCodigoDetalleOrden(int codigoDetalleOrden)
        {
            string query = $"SELECT COUNT(*) FROM DetalleOrdenCompra WHERE CodigoDetalleOrden = {codigoDetalleOrden}";

            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public static bool ExisteIDOrdenCompra(int idOrdenCompra)
        {
            string query = $"SELECT COUNT(*) FROM OrdenCompra WHERE IDOrdenCompra = {idOrdenCompra}";

            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public static bool ExisteIDProducto(int idProducto)
        {
            string query = $"SELECT COUNT(*) FROM Producto WHERE IDProducto = {idProducto}";

            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

    }
}
