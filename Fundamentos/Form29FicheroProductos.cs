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

namespace Fundamentos
{
    public partial class Form29FicheroProductos : Form
    {
        List<Producto> productos;
        int indice;
        public Form29FicheroProductos()
        {
            InitializeComponent();
            this.productos = new List<Producto>();
        }

        private void btninsertarproducto_Click(object sender, EventArgs e)
        {
            String nombre = this.txtnombre.Text;
            int precio = int.Parse(this.txtprecio.Text);
            Producto producto = new Producto();
            producto.Nombre = nombre;
            producto.Precio = precio;
            this.productos.Add(producto);
            this.txtnombre.Text = "";
            this.txtprecio.Text = "";
            this.txtnombre.Focus();
            this.CargarProductos();
        }

        private void CargarProductos()
        {
            this.lstproductos.Items.Clear();
            foreach (Producto prod in this.productos)
            {
                this.lstproductos.Items.Add(prod.Nombre);
            }
            this.lbldatos.Text = "Producto 1 de " + this.productos.Count;
        }

        private async void btnguardarproductos_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                String path = save.FileName;
                FileInfo file = new FileInfo(path);
                using (TextWriter writer = file.CreateText())
                {
                    await writer.WriteAsync(this.GetProductosString());
                    await writer.FlushAsync();
                    writer.Close();
                }
            }
        }

        public String GetProductosString()
        {
            //nombre%precio@nombre%precio
            String datos = "";
            foreach (Producto prod in this.productos)
            {
                //nombre%precio
                String strprod = prod.Nombre + "%" + prod.Precio;
                datos += strprod + "@";
            }
            datos = datos.Trim('@');
            return datos;
        }

        private async void btnleerproductos_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using(TextReader reader = file.OpenText())
                {
                    String data = await reader.ReadToEndAsync();
                    reader.Close();
                    this.CreateProductosString(data);
                }
                this.CargarProductos();
            }
        }

        public void CreateProductosString(String data)
        {
            this.productos.Clear();
            //nombre%precio@nombre%precio
            String[] datosproductos = data.Split('@');
            foreach (String dato in datosproductos)
            {
                //nombre%precio
                String[] propiedades = dato.Split('%');
                Producto producto = new Producto();
                producto.Nombre = propiedades[0];
                producto.Precio = int.Parse(propiedades[1]);
                this.productos.Add(producto);
            }
        }

        private void PintarProducto()
        {
            Producto prod = this.productos[indice];
            this.txtnombre.Text = prod.Nombre;
            this.txtprecio.Text = prod.Precio.ToString();
            this.lbldatos.Text = "Producto " + (this.indice + 1)
                + " de " + this.productos.Count;
            this.lstproductos.SelectedIndex = this.indice;
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            this.indice = 0;
            this.PintarProducto();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            this.indice -= 1;
            if(this.indice < 0)
            {
                this.indice = 0;
            }
            this.PintarProducto();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            this.indice += 1;
            if(this.indice >= this.productos.Count)
            {
                this.indice = this.productos.Count - 1;
            }
            this.PintarProducto();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            this.indice = this.productos.Count - 1;
            this.PintarProducto();
        }
    }
}
