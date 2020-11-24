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
    public partial class Form06DiaNacimiento : Form
    {
        public Form06DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtdia.Text);
            int mes = int.Parse(this.txtmes.Text);
            int anio = int.Parse(this.txtanio.Text);
            if(mes == 1)
            {
                mes = 13;
                anio -= 1;
            }else if(mes == 2)
            {
                mes = 14;
                anio--;
            }
            int paso1 = (mes + 1) * 3 / 5;
            int paso2 = anio / 4;
            int paso3 = anio / 100;
            int paso4 = anio / 400;
            int paso5 = dia + mes * 2 + anio + paso1 + paso2 - paso3 + paso4 + 2;
            int paso6 = paso5 / 7;
            int resul = paso5 - paso6 * 7;
            switch (resul)
            {
                case 0:
                    this.lblresultado.Text = "Sábado";
                    break;
                case 1:
                    this.lblresultado.Text = "Domingo";
                    break;
                case 2:
                    this.lblresultado.Text = "Lunes";
                    break;
                case 3:
                    this.lblresultado.Text = "Martes";
                    break;
                case 4:
                    this.lblresultado.Text = "Miércoles";
                    break;
                case 5:
                    this.lblresultado.Text = "Jueves";
                    break;
                case 6:
                    this.lblresultado.Text = "Viernes";
                    break;
                default:
                    this.lblresultado.Text = "Error";
                    break;
            }
        }
    }
}
