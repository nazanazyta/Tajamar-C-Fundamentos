using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form26PruebaClases : Form
    {
        public Form26PruebaClases()
        {
            InitializeComponent();
        }

        private void btncrearpersona_Click(object sender, EventArgs e)
        {
            //TODA CLASE DEBEMOS INSTANCIARLA PARA PODER UTILIZARLA
            Persona person = new Persona();
            person.Nombre = "Nazaret";
            person.Edad = 10;
            this.lstdatos.Items.Add("Nombre: " + person.Nombre);
            this.lstdatos.Items.Add("Edad: " + person.Edad);
        }
    }
}
