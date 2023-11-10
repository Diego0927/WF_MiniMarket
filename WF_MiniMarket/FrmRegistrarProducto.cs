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
    public partial class FrmRegistrarProducto : Form
    {
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void btnGuardarProductoR_Click(object sender, EventArgs e)
        {
            Producto ObjProducto = new Producto();

            ObjProducto.Nombre = txtBoxNombreProductoR.Text.Trim();
            ObjProducto.Marca = txtBoxMarcaProductoR.Text.Trim();

            // Verificar si ya existe un producto con el mismo nombre
            if (ExisteProductoNombre(ObjProducto.Nombre))
            {
                MessageBox.Show("Ya existe un producto con ese nombre.");
                return;
            }

            // Convertir Stock a entero
            if (int.TryParse(txtBoxStockProductoR.Text.Trim(), out int stock))
            {
                ObjProducto.Stock = stock;
            }
            else
            {
                MessageBox.Show("Error en el valor de Stock.");
                return; // Sale de la función si la conversión falla.
            }

            // Convertir PVP a decimal
            if (int.TryParse(txtBoxPVPProductoR.Text.Trim(), out int pvp))
            {
                ObjProducto.PVP = pvp;
            }
            else
            {
                MessageBox.Show("Error en el valor de PVP.");
                return; // Sale de la función si la conversión falla.
            }

            ObjProducto.Descripcion = textBoxDescripcionProductoR.Text.Trim();
            ObjProducto.UnidadDeMedida = comboBoxUndMedidaRegistroProducto.SelectedItem.ToString();

            if (int.TryParse(txtBoxCategoriaProductoR.Text.Trim(), out int idCategoria))
            {
                if (ExisteCategoria(idCategoria))
                {
                    ObjProducto.IDCategoria = idCategoria;
                }
                else
                {
                    MessageBox.Show("La categoría ingresada no existe.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error en el valor de la categoría.");
                return;
            }

            if (CN_Producto.InsertarProducto(ObjProducto))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
            {
                MessageBox.Show("Fallo en la inserción");
            }
        }

        public static bool ExisteProductoNombre(string nombre)
        {
            bool existe = false;

            // Consulta SQL para verificar la existencia de un producto con el nombre dado
            string consulta = "SELECT COUNT(*) FROM Producto WHERE Nombre = @Nombre";
            using (MySqlConnection conexion = new MySqlConnection(DA_BASE.CadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count > 0)
                    {
                        existe = true;
                    }
                }
            }

            return existe;
        }

        public static bool ExisteCategoria(int idCategoria)
        {
            bool existe = false;

            // Consulta SQL para verificar la existencia de una categoría con el ID dado
            string consulta = "SELECT COUNT(*) FROM Categoria WHERE IDCategoria = @IDCategoria";
            using (MySqlConnection conexion = new MySqlConnection(DA_BASE.CadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IDCategoria", idCategoria);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count > 0)
                    {
                        existe = true;
                    }
                }
            }

            return existe;
        }
    }
}
