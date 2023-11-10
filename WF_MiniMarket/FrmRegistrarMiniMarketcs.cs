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
    public partial class FrmRegistrarMiniMarketcs : Form
    {
        public FrmRegistrarMiniMarketcs()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Minimarket ObjMiniMarket = new Minimarket();

            ObjMiniMarket.Nit = txtBoxNITMiniMarket.Text.Trim();
            ObjMiniMarket.RazonSocial = txtBoxRazonSocialMiniMarket.Text.Trim();
            ObjMiniMarket.Telefono = txtBoxTelefonoMiniMarket.Text.Trim();
            ObjMiniMarket.Nomenclatura = txtBoxNomenclatura.Text.Trim();
            ObjMiniMarket.Ciudad = txtBoxCiudad.Text.Trim();
            ObjMiniMarket.Departamento = txtBoxDepto.Text.Trim();
            ObjMiniMarket.Correo = txtBoxCorreoMiniMarket.Text.Trim();
            ObjMiniMarket.SitioWeb = txtBoxSitioWeb.Text.Trim();
            ObjMiniMarket.Facebook = txtBoxFacebook.Text.Trim();
            ObjMiniMarket.Whatsapp = txtBoxWhatsApp.Text.Trim();

            if (CN_MiniMarket.ActualizarMiniMarket(ObjMiniMarket))
            {
                MessageBox.Show("Actualización exitosa");
            }
            else
                MessageBox.Show("Fallo en la actualización");

            //if (CN_MiniMarket.InsertarMiniMarket(ObjMiniMarket))
            //{
            //    MessageBox.Show("Registro exitoso");
            //}
            //else
            //    MessageBox.Show("Fallo en la insercion");
        }

        private void FrmRegistrarMiniMarketcs_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos = new DataTable();

            tablaDatos = CN_MiniMarket.ConsultarMiniMarket();

            txtBoxNITMiniMarket.Text = tablaDatos.Rows[0]["nit"].ToString();
            txtBoxRazonSocialMiniMarket.Text = tablaDatos.Rows[0]["razonSocial"].ToString();
            txtBoxTelefonoMiniMarket.Text = tablaDatos.Rows[0]["telefono"].ToString();
            txtBoxNomenclatura.Text = tablaDatos.Rows[0]["nomenclatura"].ToString();
            txtBoxCiudad.Text = tablaDatos.Rows[0]["ciudad"].ToString();
            txtBoxDepto.Text = tablaDatos.Rows[0]["departamento"].ToString();
            txtBoxCorreoMiniMarket.Text = tablaDatos.Rows[0]["correo"].ToString();
            txtBoxSitioWeb.Text = tablaDatos.Rows[0]["sitioWeb"].ToString();
            txtBoxFacebook.Text = tablaDatos.Rows[0]["facebook"].ToString();
            txtBoxWhatsApp.Text = tablaDatos.Rows[0]["whatsapp"].ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
