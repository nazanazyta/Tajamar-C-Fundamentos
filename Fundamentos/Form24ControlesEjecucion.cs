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
    public partial class Form24ControlesEjecucion : Form
    {
        public Form24ControlesEjecucion()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //INSTANCIAMOS UN CONTROL CHECKBOX
            //CheckBox chk = new CheckBox();
            int posx = 10;
            for (int i = 1; i <= 5; i++)
            {
                //INSTANCIAMOS UN CONTROL CHECKBOX
                CheckBox chk = new CheckBox();
                chk.Text = rnd.Next(1, 50).ToString();
                chk.AutoSize = true;
                chk.Location = new Point(posx, 10);
                posx += 60;
                this.panel1.Controls.Add(chk);
                chk.CheckedChanged += RealizarOperacion;
            }
        }

        private void RealizarOperacion(object sender, EventArgs e)
        {
            int valor = int.Parse(this.txtvalor.Text);
            CheckBox chk = (CheckBox)sender;
            int num = int.Parse(chk.Text);
            if (chk.Checked == true)
            {
                valor += num;
            }
            else
            {
                valor -= num;
            }
            this.txtvalor.Text = valor.ToString();
        }
    }
}
