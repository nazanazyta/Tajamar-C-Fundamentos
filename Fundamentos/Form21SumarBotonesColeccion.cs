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
    public partial class Form21SumarBotonesColeccion : Form
    {
        //DECLARAR, QUE NO INSTANCIAR, A NIVEL DE CLASE
        //LA COLECCIÓN DE Button
        List<Button> botones;
        int suma;

        public Form21SumarBotonesColeccion()
        {
            InitializeComponent();
            //INSTANCIAMOS LA COLECCION DE Button
            this.botones = new List<Button>();
            Random rnd = new Random();
            //QUEREMOS RELLENAR LA COLECCIÓN DE BOTONES
            //CON TODOS LOS DIBUJADOS EN EL FORMULARIO
            //RECORREMOS CONTROLS DEL CONTENEDOR FORM
            foreach (Control control in this.panel1.Controls)
            {
                //PREGUNTAMOS POR SU TYPE
                if (control is Button)
                {
                    control.Text = rnd.Next(1, 20).ToString();
                    this.botones.Add((Button)control);
                }
            }
            //RECORREMOS NUESTRA COLECCIÓN DE BOTONES
            foreach (Button boton in this.botones)
            {
                boton.Click += SumarNumero;
            }
        }

        private void SumarNumero(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Yellow;
            //int num = int.Parse(boton.Text);
            //int suma = int.Parse(this.txtnumeros.Text);
            //suma += num;
            //int suma = int.Parse(this.txtnumeros.Text);
            this.suma += int.Parse(boton.Text);
            //this.txtnumeros.Text = suma.ToString();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            this.txtnumeros.Text = this.suma.ToString();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            foreach (Button boton in this.botones)
            {
                boton.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                this.suma = 0;
                this.txtnumeros.Text = "0";
            }
        }
    }
}
