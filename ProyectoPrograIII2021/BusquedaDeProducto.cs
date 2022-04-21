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
    public partial class BusquedaDeProducto : MaterialSkin.Controls.MaterialForm
    {
        private Menu menu;
        public BusquedaDeProducto()
        {
            InitializeComponent();
            menu = new Menu();
        }

        Empresa empresa = Program.cargarEmpresa();

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            if (tbCodigoProducto.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto producto = empresa.buscarProducto(tbCodigoProducto.Text);
                if (producto != null)
                {
                    MessageBox.Show($"Descripcion: {producto.Descripcion}\n Codigo de producto: {producto.Codigo}\n " +
                        $"Precio: {producto.Precio} \n Codigo de proveedor: {producto.Codproveedor} \n Stock: {producto.Stock}");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void BusquedaDeProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
