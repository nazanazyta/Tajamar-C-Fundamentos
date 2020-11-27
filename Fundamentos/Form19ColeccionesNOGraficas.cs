using System;
using System.Collections;
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
    public partial class Form19ColeccionesNOGraficas : Form
    {
        public Form19ColeccionesNOGraficas()
        {
            InitializeComponent();

            this.button2.Click += RealizarClick;

            //COLECCIÓN DE OBJETOS
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            //SI QUEREMOS CAMBIAR EL COLOR DE FONDO
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            //UN BUCLE EACH PERMITE LA CONVERSIÓN
            //DE OBJECT A CLASE DEFINIDA
            //foreach (Button boton in coleccion)
            //{
            //    boton.BackColor = Color.LightGreen;
            //}
            //foreach (Control boton in coleccion)
            //{
            //    boton.BackColor = Color.LightGreen;
            //}

            //COLECCIONES GENÉRICAS SON MÁS EFICIENTES
            //TIENEN TIPADO Y MÁS FÁCIL DETECTAR ERRORES
            //EN COMPILACIÓN
            //List<Button> botones = new List<Button>();
            //botones.Add(this.button1);
            //botones.Add(this.button2);
            //botones.Add(this.button3);
            //botones[0].BackColor = Color.LightCoral;
            //EL COMPILADOR DETECTA ERRORES DE PROGRAMACIÓN
            //botones.Add(this.button1);
            List<Control> botones = new List<Control>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones[0].BackColor = Color.LightCoral;
            botones.Add(this.textBox1);
            foreach (Control control in botones)
            {
                control.BackColor = Color.LightBlue;
                //Y SI DESEAMOS REALIZAR ALGO SOLO
                //CON LOS EL TEXTBOX???
                //PARA PREGUNTAR SI UN OBJETO ES DE UNA
                //CLASE DETERMINADA SE UTILIZA EL
                //OPERADOR is
                if(control is TextBox)
                {
                    control.BackColor = Color.LightGoldenrodYellow;
                    //LA CLASE TEXTBOX TIENE UN MÉTODO QUE ES .Parse()
                    //PEGA DEL PORTAPAPELES EN LA CAJA
                    ((TextBox)control).Paste();
                }
            }
        }

        private void RealizarClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("Hola");
        }
    }
}
