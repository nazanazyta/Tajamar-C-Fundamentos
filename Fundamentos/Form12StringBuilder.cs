using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();
            int[] numeros = new int[3] { 14, 898, 33 };
            //SUMAR TODOS LOS NÚMEROS DEL ARRAY
            int suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }
            this.lbltiempo.Text = suma.ToString();

            foreach (Control control in this.Controls)
            {
                control.BackColor = Color.Yellow;
            }
        }

        private void btnreversestring_Click(object sender, EventArgs e)
        {
            //QUEREMOS MEDIR EL TIEMPO DE EJECUCIÓN DEL PROCESO
            Stopwatch krono = new Stopwatch();
            krono.Start();
            //PACO
            String texto = this.txttexto.Text;
            for (int i = 0; i < texto.Length; i++)
            {
                //RECUPERAMOS LA ÚLTIMA LETRA
                char letra = texto[texto.Length - 1];
                //ELIMINAMOS LA ÚLTIMA LETRA
                texto = texto.Remove(texto.Length - 1);
                //INSERTAMOS LA LETRA EN LA POSICIÓN i
                texto = texto.Insert(i, letra.ToString());
            }
            this.txttexto.Text = texto;
            //NAZA
            //String texto = this.txttexto.Text;
            //for (int i = 0; i < texto.Length; i++)
            //{
            //    String caracter = texto[i].ToString();
            //    texto = texto.Insert(0, caracter);
            //    texto = texto.Remove(i + 1, 1);
            //}
            //this.txttexto.Text = texto;
            krono.Stop();
            TimeSpan intervalo = krono.Elapsed;
            this.lbltiempo.Text = "Segundos: " + intervalo.TotalSeconds
                + "\nMilisegundos: " + intervalo.TotalMilliseconds;
        }

        private void btnreversestringbuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder();
            texto.Append(this.txttexto.Text);
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }
            this.txttexto.Text = texto.ToString();
            krono.Stop();
            this.lbltiempo.Text = "Segundos: " + krono.Elapsed.TotalSeconds
                + "\nMilisegundos: " + krono.Elapsed.TotalMilliseconds;
        }
    }
}
