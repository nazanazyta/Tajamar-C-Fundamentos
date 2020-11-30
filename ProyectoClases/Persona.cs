using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    //SI NO TIENE MODIFICADOR DE PRIVACIDAD
    //ES PRIVADO POR DEFECTO
    public class Persona
    {
        #region PROPIEDADES
        //TODO LO QUE PONGAMOS AQUÍ, PODEMOS COLAPSAR
        //Y DESPLEGAR CON EL (-) DE LA IZQUIERDA
        //
        //CAMPOS DE LA CLASE
        //UN CAMPO SUELE SER PRIVADO Y HERRAMIENTA
        //PARA LA CLASE (ES UNA VARIABLE)
        //  MODIFICADORES DE ACCESO TIENE QUE VER CON
        //  LA ENCAPSULACIÓN. public, private
        //public String Nombre;
        //public int Edad;
        //EN VISUAL STUDIO, NO SE CREAN CAMPOS ACCESIBLES,
        //SIEMPRE SE CREAN PROPIEDADES
        //UNA PROPIEDAD ES UN CAMPO, PERO CONTIENE UN CÓDIGO
        //DONDE NOS PERMITE PODER CONTROLAR ELEMENTOS
        //(getter y setter, PERO CON OTRA SINTAXIS)
        //SINTAXIS DE PROPIEDAD:
        //PROPIEDADES SON SIEMPRE public
        //public TipoDatp NombrePropiedad
        //{
        //    get { return valor;  }
        //    set
        //    {
        //        //TENEMOS value PARA RECUPERAR EL DATO
        //    }
        //}
        //
        //LAS PROPIEDADES SIEMPRE TENDRÁN UN CAMPO DE CONTROL
        //EL CAMPO SERÁ PRIVADO PARA LA CLASE Y SERÁ EL
        //ENCARGADO DE MANEJAR LA PROPIEDAD.
        //SI YO LO DESEO, ASIGNO EL CAMPO, SI NO, NO LO HAGO.
        //LOS CAMPOS DE PROPIEDAD SE REPRESENTAN CON _Propiedad
        private String _Nombre;
        public String Nombre
        {
            get {
                //DEVOLVEMOS UN VALOR
                return this._Nombre;
            }
            set {
                //ESTABLECEMOS UN VALOR
                this._Nombre = value;
            }
        }

        //CAMPO DE LA PROPIEDAD
        private int _Edad;

        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //TENEMOS UN CÓDIGO PARA CONTROLAR LOS
                //VALORES ASIGNADOS A LA PROPIEDAD
                if (value < 0)
                {
                    //DAMOS UN VALOR POR DEFECTO Y EL PROGRAMADOR 
                    //NO LO SABE. NO LE DAMOS NINGÚN TOQUE
                    //this._Edad = 0;
                    //throw new TipoException
                    //Clase base es Exception
                    throw new Exception("Edad negativa: " + value);
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion
    }
}
