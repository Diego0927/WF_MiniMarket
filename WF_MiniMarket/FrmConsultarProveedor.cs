using CL_Capa_Datos;
using CL_Capa_Entidades;
using CL_Capa_Negocio;
using System;
using System.Windows.Forms;
using System.Data;

namespace WF_MiniMarket
{
    public partial class FrmConsultarProveedor : Form
    {
        public FrmConsultarProveedor()
        {
            InitializeComponent();
        }

        private void FrmConsultarProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            DataTable MiTablaDatos = CN_Proveedor.ConsultarProveedores();
            dgvProveedores.DataSource = MiTablaDatos;
            dgvProveedores.Columns[0].Visible = false;

            // Agregar botón de actualización a la tabla
            DataGridViewButtonColumn dgbcEditarProveedor = new DataGridViewButtonColumn
            {
                Name = "Actualizar",
                Text = "Actualizar"
            };
            dgvProveedores.Columns.Add(dgbcEditarProveedor);
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProveedores.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                LlenarCamposProveedorSeleccionado();
            }
        }

        private void LlenarCamposProveedorSeleccionado()
        {
            if (dgvProveedores.CurrentRow != null)
            {
                txtBoxNITProveedor.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                txtBoxRazonSocialProveedor.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
                txtBoxTelefonoProveedor.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
                txtBoxCorreoProveedor.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
                txtBoxNomenclaturaProveedor.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
                textBoxCiudadProveedorR.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();
                textBoxDepartamentoProveedorR.Text = dgvProveedores.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarProveedor();
        }

        private void ActualizarProveedor()
        {
            string nit = txtBoxNITProveedor.Text;
            string razonSocial = txtBoxRazonSocialProveedor.Text;
            string telefono = txtBoxTelefonoProveedor.Text;
            string correo = txtBoxCorreoProveedor.Text;
            string nomenclatura = txtBoxNomenclaturaProveedor.Text;
            string ciudad = textBoxCiudadProveedorR.Text;
            string departamento = textBoxDepartamentoProveedorR.Text;

            Proveedor proveedor = new Proveedor
            {
                Nit = nit,
                RazonSocial = razonSocial,
                Telefono = telefono,
                Correo = correo,
                Nomenclatura = nomenclatura,
                Ciudad = ciudad,
                Departamento = departamento
            };

            bool actualizado = CN_Proveedor.ActualizarProveedor(proveedor);

            if (actualizado)
            {
                MessageBox.Show("Proveedor actualizado con éxito.");
                // Aquí puedes agregar lógica adicional si es necesario
            }
            else
            {
                MessageBox.Show("Error al actualizar el proveedor. Verifique los datos y vuelva a intentarlo.");
                // Aquí puedes manejar el error de alguna otra manera si es necesario
            }

            // Volver a cargar la lista de proveedores después de la actualización
            
        }
    }
}