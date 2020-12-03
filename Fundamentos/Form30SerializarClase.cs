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
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form30SerializarClase : Form
    {
        XmlSerializer serial;

        public Form30SerializarClase()
        {
            InitializeComponent();
            //EN EL MOMENTO DE INSTANCIAR EL OBJETO
            //DEBEMOS INDICAR LA CLASE QUE ALMACENAREMOS
            //  Type
            this.serial = new XmlSerializer(typeof(Producto));
        }

        private async void btnguardarproducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtproducto.Text;
            producto.Precio = int.Parse(this.txtprecio.Text);
            //PARA SERIALIZAR, EN ESTE CASO, SE UTILIZA System.IO (FICHEROS)
            //Y LA CLASE Stream (Reader, Writer)
            StreamWriter writer = new StreamWriter("producto.xml");
            //CON EL MÉTODO Serialize ALMACENAMOS UN OBJETO DE LA CLASE
            //Y GENERA UN FICHERO xml CON EL PRODUCTO
            //EL writer ES EL VEHÍCULO PARA ESCRIBIR EL FICHERO
            this.serial.Serialize(writer, producto);
            await writer.FlushAsync();
            writer.Close();
            this.txtproducto.Text = "";
            this.txtprecio.Text = "";
            this.lblinfo.Text = "Datos guardados";
        }

        private void btnleerproducto_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("producto.xml");
            //LA DESERIALIZACIÓN ES AUTOMÁTICA. NOSOTROS ENVIAMOS EL Reader
            //Y NOS DEVUELVE EL OBJETO YA INSTANCIADO
            //UTILIZAMOS EL MÉTODO Deserialize
            Producto producto = (Producto) this.serial.Deserialize(reader);
            reader.Close();
            this.txtproducto.Text = producto.Nombre;
            this.txtprecio.Text = producto.Precio.ToString();
            this.lblinfo.Text = "Producto leído";
        }
    }
}
