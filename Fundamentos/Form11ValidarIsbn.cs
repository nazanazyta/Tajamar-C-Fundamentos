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
    public partial class Form11ValidarIsbn : Form
    {
        public Form11ValidarIsbn()
        {
            InitializeComponent();
        }

        private void btncomprobarisbn_Click(object sender, EventArgs e)
        {
            String cajaisbn = this.txtisbn.Text;
            if(cajaisbn.Length == 10)
            {
                int suma = 0;
                for (int i = 0; i < cajaisbn.Length; i++)
                {
                    int num = int.Parse(cajaisbn[i].ToString());
                    suma += num * (i + 1);
                }
                if (suma % 11 == 0)
                {
                    this.lbldatos.Text = "ISBN CORRECTO!!";
                }
                else
                {
                    this.lbldatos.Text = "ISBN INCORRECTO!!";
                }
            }
            else
            {
                MessageBox.Show("El número ISBN debe tener 10 caracteres");
            }
        }
    }
}
