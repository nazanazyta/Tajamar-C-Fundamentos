using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        #region CONSTRUCTORES EMPLEADO
        public Empleado()
            :base()
        {
            Debug.WriteLine("Constructor vacío Empleado");
        }

        public Empleado (String nombre, String apellidos)
            :base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO con parámetros");
            //this.Nombre = nombre;
            //this.Apellidos = apellidos;
        }
        #endregion
    }
}
