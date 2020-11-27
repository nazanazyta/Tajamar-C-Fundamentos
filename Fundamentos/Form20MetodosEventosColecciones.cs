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
    public partial class Form20MetodosEventosColecciones : Form
    {
        //int contador = 0; //MAL
        int contador;
        //NUNCA SE INSTANCIA UN OBJETO AQUÍ
        List<Button> botones; 

        public Form20MetodosEventosColecciones()
        {
            InitializeComponent();
            //LOS OBJETOS SE INSTANCIAN EN EL CONSTRUCTOR
            this.contador = 0;
            this.botones = new List<Button>();
            //this.botones.Add(this.button1);
            //this.botones.Add(this.button2);
            //this.botones.Add(this.button3);
            //COMO HABLAMOS DE COLECCIONES EN FORMS,
            //TENEMOS UNA COLECCIÓN QUE ES CONTROLS.
            //SI QUEREMOS GUARDAR TODOS LOS BOTONES DEL FORMULARIO
            //, COMO EN ESTE CASO, PODEMOS RECORRER LA COLECCIÓN
            // this.Controls Y ALMACENAR SOLO LOS BOTONES EN LA COLECCIÓN
            foreach (Control control in this.Controls)
            {
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }
        }

        //NO TIENE NADA QUE VER UN MÉTODO DE EVENTO (CUANDO)
        //CON UN MÉTODO PROPIO DE LA CLASE
        void AddEvents(bool activar)
        {
            foreach (Button boton in this.botones)
            {
                if (activar == true)
                {
                    boton.Click += MostrarMensaje;
                }
                else
                {
                    boton.Click -= MostrarMensaje;
                }
            }
        }

        private void chkasociarmetodos_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkasociarmetodos.Checked == true)
            {
                this.contador += 1;
                //this.button1.Click += MostrarMensaje;
                //foreach (Button boton in this.botones)
                //{
                //    boton.Click += MostrarMensaje;
                //}
                this.AddEvents(true);
            }
            else
            {
                this.contador -= 1;
                //this.button1.Click -= MostrarMensaje;
                //foreach (Button boton in this.botones)
                //{
                //    boton.Click -= MostrarMensaje;
                //}
                this.AddEvents(false);
            }
            this.lblnumeroeventos.Text = "Eventos: " + this.contador;
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Pulsado");
            //VIENEN VARIOS OBJETOS... CUÁNTOS CONTROLES LEEN AQUÍ??
            //CÓMO DIFERENCIAMOS CADA CONTROL INDIVIDUAL??
            //EL OBJETO QUE REALIZA LA LLAMADA AL MÉTODO
            //sender VIENE COMO UN OBJECT, PERO QUÉ ES EN REALIDAD??
            //TENEMOS ALGUNA FORMA DE CONVERTIR UN OBJECT EN BUTTON?? cast
            Button boton = (Button)sender;
            boton.BackColor = Color.LightGreen;
        }
    }
}
