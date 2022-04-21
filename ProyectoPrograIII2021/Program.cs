using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIII2021
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Empresa empresa;
            empresa = cargarEmpresa();
                       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);        
            Application.Run(new Form1());

            guardar(empresa);        
        }

        
        public static Empresa cargarEmpresa()
        {
            Empresa empresa;
            if (File.Exists("datosEmpresa.bin"))
            {              
                Stream flujo2 = File.OpenRead("datosEmpresa.bin");

                BinaryFormatter deserializer = new BinaryFormatter();
                empresa = (Empresa)deserializer.Deserialize(flujo2);
                flujo2.Close();
                return empresa;
            }
            else
            {
                return null;
            }
        }

        public static void guardar(Empresa empresa)
        {
            Stream flujo = File.Create("datosEmpresa.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo, empresa);
            flujo.Close();
        }
    }
}
