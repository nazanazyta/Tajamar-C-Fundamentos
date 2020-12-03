using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form31SerializarColeccion : Form
    {
        XmlSerializer serial;
        Productos productos;

        public Form31SerializarColeccion()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(Productos));
            this.productos = new Productos();
        }

        public void PintarProductos()
        {
            this.lstproductos.Items.Clear();
            foreach (Producto prod in this.productos)
            {
                this.lstproductos.Items.Add(prod.Nombre);
            }
        }

        private void btninsertarproducto_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = this.txtnombre.Text;
            prod.Precio = int.Parse(this.txtprecio.Text);
            this.productos.Add(prod);
            this.PintarProductos();
            this.txtnombre.Text = "";
            this.txtprecio.Text = "";
            this.txtnombre.Focus();
        }

        private void lstproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstproductos.SelectedIndex != -1)
            {
                int indice = this.lstproductos.SelectedIndex;
                Producto prod = this.productos[indice];
                this.txtnombre.Text = prod.Nombre;
                this.txtprecio.Text = prod.Precio.ToString();
            }
        }

        private async void btnguardarproductos_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listaproductos.xml");
            this.serial.Serialize(writer, this.productos);
            await writer.FlushAsync();
            writer.Close();
            this.productos.Clear();
            this.lstproductos.Items.Clear();
            this.txtnombre.Text = "";
            this.txtprecio.Text = "";
        }

        private void btnleerproductos_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaproductos.xml");
            this.productos = (Productos)this.serial.Deserialize(reader);
            reader.Close();
            this.PintarProductos();
        }
    }
}
