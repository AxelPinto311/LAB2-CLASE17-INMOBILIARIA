using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Piso :Inmuebles
    {
        private int nroPiso;
       
       

        public Piso(int nroPiso,string direccion,double metrosCuadrados,int antiguedad)
            :base(metrosCuadrados,direccion,antiguedad)
        {
            this.nroPiso = nroPiso;
            
        }

        
        public int getNropiso()
        {
            return this.nroPiso;
        }

        public double Resultado(int antiguedad,int nroPiso)
        {
            double precioBase = 20000;
            double total=precioBase;
            if (antiguedad<15)
            {
                total = total-((1 * precioBase) / 100);
            }
            else
            {
                total = total - ((2 * precioBase) / 100);
            }
            if (nroPiso >= 3)
            {
                total = total + ((3 * total) / 100);
            }
            return total;
        }
    }
}
