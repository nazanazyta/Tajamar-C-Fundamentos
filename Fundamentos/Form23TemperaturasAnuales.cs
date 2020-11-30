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
    public partial class Form23TemperaturasAnuales : Form
    {
        //System.Globalization.DateTimeFormatInfo mfi;
        List<int> temperaturas;

        public Form23TemperaturasAnuales()
        {
            InitializeComponent();
            //this.mfi = new System.Globalization.DateTimeFormatInfo();
            this.temperaturas = new List<int>();
        }

        private void btngenerarmeses_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse("01/01/2020");
            Random rnd = new Random();
            this.lstmeses.Items.Clear();
            this.temperaturas.Clear();
            for (int i = 1; i <= 12; i++)
            {
                //string mes = mfi.GetMonthName(i).ToString();
                string mes = fecha.ToString("MMMM").ToUpper();
                int temp = rnd.Next(-20, 45);
                this.lstmeses.Items.Add(mes + " " + temp);
                this.temperaturas.Add(temp);
                fecha = fecha.AddMonths(1);
            }
            this.txtmaxima.Text = "";
            this.txtminima.Text = "";
            this.txtmedia.Text = "";
        }

        private void btnmostrardatos_Click(object sender, EventArgs e)
        {
            int maxima, minima, media;
            maxima = this.temperaturas[0];
            minima = this.temperaturas[0];
            media = 0;
            foreach (int temp in this.temperaturas)
            {
                media += temp;
                if (temp > maxima)
                {
                    maxima = temp;
                }
                minima = Math.Min(temp, minima);
            }
            media /= this.temperaturas.Count;
            this.txtmaxima.Text = maxima.ToString();
            this.txtminima.Text = minima.ToString();
            this.txtmedia.Text = media.ToString();
            //int maxima = -20; int minima = 100; int media = 0;
            //foreach (String elem in this.lstmeses.Items)
            //{
            //    String numero = "";
            //    for(int i = 0; i < elem.Length; i++)
            //    {
            //        char c = elem[i];
            //        if (!char.IsLetter(c))
            //        {
            //            numero += c;
            //        }
            //    }
            //    numero = numero.Trim();
            //    int num = int.Parse(numero);
            //    if(num > maxima)
            //    {
            //        maxima = num;
            //    }
            //    if(num < minima)
            //    {
            //        minima = num;
            //    }
            //    media += num;
            //}
            //media /= 12;
            //this.txtmaxima.Text = maxima.ToString();
            //this.txtminima.Text = minima.ToString();
            //this.txtmedia.Text = media.ToString();
        }
    }
}
