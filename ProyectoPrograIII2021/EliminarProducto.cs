using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIII2021
{
    [Serializable]

    public partial class EliminarProducto : MaterialSkin.Controls.MaterialForm
    {
        private Menu menu;
        public EliminarProducto()
        {
            InitializeComponent();
            menu = new Menu();
        }

        Empresa empresa = Program.cargarEmpresa();

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            if (tbProductoAEliminar.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto producto = empresa.buscarProducto(tbProductoAEliminar.Text);
                if (producto != null)
                {
                    empresa.elimarProducto(producto);
                    MessageBox.Show("Producto eliminado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.guardar(empresa);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
        }
    }
}
