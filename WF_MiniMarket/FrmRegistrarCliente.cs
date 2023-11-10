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
    public partial class FrmRegistrarCliente : Form
    {
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardarClienteR_Click(object sender, EventArgs e)
        {
            Cliente ObjCliente = new Cliente();

            ObjCliente.TipoDoc = comboBoxTipoDocClienteR.SelectedItem.ToString();
            ObjCliente.Identificacion = txtBoxIdentificacionClienteR.Text.Trim();
            ObjCliente.Nombres = txtBoxNombresClienteR.Text.Trim();
            ObjCliente.Apellidos = txtBoxApellidosClienteR.Text.Trim();
            ObjCliente.Correo = txtBoxCorreoClienteR.Text.Trim();
            ObjCliente.Celular = txtBoxCelularClienteR.Text.Trim();

            if (CN_Cliente.InsertarCliente(ObjCliente))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");
        }
    }
}
