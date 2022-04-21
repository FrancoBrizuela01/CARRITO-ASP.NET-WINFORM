using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII2021
{
    [Serializable]
    public class Cliente
    {
        public string nombre { get; set; }
        public int numero { get; set; }

        public Cliente(string nombre, int numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }
    }
}
