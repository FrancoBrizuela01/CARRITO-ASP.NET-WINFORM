using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII2021
{
    [Serializable]
    public class Ventas
    {
        public Producto producto { get; set; }
        public Cliente cliente{ get; set; }

        public Ventas( Producto p, Cliente c)
        {
            this.producto = p;
            this.cliente = c;
        }




    }
}
