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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarMiniMarketcs ObjFrm = new FrmRegistrarMiniMarketcs();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria ObjFrm = new FrmRegistrarCategoria();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente ObjFrm = new FrmRegistrarCliente();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRegistrarProveedor ObjFrm = new FrmRegistrarProveedor();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto ObjFrm = new FrmRegistrarProducto();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado ObjFrm = new FrmRegistrarEmpleado();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmRegistrarFactura ObjFrm = new FrmRegistrarFactura();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmRegistrarDetalleFactura ObjFrm = new FrmRegistrarDetalleFactura();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrdenCompra ObjFrm = new FrmRegistrarOrdenCompra();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmRegistrarDetalleCompra ObjFrm = new FrmRegistrarDetalleCompra();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarProveedor ObjFrm = new FrmConsultarProveedor();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmConsultarCategoria ObjFrm = new FrmConsultarCategoria();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente ObjFrm = new FrmConsultarCliente();

            ObjFrm.MdiParent = this;
            ObjFrm.Show();
            ObjFrm.WindowState = FormWindowState.Maximized;
        }
    }
}
