using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIII2021
{
    [Serializable]
    public class Empresa 
    {
        private List<Producto> productos = new List<Producto>();
        private List<Ventas> ventas = new List<Ventas>();
        private List<Cliente> clientes = new List<Cliente>();

        public Empresa()
        {

        }

        public Producto buscarProducto(string codigo)
        {
            foreach (Producto p in productos)
            {
                if (p.Codigo == codigo)
                {
                    return p;
                }
            }
            return null;
        }

        public void elimarProducto(Producto p)
        {
            productos.Remove(p);
        }

        public void nuevoProducto(Producto p)
        {
            productos.Add(p);
        }


        public void ventaProducto(string codigo, int cantidad, int numeroCliente, string nombreCliente)
        {
            Producto producto = null;
            foreach(Producto p in productos)
            {
                if(p.Codigo == codigo)
                {
                    p.Stock = p.Stock - cantidad;
                    productos.Remove(p);
                    productos.Add(new Producto(p.Descripcion, p.Codigo,  p.Precio, p.Codproveedor, p.Stock));
                    producto = p;
                    break;
                }
            }

            if(existeCliente(numeroCliente, nombreCliente) != null)
            {
                Cliente c = existeCliente(numeroCliente, nombreCliente);
                ventas.Add(new Ventas(producto, c));
            }
            else
            {
                ventas.Add(new Ventas(producto, new Cliente(nombreCliente, numeroCliente)));
            }
        }

        public Cliente existeCliente(int numeroCliente, string nombreCliente)
        {
            foreach(Cliente c in clientes)
            {
                if(numeroCliente == c.numero && nombreCliente == c.nombre)
                {
                    return c;
                }
            }
            return null;
        }


        public void compraProducto(string codigo, int cantidad)
        {
            foreach (Producto p in productos)
            {
                if (p.Codigo == codigo)
                {
                    p.Stock = p.Stock + cantidad;
                    productos.Remove(p);
                    productos.Add(new Producto(p.Descripcion, p.Codigo, p.Precio, p.Codproveedor, p.Stock));
                    break;
                }
            }
        }

        public List<Ventas> getVentas()
        {
            return ventas;
        }


    }
}
