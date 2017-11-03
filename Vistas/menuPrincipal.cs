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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            menuStock frm = new menuStock();
            frm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            menuProducto frm = new menuProducto();
            frm.ShowDialog();
        }
    }
}
