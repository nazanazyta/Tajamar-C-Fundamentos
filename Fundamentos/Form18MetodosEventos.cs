using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form18MetodosEventos : Form
    {
        public Form18MetodosEventos()
        {
            InitializeComponent();
        }

        private void lblraton_MouseHover(object sender, EventArgs e)
        {
            //e.Equals, e.GetHashCode, e.GetType, e.ToString
        }

        private void lblraton_MouseMove(object sender, MouseEventArgs e)
        {
            //e.X, e.Y, e.Location, e.Button, e.Clicks, e.Delta
            this.lblraton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESEAMOS INCLUIR LA TECLA DE BORRAR
            //PODEMOS RECUPERAR EL CÓDIGO ASCII DE UNA TECLA O TAMBIÉN
            //TENEMOS UNA ENUMERACIÓN QUE NOS DEVUELVE TODOS LOS CÓDIGOS ASCII
            //TECLA BACK --> 8
            char c = (char) 8;
            char teclaback = (char) Keys.Back;
            //e.KeyChar --> char
            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaback)
            {
                e.Handled = true;
            }
        }

        private void txtletras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaback = (char)Keys.Back;
            char teclaespacio = (char)Keys.Space;
            if(char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaback
                && e.KeyChar != teclaespacio)
            {
                e.Handled = true;
            }
        }
    }
}
