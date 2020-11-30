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
    public partial class Form25SorteoPrimitiva : Form
    {
        List<String> apuesta;
        List<int> sorteo;
        public Form25SorteoPrimitiva()
        {
            InitializeComponent();
            this.apuesta = new List<String>();
            this.sorteo = new List<int>();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.apuesta.Clear();
            this.sorteo.Clear();
            this.lstpremiados.Items.Clear();
            int posx = 10;
            int posy = 10;
            for (int i = 1; i <= 20; i++)
            {
                Button btn= new Button();
                btn.Text = i.ToString();
                btn.AutoSize = true;
                btn.BackColor = Color.White;
                btn.Location = new Point(posx, posy);
                if(i % 5 == 0)
                {
                    posx = 10;
                    posy += 50;
                }
                else
                {
                    posx += 80;
                }
                this.panel1.Controls.Add(btn);
                btn.Click += SeleccionarNumero;
            }
        }

        private void SeleccionarNumero(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (this.apuesta.Contains(btn.Text))
            {
                btn.BackColor = Color.White;
                //this.lstpremiados.Items.Remove(btn.Text);
                this.apuesta.Remove(btn.Text);
            }
            else
            {
                if (this.apuesta.Count == 6)
                {
                    MessageBox.Show("Máximo 6 números por apuesta");
                }
                else
                {
                    btn.BackColor = Color.Yellow;
                    //this.lstpremiados.Items.Add(btn.Text);
                    this.apuesta.Add(btn.Text);
                }
            }
        }

        private void btnsorteo_Click(object sender, EventArgs e)
        {
            foreach (Button boton in this.panel1.Controls)
            {
                if (this.apuesta.Contains(boton.Text))
                {
                    boton.BackColor = Color.Yellow;
                }
                else
                {
                    boton.BackColor = Color.White;
                }
            }
            this.lstpremiados.Items.Clear();
            this.sorteo.Clear();
            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                if(this.sorteo.Count == 6)
                {
                    break;
                }
                else
                {
                    int num = random.Next(1, 21);
                    if (!this.sorteo.Contains(num))
                    {
                        this.sorteo.Add(num);
                    }
                }
            }
            foreach (int numero in this.sorteo)
            {
                if (this.apuesta.Contains(numero.ToString()))
                {
                    foreach (Button boton in this.panel1.Controls)
                    {
                        if(boton.Text == numero.ToString())
                        {
                            boton.BackColor = Color.GreenYellow;
                        }
                    }
                }
                else
                {
                    foreach (Button boton in this.panel1.Controls)
                    {
                        if (boton.Text == numero.ToString())
                        {
                            boton.BackColor = Color.Red;
                        }
                    }
                }
                this.lstpremiados.Items.Add(numero);
            }
        }
    }
}
