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
    public partial class FrmRegistrarCategoria : Form
    {
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardarCategoriaR_Click(object sender, EventArgs e)
        {
            Categoria ObjCategoria = new Categoria();

            ObjCategoria.Nombre = txtBoxNombreCategoriaR.Text.Trim();
            ObjCategoria.Descripcion = txtBoxDescripcionCategoriaR.Text.Trim();

            if (CN_Categoria.InsertarCategoria(ObjCategoria))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");
        }
    }
}
