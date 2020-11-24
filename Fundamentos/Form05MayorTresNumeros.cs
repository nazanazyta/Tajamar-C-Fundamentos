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
    public partial class Form05MayorTresNumeros : Form
    {
        public Form05MayorTresNumeros()
        {
            InitializeComponent();
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            //CAPTURAMOS LOS NÚMEROS DE LOS TEXTBOX
            int num1 = int.Parse(this.txtnum1.Text);
            int num2 = int.Parse(this.txtnum2.Text);
            int num3 = int.Parse(this.txtnum3.Text);
            int mayor, menor, intermedio;
            //EVALUAMOS EL NÚMERO MAYOR
            if(num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }else if(num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }
            //EVALUAMOS EL NÚMERO MENOR
            if(num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }else if(num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }
            int suma = num1 + num2 + num3;
            intermedio = suma - mayor - menor;
            //this.lblresultado.Text = mayor.ToString();
            this.lblresultado.Text = "Mayor: " + mayor
                    + "\nMenor: " + menor
                    + "\nIntermedio: " + intermedio;
        }
    }
}
