using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class menuStock : Form
    {
        public menuStock()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            menuAgregarStock frm = new menuAgregarStock();
            frm.ShowDialog();
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            menuAgregarProducto frm = new menuAgregarProducto();
            frm.ShowDialog();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            menuAgregarCategoria frm = new menuAgregarCategoria();
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            menuModificarProducto frm = new menuModificarProducto();
            frm.ShowDialog();
        }
    }
}
