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
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            DataTable MiTablaDatos = CN_Cliente.ConsultarCliente();
            dgvCliente.DataSource = MiTablaDatos;
            dgvCliente.Columns[0].Visible = false;

            // Agregar botón de actualización a la tabla
            DataGridViewButtonColumn dgbcEditarCliente = new DataGridViewButtonColumn
            {
                Name = "Actualizar",
                Text = "Actualizar"
            };
            dgvCliente.Columns.Add(dgbcEditarCliente);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCliente.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                LlenarCamposClienteSeleccionado();
            }
        }

        private void LlenarCamposClienteSeleccionado()
        {
            if (dgvCliente.CurrentRow != null)
            {
                comboBoxTipoDocClienteR.SelectedItem = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtBoxIdentificacionClienteR.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                txtBoxNombresClienteR.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                txtBoxApellidosClienteR.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                txtBoxCorreoClienteR.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
                txtBoxCelularClienteR.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
            }
        }


        private void btnActualizarClienteR_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
        }

        private void ActualizarCliente()
        {
            string tipoDoc = comboBoxTipoDocClienteR.Text;
            string identificacion = txtBoxIdentificacionClienteR.Text;
            string nombres = txtBoxNombresClienteR.Text;
            string apellidos = txtBoxApellidosClienteR.Text;
            string correo = txtBoxCorreoClienteR.Text;
            string celular = txtBoxCelularClienteR.Text;

            Cliente cliente = new Cliente
            {
                TipoDoc = tipoDoc,
                Identificacion = identificacion,
                Nombres = nombres,
                Apellidos = apellidos,
                Correo = correo,
                Celular = celular,
            };

            bool actualizado = CN_Cliente.ActualizarCliente(cliente);

            if (actualizado)
            {
                MessageBox.Show("Cliente actualizado con éxito.");
                // Aquí puedes agregar lógica adicional si es necesario
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente. Verifique los datos y vuelva a intentarlo.");
                // Aquí puedes manejar el error de alguna otra manera si es necesario
            }

            // Volver a cargar la lista de proveedores después de la actualización

        }

    }
}
