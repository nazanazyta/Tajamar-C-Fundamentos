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
            //this.SalarioMinimo = 800;
            //this.SalarioMinimo = 1000;
            this.SalarioMinimo = 1500;
        }

        public Empleado (String nombre, String apellidos)
            :base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO con parámetros");
            //this.Nombre = nombre;
            //this.Apellidos = apellidos;
        }
        #endregion

        #region PROPIEDADES DE EMPLEADO
        //TODOS PUEDEN VERLO
        //public int SalarioMinimo { get; set; }
        //SOLO LOS DE ESTE PROYECTO PUEDEN VERLO,
        //LO QUE INCLUYE EL FORMULARIO, OTRAS CLASES...
        //internal int SalarioMinimo { get; set; }
        //SOLO LAS CLASES QUE HEREDEN DE EMPLEADO PUEDEN VERLO
        protected int SalarioMinimo { get; set; }
        #endregion

        #region METODOS CLASE EMPLEADO
        //CON ESTE MÉTODO PERMITE AL FORMULARIO VISUALIZARLO
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        //virtual PARA INDICAR QUE SE VA A SOBRESCRIBIR
        public virtual int GetVacaciones()
        {
            Debug.WriteLine("GetVacaciones() de Empleado");
            return 22;
        }
        #endregion
    }
}
