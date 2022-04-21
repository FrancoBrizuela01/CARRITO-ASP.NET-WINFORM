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
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        private CompraDeProducto compraProducto;
        private Alta_de_producto altaProducto;
        private BusquedaDeProducto busqproduct;
        private EliminarProducto elimProduct;
        private VentaProducto ventaProducto;
        private Historial frmCliente;

        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            altaProducto = new Alta_de_producto();
            busqproduct = new BusquedaDeProducto();
            elimProduct = new EliminarProducto();
            ventaProducto = new VentaProducto();
            compraProducto = new CompraDeProducto();
            frmCliente = new Historial();
        }
        private void btnVenderProducto_Click_1(object sender, EventArgs e)
        {
            ventaProducto.Show();
            this.Hide();  
        }

        private void btnAltaProducto_Click_1(object sender, EventArgs e)
        {
            altaProducto.Show();
            this.Hide();
        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            busqproduct.Show();
            this.Hide();
        }

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            elimProduct.Show();
            this.Hide();
        }

        private void btnSalirDeSistema_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Exit();
        }

        private void btnComprarProducto_Click(object sender, EventArgs e)
        {
            compraProducto.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente.Show();
            this.Hide();
        }
    }
}
