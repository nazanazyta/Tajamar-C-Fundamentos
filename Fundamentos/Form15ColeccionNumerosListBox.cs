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
    public partial class Form15ColeccionNumerosListBox : Form
    {
        public Form15ColeccionNumerosListBox()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            this.lstnumeros.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(1,20);
                this.lstnumeros.Items.Add(num);
            }
            this.txtsuma.Text = "";
            this.txtpares.Text = "";
            this.txtimpares.Text = "";
        }

        private void btndatos_Click(object sender, EventArgs e)
        {
            int suma = 0; int pares = 0; int impares = 0;
            foreach (object obj in this.lstnumeros.Items)
            {
                int num = (int)obj;
                suma += num;
                if(num % 2 == 0)
                {
                    pares += num;
                }
                else
                {
                    impares += num;
                }
            }
            this.txtsuma.Text = suma.ToString();
            this.txtpares.Text = pares.ToString();
            this.txtimpares.Text = impares.ToString();
        }

        private void btnseleccionados_Click(object sender, EventArgs e)
        {
            int suma = 0; int pares = 0; int impares = 0;
            foreach (object obj in this.lstnumeros.SelectedItems)
            {
                int num = (int)obj;
                suma += num;
                if (num % 2 == 0)
                {
                    pares += num;
                }
                else
                {
                    impares += num;
                }
            }
            this.txtsuma.Text = suma.ToString();
            this.txtpares.Text = pares.ToString();
            this.txtimpares.Text = impares.ToString();
        }
    }
}
