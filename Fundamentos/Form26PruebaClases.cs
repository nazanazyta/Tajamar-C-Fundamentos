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
            this.lstdatos.Items.Clear();
            //TODA CLASE DEBEMOS INSTANCIARLA PARA PODER UTILIZARLA
            Persona person = new Persona();
            person.Nombre = "Nazaret";
            person.Apellidos = "de la Calle Miján";
            person.Edad = 27;
            person[0] = "Ojos verdes";
            person[1] = "Pelo castaño";
            //person[99] = "Prueba...";
            person.Genero = TipoGenero.Femenino;
            //person.Genero = (TipoGenero)1;
            person.Nacionalidad = Paises.España;
            this.lstdatos.Items.Add("Nombre: " + person.Nombre);
            this.lstdatos.Items.Add("Edad: " + person.Edad);
            this.lstdatos.Items.Add("Género: " + person.Genero);
            this.lstdatos.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.lstdatos.Items.Add("Descripción 0: " + person[0]);
            this.lstdatos.Items.Add("Descripción 1: " + person[1]);
            this.lstdatos.Items.Add("Nombre completo: " + person.GetNombreCompleto(true));
            person.Domicilio = new Direccion("Calle Antonia Lancha", "Madrid");
            //person.Domicilio.Calle = "Calle Pez";
            this.lstdatos.Items.Add("Casa: " + person.Domicilio.Calle + ", " + person.Domicilio.Ciudad);
            person.DomicilioVacaciones = new Direccion("Calle Segovia", "Granada", 27715);
            //person.DomicilioVacaciones.Ciudad = "Marina Door";
            this.lstdatos.Items.Add("Vacaciones: " + person.DomicilioVacaciones.Calle
                + ", " + person.DomicilioVacaciones.Ciudad
                + " (CP: " + person.DomicilioVacaciones.CodigoPostal + ")");
        }

        private void btncrearempleado_Click(object sender, EventArgs e)
        {
            this.lstdatos.Items.Clear();
            Empleado emp = new Empleado();
            emp.Nombre = "Empleado";
            emp.Apellidos = "Apellidos emp";
            this.lstdatos.Items.Add("Datos completos: "
                + emp.GetNombreCompleto());
            //Empleado empleado = new Empleado("Emp", "EmpApe");
            Director dire = new Director();
            this.lstdatos.Items.Add("Director: " + dire.GetSalarioMinimo());
            this.lstdatos.Items.Add("Empleado: " + emp.GetSalarioMinimo());
            this.lstdatos.Items.Add("Vacaciones Empleado: " + emp.GetVacaciones());
            this.lstdatos.Items.Add("Vacaciones Director: " + dire.GetVacaciones());
        }
    }
}
