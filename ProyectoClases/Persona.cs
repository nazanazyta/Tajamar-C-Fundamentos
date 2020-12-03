using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region ENUMERACIONES
    public enum TipoGenero
    {
        Masculino = 0, Femenino = 1
    }

    public enum Paises
    {
        España = 0, Inglaterra = 1, Francia = 2, Argentina = 3
    }
    #endregion
    //SI NO TIENE MODIFICADOR DE PRIVACIDAD
    //ES PRIVADO POR DEFECTO
    public class Persona
    {
        #region CONSTRUCTOR
        //TODO LO QUE PONGAMOS AQUÍ, ENTRE #region Y #endregion,
        //PODEMOS COLAPSAR Y DESPLEGAR CON EL (-) DE LA IZQUIERDA
        //
        public Persona ()
        {
            Debug.WriteLine("Constructor Persona Vacío");
        }

        public Persona(int edad, String nombre, String ape)
        {
            Debug.WriteLine("Constructor Persona para cosas");
        }

        public Persona (String nombre, String apellidos)
        {
            Debug.WriteLine("Constructor PERSONA con parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #endregion
        #region PROPIEDADES
        private Direccion _Domicilio;
        public Direccion Domicilio
        {
            get { return this._Domicilio; }
            set { this._Domicilio = value; }
        }
        //HACEMOS UNA PROPIEDAD AUTOIMPLEMENTADA
        public Direccion DomicilioVacaciones { get; set; }
        
        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set {
                //DEBEMOS CONTROLAR SIEMPRE LOS VALORES
                //DE LAS ENUMERACIONES PARA VER SI
                //COINCIDEN CON NUESTRAS OPCIONES
                if(value != TipoGenero.Femenino &&
                   value != TipoGenero.Masculino)
                {
                    throw new Exception("Rango de Géneros no soportado");
                }
                this._Genero = value;
            }
        }

        private Paises _Nacionalidad;
        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set { this._Nacionalidad = value; }
        }

        //UNA PROPIEDAD INDIZADA CONTIENE MÚLTIPLES ELEMENTOS.
        //NECESITAMOS UN CAMPO PARA MANEJAR LA PROPIEDAD.
        //YO QUIERO CREAR UNA PROPIEDAD QUE CONTENGA ESPACIO
        //PARA 5 DESCRIPCIONES DE LA PERSONA.
        private String[] _Descripciones = new String[5];
        //UNA PROPIEDAD INDIZADA NO TIENE name
        //SE UTILIZA LA PALABRA this PARA CREARLA
        public String this[int indice]
        {
            get { return this._Descripciones[indice]; }
            set { this._Descripciones[indice] = value; }
        }

        //CAMPOS DE LA CLASE:
        //UN CAMPO SUELE SER PRIVADO Y HERRAMIENTA
        //PARA LA CLASE (ES UNA VARIABLE)
        //  MODIFICADORES DE ACCESO TIENE QUE VER CON
        //  LA ENCAPSULACIÓN. public, private
        //public String Nombre;
        //public int Edad;
        //EN VISUAL STUDIO, NO SE CREAN CAMPOS ACCESIBLES,
        //SIEMPRE SE CREAN PROPIEDADES.
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
        //LAS PROPIEDADES SIEMPRE TENDRÁN UN CAMPO DE CONTROL.
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

        private String _Apellidos;
        
        public String Apellidos
        {
            get { return this._Apellidos; }
            set { this._Apellidos = value; }
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

        #region MÉTODOS de la clase
        //MÉTODOS void Y MÉTODOS return
        //MÉTODOS CON PARÁMETROS OPCIONALES
        //public void MetodoParametrosOpcionales (int numero, int parametroopcional = 99) { }
        //PARA LLAMARLO SE PODRÍA HACER DE ESTAS FORMAS:
        //  * person.MetodoParametrosOpcionales(55);
        //  * person.MetodoParametrosOpcionales(55, 44);
        //  * person.MetodoParametrosOpcionales(55, parametroopcional: 66) --> Si tuviera varios
        //    parámetros opcionales, para saber a cuál se refiere
        //POLIMORFISMO!!
        //SOBRECARGA DE UN MÉTODO: UN MÉTODO TIENE DIFERENTES FORMAS
        //CUANDO UN MÉTODO TIENE DISTINTAS FORMAS, DISTINTOS CÓDIGOS.
        //EL MÉTODO DEBE LLAMARSE IGUAL Y TENER DISTINTOS PARÁMETROS Y TIPOS
        public String GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        public String GetNombreCompleto(bool ordenacion)
        {
            if(ordenacion == true)
            {
                return this.Apellidos + ", " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        #endregion
    }
}
