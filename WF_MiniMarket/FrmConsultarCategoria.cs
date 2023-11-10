using CL_Capa_Entidades;
using CL_Capa_Negocio;
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
    public partial class FrmConsultarCategoria : Form
    {
        public FrmConsultarCategoria()
        {
            InitializeComponent();
        }

        private void FrmConsultarCategoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            DataTable MiTablaDatos = CN_Categoria.ConsultarCategoria();
            dgvCategoria.DataSource = MiTablaDatos;
            dgvCategoria.Columns[0].Visible = false;

            // Agregar botón de actualización a la tabla
            DataGridViewButtonColumn dgbcEditarCategoria = new DataGridViewButtonColumn
            {
                Name = "Actualizar",
                Text = "Actualizar"
            };
            dgvCategoria.Columns.Add(dgbcEditarCategoria);
        }


        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCategoria.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                LlenarCamposCategoriaSeleccionado();
            }
        }

        private void LlenarCamposCategoriaSeleccionado()
        {
            if (dgvCategoria.CurrentRow != null)
            {
                txtBoxNombreCategoriaR.Text = dgvCategoria.CurrentRow.Cells[2].Value.ToString();
                txtBoxDescripcionCategoriaR.Text = dgvCategoria.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            ActualizarCategoria();
        }

        private void ActualizarCategoria()
        {
            string nombre = txtBoxNombreCategoriaR.Text;
            string descripcion = txtBoxDescripcionCategoriaR.Text;

            Categoria categoria = new Categoria
            {
                Nombre = nombre,
                Descripcion = descripcion,
            };

            bool actualizado = CN_Categoria.ActualizarCategoria(categoria);

            if (actualizado)
            {
                MessageBox.Show("Categoria actualizada con éxito.");
                // Aquí puedes agregar lógica adicional si es necesario
            }
            else
            {
                MessageBox.Show("Error al actualizar la categoria. Verifique los datos y vuelva a intentarlo.");
                // Aquí puedes manejar el error de alguna otra manera si es necesario
            }

            // Volver a cargar la lista de proveedores después de la actualización

        }
    }
}
