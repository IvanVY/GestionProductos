namespace GestionProductos
{
    /// <summary>
    /// Clase que representa un producto concreto y hereda de ProductoBase.
    /// </summary>
    public class Producto : ProductoBase
    {
        public override string Codigo { get; set; }
        public override string Nombre { get; set; }
        public override double Precio { get; set; }
        public override int Cantidad { get; set; }

        /// <summary>
        /// Retorna una cadena con la información del producto, formateada.
        /// </summary>
        public override string ToString()
        {
            return $"Código: {Codigo} | Nombre: {Nombre} | Precio: {Precio} | Cantidad: {Cantidad}";
        }
    }
}
