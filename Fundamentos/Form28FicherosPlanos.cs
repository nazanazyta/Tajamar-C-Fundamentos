using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fundamentos
{
    public partial class Form28FicherosPlanos : Form
    {
        public Form28FicherosPlanos()
        {
            InitializeComponent();
        }

        private async void btnguardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            //ShowDialog() -->  DialogResult
            DialogResult respuesta = save.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = save.FileName;
                //LA CLASE FileInfo SIRVE PARA MANEJAR
                //CUALQUIER TIPO DE ARCHIVO
                FileInfo file = new FileInfo(path);
                //A PARTIR DEL FILEINFO PODEMOS CREAR
                //OBJETOS PARA LEER EN BYTES O PLANOS
                //VAMOS A UTILIZAR using PARA CREAR
                //EL OBJETO, UTILIZARLO Y DESTRUIRLO A LA VEZ
                using (TextWriter writer = file.CreateText())
                {
                    //ESCRIBIR
                    //writer.Write(this.txttexto.Text);
                    //await writer.WriteAsync(this.txttexto.Text);
                    await writer.WriteAsync(this.GetStringNombres());
                    //INDEPENDIENTE A TEXTO PLANO O BYTES
                    //AL ESCRIBIR DEBEMOS LIBERAR EL FLUJO DE MEMORIA
                    //Y CERRAR EL FICHERO
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstnombres.Items.Clear();
                this.txttexto.Text = "";
            }
        }

        private async void btnleerfichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    String contenido = await reader.ReadToEndAsync();
                    reader.Close();
                    this.txttexto.Text = contenido;
                    this.SetStringNombres(contenido);
                }
            }

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            String nombre = this.txtnombre.Text;
            this.lstnombres.Items.Add(nombre);
            this.txtnombre.Text = "";
            this.txtnombre.Focus();
        }

        public String GetStringNombres()
        {
            String datos = "";
            foreach (String nombre in this.lstnombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        public void SetStringNombres(String data)
        {
            //ANTONIA,MARCOS,CARLOS
            String[] nombres = data.Split(',');
            this.lstnombres.Items.Clear();
            foreach (String nombre in nombres)
            {
                this.lstnombres.Items.Add(nombre);
            }
        }

    }
}
