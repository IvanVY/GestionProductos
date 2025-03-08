using System;
using System.Windows.Forms;

namespace GestionProductos
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita los estilos visuales modernos para la aplicación.
            Application.EnableVisualStyles();
            // Configura el renderizado de texto para ser compatible con versiones anteriores.
            Application.SetCompatibleTextRenderingDefault(false);
            // Inicia la aplicación y abre el formulario principal (Form1).
            Application.Run(new Form1());
        }
    }
}
