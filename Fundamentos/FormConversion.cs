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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            //CONVERSIÓN AUTOMÁTICA
            double mayor = 99;
            int menor = 99;
            //SI IGUALAMOS MAYOR CAPACIDAD A MENOR, LA CONVERSIÓN
            //ES AUTOMÁTICA
            mayor = menor;
            //ERROR DE COMPILACIÓN SI LO HACEMOS AL REVÉS
            //menor = mayor;

            //CASTING ENTRE PRIMITIVOS
            //LOS PRIMITIVOS ESTÁN TODOS EN MINÚSCULAS (int, string)
            // (TIPO A CONVERTIR) OBJETO
            short mini = 44;    //MENOR
            int numero = 88;    //MAYOR
            mini = (short)numero;

            //CONVERSIÓN DE STRING A TIPO PRIMITIVO
            //UN TIPO String ES UNA CLASE (1ª LETRA MAYÚSCULA)
            //PARA PODER CONVERTIR CUALQUIER STRING A PRIMITIVO
            //SE UTILIZAN MÉTODOS DE LAS CLASES PRIMITIVAS -> Parsear
            // tipoprimitivo.Parse(String)
            String texto = "34567";
            int num = int.Parse(texto);
            double doble = double.Parse(texto);

            //CONVERTIR PRIMITIVOS (CUALQUIER CLASE EN VERDAD) A STRING
            //LA CLASE System.Object CONTIENE UN MÉTODO PARA CONVERTIR
            //A STRING: .ToString()
            //CUALQUIER OBJETO TIENE .ToString()
            int valor = 999;
            String dato = valor.ToString();
            dato = this.ToString();
            dato = this.BackColor.ToString();

            //LOS MÉTODOS PUEDEN TENER TAMBIÉN SOBRECARGA
            //MessageBox.Show("Lunes");
            MessageBox.Show("Texto", "titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
    }
}
