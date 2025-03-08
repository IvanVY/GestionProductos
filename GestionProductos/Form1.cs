using System;
using System.Windows.Forms;

namespace GestionProductos
{
    public partial class Form1 : Form
    {
        // Instancia global del inventario.
        Inventario inventario = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia todos los campos de entrada.
        /// </summary>
        private void ClearFields()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        /// <summary>
        /// Evento para agregar un nuevo producto.
        /// Valida que todos los campos estén completos y crea un objeto Producto.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos.
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear el producto a partir de los datos ingresados.
            Producto producto = new Producto
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Precio = double.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text)
            };

            // Agregar el producto al inventario.
            inventario.AgregarProducto(producto);
            // Actualizar la lista de productos mostrada.
            inventario.MostrarProductos(lstProductos);
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para eliminar un producto utilizando su código.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.EliminarProducto(txtCodigo.Text);
            inventario.MostrarProductos(lstProductos);
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para consultar la información de un producto a partir de su código.
        /// </summary>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Producto producto = inventario.ConsultarProducto(txtCodigo.Text);
            if (producto != null)
            {
                MessageBox.Show($"Código: {producto.Codigo}\nNombre: {producto.Nombre}\nPrecio: {producto.Precio}\nCantidad: {producto.Cantidad}");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para modificar el precio de un producto.
        /// Se utiliza el valor de txtPrecio como nuevo precio.
        /// </summary>
        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrecio.Text, out double nuevoPrecio))
            {
                inventario.ModificarPrecio(txtCodigo.Text, nuevoPrecio);
                inventario.MostrarProductos(lstProductos);
            }
            else
            {
                MessageBox.Show("Ingrese un precio válido.");
            }
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para modificar la cantidad de un producto.
        /// Se utiliza el valor de txtCantidad como la nueva cantidad.
        /// </summary>
        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int nuevaCantidad))
            {
                inventario.ModificarCantidad(txtCodigo.Text, nuevaCantidad);
                inventario.MostrarProductos(lstProductos);
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para mostrar todos los productos registrados.
        /// </summary>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            inventario.MostrarProductos(lstProductos);
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para mostrar los productos que tienen stock (cantidad > 0).
        /// </summary>
        private void btnMostrarStock_Click(object sender, EventArgs e)
        {
            inventario.MostrarProductosEnStock(lstProductos);
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para mostrar los productos agotados (cantidad == 0).
        /// </summary>
        private void btnMostrarAgotados_Click(object sender, EventArgs e)
        {
            inventario.MostrarProductosAgotados(lstProductos);
            ClearFields(); // Limpia los campos tras agregar.
        }

        /// <summary>
        /// Evento para mostrar los productos en oferta, es decir, aquellos cuyo precio es menor a 10.
        /// </summary>
        private void btnMostrarOferta_Click(object sender, EventArgs e)
        {
            double precioLimite = 10; // Valor que define la oferta
            inventario.MostrarProductosEnOferta(lstProductos, precioLimite);
            ClearFields(); // Limpia los campos tras agregar.
        }


    }
}
