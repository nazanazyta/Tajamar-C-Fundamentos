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
    public partial class Form07DateTime : Form
    {
        public Form07DateTime()
        {
            InitializeComponent();
            this.txtfechaactual.Text = DateTime.Now.ToString();
        }

        private void chkformato_CheckedChanged(object sender, EventArgs e)
        {
            //RECUPERAMOS LA FECHA DE LA CAJA
            DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);
            if(this.chkformato.Checked == true)
            {
                this.txtfechaactual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtfechaactual.Text = fecha.ToShortDateString();
            }
        }

        private void btnmostrarfecha_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtincremento.Text);
            DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);
            if(this.rdbdias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if(this.rdbmeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtnuevafecha.Text = fecha.ToString();
            this.lbldatos.Text = "Bisiesto: " + DateTime.IsLeapYear(fecha.Year)
                + "\nDía de la semana: " + fecha.DayOfWeek
                + "\nDía del año: " + fecha.DayOfYear;
        }
    }
}
