namespace GestionProductos
{
    /// <summary>
    /// Clase abstracta que define la estructura básica de un producto.
    /// Permite utilizar herencia para ampliar o modificar comportamientos en subclases.
    /// </summary>
    public abstract class ProductoBase : IProducto
    {
        public abstract string Codigo { get; set; }
        public abstract string Nombre { get; set; }
        public abstract double Precio { get; set; }
        public abstract int Cantidad { get; set; }
    }
}
