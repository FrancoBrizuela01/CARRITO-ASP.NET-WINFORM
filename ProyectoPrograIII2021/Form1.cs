using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIII2021
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private Menu menu;
        private string nombre = "admin";
        private string contraseña = "123";
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
            menu = new Menu();
        }       
        private void Form1_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Orange400, Primary.Orange700, Primary.Green100, Accent.Orange100, TextShade.WHITE);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                MessageBox.Show("Ingrese su nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbConstraseña.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbUsuario.Text != nombre || tbConstraseña.Text != contraseña)
            {
                MessageBox.Show("Usuario o contraseña incorrecta. Intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Text = "";
                tbConstraseña.Text = "";
                contador++;
            }
            else
            {
                menu.Show();
                this.Hide();
            }
            if (contador == 3)
            {
                MessageBox.Show("La aplicacion se cerrara, intentelo en otro momento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

       
    }
}
