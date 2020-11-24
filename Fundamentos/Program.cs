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
            Application.Run(new Form08Char());
        }
    }
}
