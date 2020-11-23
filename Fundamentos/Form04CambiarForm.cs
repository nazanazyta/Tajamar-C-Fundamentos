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
    public partial class Form04CambiarForm : Form
    {
        public Form04CambiarForm()
        {
            InitializeComponent();
        }

        private void btnposicion_Click(object sender, EventArgs e)
        {
            string x, y;
            x = this.txtposicionx.Text;
            y = this.txtposiciony.Text;
            this.btnposicion.Location = new Point(int.Parse(x), int.Parse(y));
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            string rojo, verde, azul;
            rojo = this.txtrojo.Text;
            verde = this.txtverde.Text;
            azul = this.txtazul.Text;
            this.BackColor = Color.FromArgb(int.Parse(rojo), int.Parse(verde), int.Parse(azul));
        }
    }
}
