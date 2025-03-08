using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionProductos
{
    /// <summary>
    /// Clase que administra el inventario de productos.
    /// </summary>
    public class Inventario
    {
        // Lista interna para almacenar productos.
        private List<Producto> productos = new List<Producto>();

        /// <summary>
        /// Muestra todos los productos en el ListBox.
        /// </summary>
        public void MostrarProductos(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var producto in productos)
            {
                listBox.Items.Add(producto);
            }
        }

        /// <summary>
        /// Agrega un nuevo producto al inventario sin permitir duplicados de código.
        /// </summary>
        public void AgregarProducto(Producto producto)
        {
            if (!productos.Any(p => p.Codigo == producto.Codigo))
            {
                productos.Add(producto);
                MessageBox.Show("Producto agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error: El código del producto ya existe.");
            }
        }

        /// <summary>
        /// Elimina un producto a partir del código.
        /// </summary>
        public void EliminarProducto(string codigo)
        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                productos.Remove(producto);
                MessageBox.Show("Producto eliminado.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        /// <summary>
        /// Consulta y retorna un producto según su código.
        /// </summary>
        public Producto ConsultarProducto(string codigo)
        {
            return productos.FirstOrDefault(p => p.Codigo == codigo);
        }

        /// <summary>
        /// Modifica el precio de un producto a partir de su código.
        /// </summary>
        public void ModificarPrecio(string codigo, double nuevoPrecio)
        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                producto.Precio = nuevoPrecio;
                MessageBox.Show("Precio modificado.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        /// <summary>
        /// Modifica la cantidad de un producto a partir de su código.
        /// </summary>
        public void ModificarCantidad(string codigo, int nuevaCantidad)
        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                producto.Cantidad = nuevaCantidad;
                MessageBox.Show("Cantidad modificada.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        /// <summary>
        /// Muestra los productos con cantidad mayor a cero (en stock).
        /// </summary>
        public void MostrarProductosEnStock(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var producto in productos.Where(p => p.Cantidad > 0))
            {
                listBox.Items.Add(producto);
            }
        }

        /// <summary>
        /// Muestra los productos agotados (cantidad igual a cero).
        /// </summary>
        public void MostrarProductosAgotados(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var producto in productos.Where(p => p.Cantidad == 0))
            {
                listBox.Items.Add(producto);
            }
        }

        /// <summary>
        /// Muestra los productos en oferta, es decir, aquellos cuyo precio es menor que el valor especificado.
        /// </summary>
        public void MostrarProductosEnOferta(ListBox listBox, double precioLimite)
        {
            listBox.Items.Clear();
            foreach (var producto in productos.Where(p => p.Precio < precioLimite))
            {
                listBox.Items.Add(producto);
            }
        }
    }
}
