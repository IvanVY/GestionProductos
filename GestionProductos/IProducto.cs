namespace GestionProductos
{
    /// <summary>
    /// Interfaz que define las propiedades básicas que debe tener un producto.
    /// </summary>
    public interface IProducto
    {
        string Codigo { get; set; }
        string Nombre { get; set; }
        double Precio { get; set; }
        int Cantidad { get; set; }
    }
}
