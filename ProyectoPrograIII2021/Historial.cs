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
    public partial class Historial : MaterialSkin.Controls.MaterialForm
    {
        private Menu menu;
        public Historial()
        {
            InitializeComponent();
            menu = new Menu();
        }

        Empresa empresa = Program.cargarEmpresa();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Ventas> ventas = empresa.getVentas();
            foreach(Ventas v in ventas)
            {
                lstProductos.Items.Add("NOMBRE DEL CLIENTE:");
                lstProductos.Items.Add("- " + v.cliente.nombre + " (" + v.cliente.numero + ")");
                lstProductos.Items.Add("--");
                lstProductos.Items.Add("PRODUCTOS:");
                lstProductos.Items.Add("- " + v.producto.Descripcion);
                lstProductos.Items.Add("------------------------");
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        
    }
}
