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
    public partial class VentaProducto : MaterialSkin.Controls.MaterialForm
    {
        Menu menu;
        public VentaProducto()
        {
            InitializeComponent();
            menu = new Menu();
        }

        Empresa empresa = Program.cargarEmpresa();

        private void btnVender_Click_1(object sender, EventArgs e)
        {

            if (tbCodProducto.Text == "" || tbCantidadProducto.Text == "" || tbNumeroCliente.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto producto = empresa.buscarProducto(tbCodProducto.Text);
                if (producto != null)
                {
                    if(producto.Stock >= Convert.ToInt32(tbCantidadProducto.Text))
                    {
                        empresa.ventaProducto(tbCodProducto.Text, Convert.ToInt32(tbCantidadProducto.Text), Convert.ToInt32(tbNumeroCliente.Text), tbNombreCliente.Text);
                        MessageBox.Show("Venta realizada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.guardar(empresa);
                        //guardar();
                    }
                    else
                    {
                        MessageBox.Show("Stock no suficiente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Venta no realizada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        //public void guardar()
        //{
        //    Stream flujo = File.Create("datosEmpresa.bin");
        //    BinaryFormatter serializer = new BinaryFormatter();
        //    serializer.Serialize(flujo, empresa);
        //    flujo.Close();
        //}

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void VentaProducto_Load(object sender, EventArgs e)
        {
            //if (File.Exists("datosEmpresa.bin"))
            //{
            //    Stream flujo2 = File.OpenRead("datosEmpresa.bin");

            //    BinaryFormatter deserializer = new BinaryFormatter();
            //    empresa = (Empresa)deserializer.Deserialize(flujo2);

            //    flujo2.Close();
            //}
        }
    }
}
