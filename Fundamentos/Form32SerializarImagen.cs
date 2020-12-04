using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form32SerializarImagen : Form
    {
        XmlSerializer serial;
        Coches coches;

        public Form32SerializarImagen()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(Coches));
            this.coches = new Coches();
        }

        private async void btninsertarcoche_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();
            coche.Marca = this.txtmarca.Text;
            coche.Modelo = this.txtmodelo.Text;
            MemoryStream ms = new MemoryStream();
            this.pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            coche.Imagen = aByte;
            await ms.FlushAsync();
            ms.Close();
            this.coches.Add(coche);
            this.PintarCoches();
            this.pictureBox1.Image.Dispose();
            this.pictureBox1.Image = null;
            this.txtmarca.Text = "";
            this.txtmodelo.Text = "";
            this.txtmarca.Focus();
        }

        public void PintarCoches()
        {
            this.lstcoches.Items.Clear();
            foreach (Coche coche in this.coches)
            {
                this.lstcoches.Items.Add(coche.Marca);
            }
        }

        private async void lstcoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstcoches.SelectedIndex != -1)
            {
                Coche coche = this.coches[this.lstcoches.SelectedIndex];
                this.txtmarca.Text = coche.Marca;
                this.txtmodelo.Text = coche.Modelo;
                MemoryStream ms = new MemoryStream(((byte[])this.coches[this.lstcoches.SelectedIndex].Imagen));
                Bitmap bm = new Bitmap(ms);
                this.pictureBox1.Image = bm;
                await ms.FlushAsync();
                ms.Close();
            }
        }

        private async void btnguardardatos_Click(object sender, EventArgs e)
        {
            SaveFileDialog ventana = new SaveFileDialog();
            if(ventana.ShowDialog() == DialogResult.OK)
            {
                String ruta = ventana.FileName;
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    this.serial.Serialize(writer, this.coches);
                    await writer.FlushAsync();
                    writer.Close();
                    this.coches.Clear();
                    this.lstcoches.Items.Clear();
                    this.txtmarca.Text = "";
                    this.txtmodelo.Text = "";
                }
            }
        }

        private void btnleerdatos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                String ruta = ventana.FileName;
                using(StreamReader reader = new StreamReader(ruta))
                {
                    this.coches = (Coches)this.serial.Deserialize(reader);
                    reader.Close();
                    this.PintarCoches();
                }
            }
        }

        private void btncargarimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            if(ventana.ShowDialog() == DialogResult.OK)
            {
                String path = ventana.FileName;
                FileInfo file = new FileInfo(path);
                this.pictureBox1.Image = Image.FromFile(path);
            }
        }
    }
}
