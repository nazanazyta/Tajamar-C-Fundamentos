using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        #region CONSTRUCTOR DE DIRECCIÓN
        public Direccion()
        {
            Debug.WriteLine("constructor dirección simple");
        }

        //MÚLTIPLES CONSTRUCTORES CON EL CONCEPTO DE POLIMORFISMO
        public Direccion(String calle, String ciudad)
        {
            //INICIAMOS LAS PROPIEDADES
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("constructor con dos parámetros");
        }

        public Direccion (String calle, String ciudad, int cp)
            :this(calle, ciudad)
        {
            //this.Calle = calle;
            //this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("constructor con los tres parámetros");
        }
        #endregion
        //CUANDO DESEAMOS COMPROBAR ALGO,
        //UTILIZAMOS PROPIEDADES EXTENDIDAS:
        //private String _Calle;
        //public String Calle
        //{
        //    get { return this._Calle; }
        //    set
        //    {
        //        if....this._Calle = value;
        //    }
        //}
        //CUANDO NO DESEAMOS COMPROBAR VALORES DE LA PROPIEDAD,
        //SE UTILIZAN PROPIEDADES AUTOIMPLEMENTADAS:
        //UNA PROPIEDAD AUTOIMPLEMENTADA ES UNA PROPIEDAD QUE
        //NO TENEMOS QUE ESCRIBIR EL CAMPO, ESTÁ DENTRO DE LA
        //DECLARACIÓN
        public String Calle { get; set; }
        public String Ciudad { get; set; }
        public int CodigoPostal { get; set; }
    }
}
