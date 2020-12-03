using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }

        //OVERRIDE: SOBRESCRITURA
        //CON LA PALABRA new INDICO SOBRESCRITURA
        //public new int GetVacaciones()
        //{
        //    int vacas = base.GetVacaciones();
        //    Debug.WriteLine("GetVacaciones() de Director");
        //    //return 25;
        //    return vacas + 3;
        //}
        //O TAMBIÉN CON override AQUÍ Y virtual EN LA CLASE BASE
        public override int GetVacaciones()
        {
            int vacas = base.GetVacaciones();
            Debug.WriteLine("GetVacaciones() de Director");
            //return 25;
            return vacas + 3;
        }

        //OVERLOAD: SOBRECARGA
        //SIMPLEMENTE DISTINTOS PARÁMETROS
        public int GetVacaciones(int diasextra)
        {
            return this.GetVacaciones() + diasextra;
        }
    }
}
