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
    public partial class Form09ValidarMail : Form
    {
        public Form09ValidarMail()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            String email = this.txtemail.Text;
            if(email.Contains("@") == false)
            {
                this.lblmensaje.Text = "No existe @";
            }else if(email.StartsWith("@") || email.EndsWith("@"))
            {
                this.lblmensaje.Text = "@ al inicio o al final";
            }else if(email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblmensaje.Text = "Existe más de una @";
            }else if (email.Contains(".") == false)
            {
                this.lblmensaje.Text = "No existe punto";
            }else if(email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblmensaje.Text = "Punto después de la @";
            }
            else
            {
                int ultimopunto = email.LastIndexOf(".");
                String dominio = email.Substring(ultimopunto + 1);
                if(dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblmensaje.Text = "Mail CORRECTO!!";
                }
                else
                {
                    this.lblmensaje.Text = "Dominio de 2 a 4 letras";
                }
            }
        }
    }
}
