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
                this.cajas.Add((TextBox)control);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtnumero.Text);
            //foreach (TextBox cajita in this.cajas)
            //{

            //}
            for (int i = 0; i < this.cajas.Count; i++)
            {
                //this.cajas[i].Text = (num * (i + 1)).ToString();
                this.cajas[i].Text = i.ToString();
            }
        }
    }


}
