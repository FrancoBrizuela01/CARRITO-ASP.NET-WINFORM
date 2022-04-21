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
    public partial class CompraDeProducto : MaterialSkin.Controls.MaterialForm
    {
        private Menu menu;
        public CompraDeProducto()
        {
            InitializeComponent();
            menu = new Menu();
        }

        Empresa empresa = Program.cargarEmpresa();

        private void btnComprarProducto_Click(object sender, EventArgs e)
        {
            if (tbCodProducto.Text == "" || tbCantidadProducto.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto producto = empresa.buscarProducto(tbCodProducto.Text);
                if (producto != null)
                {
                    empresa.compraProducto(tbCodProducto.Text, Convert.ToInt32(tbCantidadProducto.Text));
                    MessageBox.Show("Compra realizada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.guardar(empresa);
                    //guardar();
                }
                else
                {
                    MessageBox.Show("Compra no realizada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void CompraDeProducto_Load(object sender, EventArgs e)
        {
        }
    }
}
