using CL_Capa_Datos;
using CL_Capa_Entidades;
using CL_Capa_Negocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarDetalleFactura : Form
    {
        public FrmRegistrarDetalleFactura()
        {
            InitializeComponent();
        }

        private void btnGuardarDetalleFacturaR_Click(object sender, EventArgs e)
        {
            DetalleFactura ObjDetalleFactura = new DetalleFactura();

            // Obtener los valores de los cuadros de texto
            if (int.TryParse(txtBoxCantidadProductosR.Text.Trim(), out int cantidadProductos) &&
                int.TryParse(txtBoxPrecioUnitarioR.Text.Trim(), out int precioUnitario))
            {
                // Verificar si IDFactura existe en la tabla Factura
                if (int.TryParse(txtBoxFacturaR.Text.Trim(), out int idFactura) &&
                    FacturaExists(idFactura))
                {
                    // Verificar si IDProducto existe en la tabla Producto
                    if (int.TryParse(textBoxProductoR.Text.Trim(), out int idProducto) &&
                        ProductoExists(idProducto))
                    {
                        ObjDetalleFactura.CantidadProductos = cantidadProductos;
                        ObjDetalleFactura.PrecioUnitario = precioUnitario;
                        ObjDetalleFactura.Subtotal = cantidadProductos * precioUnitario;
                        ObjDetalleFactura.IDFactura = idFactura;
                        ObjDetalleFactura.IDProducto = idProducto;

                        if (CN_DetalleFactura.InsertarDetalleFactura(ObjDetalleFactura))
                        {
                            MessageBox.Show("Registro exitoso");
                        }
                        else
                        {
                            MessageBox.Show("Fallo en la inserción");
                        }
                    }
                    else
                    {
                        MessageBox.Show("IDProducto no válido o no existe en la tabla Producto.");
                    }
                }
                else
                {
                    MessageBox.Show("IDFactura no válido o no existe en la tabla Factura.");
                }
            }
            else
            {
                MessageBox.Show("Los campos de cantidad de productos y precio unitario deben ser números válidos.");
            }
        }

        // Función para verificar si existe el IDFactura en la tabla Factura
        private bool FacturaExists(int idFactura)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM Factura WHERE IDFactura = @IDFactura";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDFactura", idFactura);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        exists = count > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Manejo de excepciones
                exists = false;
                throw;
            }

            return exists;
        }

        // Función para verificar si existe el IDProducto en la tabla Producto
        private bool ProductoExists(int idProducto)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM Producto WHERE IDProducto = @IDProducto";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDProducto", idProducto);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        exists = count > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Manejo de excepciones
                exists = false;
                throw;
            }

            return exists;
        }

    }
}
