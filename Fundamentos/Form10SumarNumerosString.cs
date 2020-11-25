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
    public partial class Form10SumarNumerosString : Form
    {
        public Form10SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            String textonumeros = this.txtcajanumeros.Text;
            int suma = 0;
            //RECORREMOS TODOS LOS CARACTERES DEL STRING
            for (int i = 0; i < textonumeros.Length; i++)
            {
                //RECUPERAMOS CADA CARÁCTER
                char caracter = textonumeros[i];
                //CONVERTIMOS EL CARÁCTER A NÚMERO
                //ESTA CONVERSIÓN RECUPERA EL CÓDIGO ASCII
                //int num = caracter;
                //NOSOTROS NECESITAMOS EL LITERAL
                int num = int.Parse(caracter.ToString());
                suma += num;
            }
            this.lblsuma.Text = suma.ToString();
        }
    }
}
