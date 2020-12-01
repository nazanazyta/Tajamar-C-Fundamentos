using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        #region CONSTRUCTOR
        public Mes() { }
        public Mes(String nom, int max, int min)
        {
            this.Nombre = nom;
            this.Maxima = max;
            this.Minima = min;
            //this.Media = (max + min) / 2;
        }
        #endregion
        #region PROPIEDADES
        public String Nombre { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }
        //public double Media { get; set; }
        public double GetMedia()
        {
            return (this.Maxima + this.Minima) / 2;
        }
        #endregion
    }
}
