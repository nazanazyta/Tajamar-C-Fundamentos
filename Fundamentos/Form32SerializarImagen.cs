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

        private void btninsertarcoche_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();
            coche.Marca = this.txtmarca.Text;
            coche.Modelo = this.txtmodelo.Text;
            this.coches.Add(coche);
            this.PintarCoches();
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

        private void lstcoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstcoches.SelectedIndex != -1)
            {
                Coche coche = this.coches[this.lstcoches.SelectedIndex];
                this.txtmarca.Text = coche.Marca;
                this.txtmodelo.Text = coche.Modelo;
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
    }
}
