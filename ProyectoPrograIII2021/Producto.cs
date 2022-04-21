using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII2021
{
    [Serializable]
    public class Producto
    {
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public string Codproveedor { get; set; }
        public int Stock { get; set; }

        public Producto(string descripcion, string codigo, decimal precio, string proveedor, int stock)
        {
            this.Descripcion = descripcion;
            this.Codigo = codigo;
            this.Precio = precio;
            this.Codproveedor = proveedor;
            this.Stock = stock;
        }


    }
}
