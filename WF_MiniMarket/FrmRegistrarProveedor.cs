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
    public partial class FrmRegistrarProveedor : Form
    {
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarProveedorR_Click(object sender, EventArgs e)
        {
            Proveedor ObjProveedor = new Proveedor();

            ObjProveedor.Nit = txtBoxNITProveedor.Text.Trim();
            ObjProveedor.RazonSocial = txtBoxRazonSocialProveedor.Text.Trim();
            ObjProveedor.Telefono = txtBoxTelefonoProveedor.Text.Trim();
            ObjProveedor.Correo = txtBoxCorreoProveedor.Text.Trim();
            ObjProveedor.Nomenclatura = txtBoxNomenclaturaProveedor.Text.Trim();
            ObjProveedor.Ciudad = textBoxCiudadProveedorR.Text.Trim();
            ObjProveedor.Departamento = textBoxDepartamentoProveedorR.Text.Trim();           

            if (CN_Proveedor.InsertarProveedor(ObjProveedor))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");
        }
    }
}
