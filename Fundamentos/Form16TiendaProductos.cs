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
    public partial class Form16TiendaProductos : Form
    {
        public Form16TiendaProductos()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (!this.lsttienda.Items.Contains(this.txtproducto.Text))
            {
                if(this.txtproducto.Text != "")
                {
                    this.lsttienda.Items.Add(this.txtproducto.Text);
                    this.txtproducto.SelectAll();
                    this.txtproducto.Focus();
                }
                else
                {
                    this.txtproducto.Text = "";
                    this.txtproducto.Focus();
                }
            }
            else
            {
                this.txtproducto.Text = "";
                this.txtproducto.Focus();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int totalselec = this.lsttienda.SelectedIndices.Count - 1;
            for (int i = totalselec; i >= 0; i--)
            {
                this.lsttienda.Items.RemoveAt(this.lsttienda.SelectedIndices[i]);
            }
            this.txtproducto.Text = "";
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (!this.lsttienda.Items.Contains(this.txtproducto.Text))
            {
                this.lsttienda.Items[this.lsttienda.SelectedIndex] = this.txtproducto.Text;
            }
            else
            {
                this.txtproducto.Text = "";
                this.txtproducto.Focus();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.lsttienda.Items.Clear();
            this.txtproducto.Text = "";
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.lsttienda.Items)
            {
                this.lstalmacen.Items.Add(obj);
            }
            this.lsttienda.Items.Clear();
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            int totalselec = this.lsttienda.SelectedItems.Count - 1;
            for (int i = totalselec; i >= 0; i--)
            {
                this.lstalmacen.Items.Add(this.lsttienda.SelectedItems[i]);
                this.lsttienda.Items.RemoveAt(this.lsttienda.SelectedIndices[i]);
            }
            this.txtproducto.Text = "";
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            String seleccionado = this.lstalmacen.SelectedItem.ToString();
            int indice = this.lstalmacen.SelectedIndex;
            if (indice > 0)
            {
                this.lstalmacen.Items[indice] = this.lstalmacen.Items[indice - 1];
                this.lstalmacen.Items[indice - 1] = seleccionado;
                this.lstalmacen.SelectedItems.Clear();
                this.lstalmacen.SelectedItems.Add(this.lstalmacen.Items[indice - 1]);
            }
        }

        private void btnbajar_Click(object sender, EventArgs e)
        {
            String seleccionado = this.lstalmacen.SelectedItem.ToString();
            int indice = this.lstalmacen.SelectedIndex;
            if(indice < this.lstalmacen.Items.Count - 1)
            {
                this.lstalmacen.Items[indice] = this.lstalmacen.Items[indice + 1];
                this.lstalmacen.Items[indice + 1] = seleccionado;
                this.lstalmacen.SelectedItems.Clear();
                this.lstalmacen.SelectedItems.Add(this.lstalmacen.Items[indice + 1]);
            }
        }
    }
}
