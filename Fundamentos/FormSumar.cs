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
    public partial class FormSumar : Form
    {
        public FormSumar()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            //NECESITAMOS LOS VALORES DE LAS CAJAS
            //SON TIPO STRING Y NECESITAMOS INT
            //POR LO QUE DEBEMOS CONVERTIR STRING A INT
            //PARSEAR
            int num1, num2;
            num1 = int.Parse(this.txtnum1.Text);
            num2 = int.Parse(this.txtnum2.Text);
            int suma = num1 + num2;
            //DEBEMOS CONVERTIR INT A STRING (ToString)
            this.lblresultado.Text = suma.ToString();
        }
    }
}
