using CL_Capa_Entidades;
using CL_Capa_Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarFactura : Form
    {
        public FrmRegistrarFactura()
        {
            InitializeComponent();
        }

        private void btnGuardarFacturaR_Click(object sender, EventArgs e)
        {
            Factura ObjFactura = new Factura();

            ObjFactura.CodigoFactura = txtBoxCodigoFacturaR.Text.Trim();

            // Verificar si ya existe una factura con el mismo código
            if (CN_Factura.ExisteFacturaConCodigo(ObjFactura.CodigoFactura))
            {
                MessageBox.Show("Ya existe una factura con este código.");
                return;
            }

            if (DateTime.TryParse(txtBoxFechaGeneracionFactura.Text.Trim(), out DateTime fechaGeneracion))
            {
                ObjFactura.FechaGeneracion = fechaGeneracion;
            }
            else
            {
                MessageBox.Show("Fecha de generación no válida");
                return;
            }

            if (int.TryParse(txtBoxIVAFacturaR.Text.Trim(), out int iva))
            {
                ObjFactura.IVA = iva;
            }
            else
            {
                MessageBox.Show("Valor de IVA no válido");
                return;
            }

            if (int.TryParse(txtBoxSinIVAFacturaR.Text.Trim(), out int sinIVA))
            {
                ObjFactura.SinIVA = sinIVA;
            }
            else
            {
                MessageBox.Show("Valor sin IVA no válido");
                return;
            }

            if (int.TryParse(textBoxTotalFacturaR.Text.Trim(), out int total))
            {
                ObjFactura.Total = total;
            }
            else
            {
                MessageBox.Show("Valor total no válido");
                return;
            }

            if (int.TryParse(textBoxEmpleadoFacturaR.Text.Trim(), out int idEmpleado))
            {
                ObjFactura.IDEmpleado = idEmpleado;
            }
            else
            {
                MessageBox.Show("ID de empleado no válido");
                return;
            }

            if (int.TryParse(txtBoxClienteFacturaR.Text.Trim(), out int idCliente))
            {
                ObjFactura.IDCliente = idCliente;
            }
            else
            {
                MessageBox.Show("ID de cliente no válido");
                return;
            }

            if (CN_Factura.InsertarFactura(ObjFactura))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
            {
                MessageBox.Show("Fallo en la inserción");
            }
        }
    }
}
