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
    public partial class Form22TablaMultiplicar : Form
    {
        List<TextBox> cajas;

        public Form22TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    this.cajas.Add((TextBox)control);
                }
            }
            this.cajas.Reverse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtnumero.Text);
            for (int i = 1; i <= this.cajas.Count; i++)
            {
                int multi = num * i;
                //this.cajas[this.cajas.Count - i].Text = multi.ToString();
                this.cajas[i - 1].Text = multi.ToString();
            }
            this.txtnumero.SelectAll();
            this.txtnumero.Focus();
        }
    }
}
