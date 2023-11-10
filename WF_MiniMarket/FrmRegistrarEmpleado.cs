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
    public partial class FrmRegistrarEmpleado : Form
    {
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardarEmpleadoR_Click(object sender, EventArgs e)
        {
            string tipoDoc = comboBoxTipoDocEmpleadoR.SelectedItem.ToString();
            string identificacion = txtBoxNumDocumentoEmpleado.Text.Trim();
            string nombres = txtBoxNombresEmpleado.Text.Trim();
            string apellidos = txtBoxApellidosEmpleado.Text.Trim();
            string correo = txtBoxCorreoEmpleado.Text.Trim();
            string celular = txtBoxTelefonoEmpleado.Text.Trim();
            string clave = txtBoxClaveEmpleado.Text.Trim();

            if (ExisteIdentificacion(identificacion))
            {
                MessageBox.Show("La identificación ya existe en la base de datos.");
                return;
            }

            if (ExisteCorreo(correo))
            {
                MessageBox.Show("El correo ya existe en la base de datos.");
                return;
            }

            if (int.TryParse(txtBoxMinimarketEmpleado.Text.Trim(), out int idMinimarket) && idMinimarket >= 0)
            {
                if (!ExisteMinimarket(idMinimarket))
                {
                    MessageBox.Show("El IDMinimarket no existe en la tabla minimarket.");
                    return;
                }

                Empleado ObjEmpleado = new Empleado
                {
                    TipoDoc = tipoDoc,
                    Identificacion = identificacion,
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Correo = correo,
                    Celular = celular,
                    Clave = clave,
                    IDMiniMarket = idMinimarket
                };

                if (CN_Empleado.InsertarEmpleado(ObjEmpleado))
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
                MessageBox.Show("El campo IDMiniMarket debe ser un número válido.");
            }
        }

        private bool ExisteIdentificacion(string identificacion)
        {
            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            {
                conn.Open();
                string consulta = $"SELECT COUNT(*) FROM Empleado WHERE Identificacion = '{identificacion}'";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool ExisteCorreo(string correo)
        {
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            {
                conn.Open();
                string consulta = $"SELECT COUNT(*) FROM Empleado WHERE Correo = '{correo}'";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool ExisteMinimarket(int idMinimarket)
        {
            using (MySqlConnection conn = new MySqlConnection(DA_BASE.CadenaConexion))
            {
                conn.Open();
                string consulta = $"SELECT COUNT(*) FROM minimarket WHERE IDMinimarket = {idMinimarket}";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
