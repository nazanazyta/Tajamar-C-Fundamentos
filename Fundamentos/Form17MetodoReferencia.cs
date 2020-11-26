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
    public partial class Form17MetodoReferencia : Form
    {
        public Form17MetodoReferencia()
        {
            InitializeComponent();
        }

        //MÉTODO PARA COMPROBAR VALOR EN TIPOS WRAPPER
        void DobleNumero(int num)
        {
            num = num * 2;
        }

        //MÉTODO QUE RECIBE UNA CLASE POR REFERENCIA
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Fuchsia;
        }

        //MÉTODO (ANTIGUO) QUE RECIBE UN WRAPPER O PRIMITIVO
        //Y LO UTILIZA COMO REFERENCIA
        void DobleReferencia(ref int num)
        {
            num = num * 2;
        }

        //SI NECESITAMOS DEVOLVER ALGO A LA LLAMADA, NO ES UN VOID
        int GetDoble (int num)
        {
            return num * 2;
        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtnumero.Text);
            //LLAMAMOS AL MÉTODO CON LA VARIABLE POR VALOR
            //this.DobleNumero(numero);
            //LLAMAMOS AL MÉTODO (ANTIGUO) WRAPPER POR REFERENCIA
            //SI DESEAMOS ENVIAR REFERENCIA DEBEMOS INCLUIR LA PALABRA ref
            //this.DobleReferencia(ref numero);
            //this.lblresultado.Text = "Doble: " + numero;
            int doble = this.GetDoble(numero);
            this.lblresultado.Text = "Doble: " + doble;
            //LLAMAMOS AL MÉTODO QUE RECIBE UN OBJETO POR REFERENCIA
            this.CambiarColor(this.btnllamada);
        }
    }
}
