using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new FormConversion());
            //Application.Run(new FormSumar());
            //Application.Run(new Form04CambiarForm());
            //Application.Run(new Form05MayorTresNumeros());
            //Application.Run(new Form06DiaNacimiento());
            //Application.Run(new Form07DateTime());
            //Application.Run(new Form08Char());
            //Application.Run(new Form09ValidarMail());
            //Application.Run(new Form10SumarNumerosString());
            //Application.Run(new Form11ValidarIsbn());
            //Application.Run(new Form12StringBuilder());
            //Application.Run(new Form13ColeccionGrafica());
            //Application.Run(new Form14SeleccionMultipleListBox());
            //Application.Run(new Form15ColeccionNumerosListBox());
            //Application.Run(new Form16TiendaProductos());
            //Application.Run(new Form17MetodoReferencia());
            Application.Run(new Form18MetodosEventos());
        }
    }
}
