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
    public partial class Form14SeleccionMultipleListBox : Form
    {
        public Form14SeleccionMultipleListBox()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            this.lstelementos.Items.Add(this.txtelemento.Text);
            this.txtelemento.SelectAll();
            this.txtelemento.Focus();
        }

        private void btnseleccionados_Click(object sender, EventArgs e)
        {
            String indices = "";
            String items = "";
            // .SelectedIndices --> ES UN TIPO int
            foreach (int num in this.lstelementos.SelectedIndices)
            {
                indices += num + ",";
            }
            // .SelectedItems --> ES UN TIPO
        }
    }
}
