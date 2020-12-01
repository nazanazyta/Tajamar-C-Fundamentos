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
    public partial class Form27MesesClases : Form
    {
        List<Mes> meses;

        public Form27MesesClases()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            this.lstmeses.Items.Clear();
            this.meses.Clear();
            this.txtnombre.Text = "";
            this.txtmaxima.Text = "";
            this.txtminima.Text = "";
            this.txtmedia.Text = "";
            DateTime fecha = DateTime.Parse("01/01/2020");
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                String nommes = fecha.ToString("MMMM");
                int max = rnd.Next(10, 45);
                int min = rnd.Next(-20, 10);
                //esto iría dentro de la clase Mes
                //con propiedades extendidas
                //if (max < min)
                //{
                //    int a = min;
                //    min = max;
                //    max = a;
                //}
                Mes mes = new Mes(nommes, max, min);
                this.lstmeses.Items.Add(nommes);
                this.meses.Add(mes);
                fecha = fecha.AddMonths(1);
            }
        }

        private void lstmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mes mimes = this.meses[this.lstmeses.SelectedIndex];
            this.txtnombre.Text = mimes.Nombre;
            this.txtmaxima.Text = mimes.Maxima.ToString();
            this.txtminima.Text = mimes.Minima.ToString();
            //this.txtmedia.Text = mimes.Media.ToString();
            this.txtmedia.Text = mimes.GetMedia().ToString();
        }
    }
}
