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
            // .SelectedItems --> ES UN TIPO Object
            foreach (object obj in this.lstelementos.SelectedItems)
            {
                items += obj + ",";
            }
            this.lblindices.Text = indices.Trim(',');
            this.lblseleccionados.Text = items.Trim(',');
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //VAMOS A RECORRER TODOS LOS ÍNDICES SELECCIONADOS
            //RECORREMOS .SelectedIndices
            //TODOS LOS ELEMENTOS ESTÁN EN LA COLECCIÓN .Items
            //foreach (int indice in this.lstelementos.SelectedIndices)
            //{
            //    this.lstelementos.Items.RemoveAt(indice);
            //}
            //SIEMPRE QUE ELIMINEMOS VARIOS ELEMENTOS DE UNA COLECCIÓN DEBEMOS
            //REALIZAR LA ACCIÓN A LA INVERSA, EMPEZANDO POR EL ÚLTIMO ELEMENTO
            //PARA QUE EL REPOSICIONAMIENTO DE ÍNDICES NO AFECTE AL ORDEN
            int numelementos = this.lstelementos.SelectedIndices.Count - 1;
            for (int i = numelementos; i >= 0; i--)
            {
                //int indseleccionado = this.lstelementos.SelectedIndices[i];
                //this.lstelementos.Items.RemoveAt(indseleccionado);
                this.lstelementos.Items.RemoveAt(this.lstelementos.SelectedIndices[i]);
            }
        }
    }
}
