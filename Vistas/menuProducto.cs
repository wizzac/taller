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
    public partial class menuProducto : Form
    {
        public menuProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            menuAgregarCategoria frm = new menuAgregarCategoria();
            frm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            menuAgregarStock frm = new menuAgregarStock();
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            menuModificarProducto frm = new menuModificarProducto();
            frm.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            menuAgregarProducto frm = new menuAgregarProducto();
            frm.ShowDialog();
        }
    }
}
