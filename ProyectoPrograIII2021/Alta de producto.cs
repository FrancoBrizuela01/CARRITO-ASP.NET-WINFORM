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
    public partial class Alta_de_producto : MaterialSkin.Controls.MaterialForm
    {
        
        private Menu menu;
        public Alta_de_producto()
        {
            InitializeComponent();
            menu = new Menu();
        }

        Empresa empresa = Program.cargarEmpresa();

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            if (tbDescripcion.Text != "" || tbCodigoProducto.Text != "" || tbCodigoProveedor.Text != "" || tbPrecio.Text != "" || tbStock.Text != "")
            {
                setCreando(tbDescripcion.Text, tbCodigoProducto.Text, Convert.ToDecimal(tbPrecio.Text), tbCodigoProveedor.Text, Convert.ToInt32(tbStock.Text));
                MessageBox.Show("Producto agregado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setCreando(string descripcion, string codProducto, decimal precio, string codProveedor, int stock)
        {
            empresa.nuevoProducto(new Producto(descripcion, codProducto, precio, codProveedor, stock));
            Program.guardar(empresa);
        }
        public void limpiarCampos()
        {
            tbDescripcion.Text = "";
            tbCodigoProducto.Text = "";
            tbCodigoProveedor.Text = "";
            tbPrecio.Text = "";
            tbStock.Text = "";
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void Alta_de_producto_Load(object sender, EventArgs e)
        {

        }
    }
}
