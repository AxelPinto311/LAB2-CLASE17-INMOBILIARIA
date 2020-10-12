using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Inmuebles
    {
        private double metrosCuadrados;
        private string direccion;
        private int antiguedad;


        public Inmuebles(double metrosCuadrados, string direccion,int antiguedad)
        {
            this.metrosCuadrados = metrosCuadrados;
            this.direccion = direccion;
            this.antiguedad = antiguedad;
        }
        

        public string getDireccion()
        {
            
            return this.direccion;
        }

        public double getAntiguedad()
        {
            return this.antiguedad;
        }
        public double getMetrosCuadrados()
        {
            return this.metrosCuadrados;
        }
    }
}
