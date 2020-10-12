using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Local:Inmuebles
    {
        private int nroVentanas;

        public Local(double metrosCuadrados,string direccion,int nroVentanas, int antiguedad)
            :base(metrosCuadrados,direccion,antiguedad)
        {
            this.nroVentanas = nroVentanas;
        }
        

        public int getNroVentanas()
        {
            return this.nroVentanas;
        }



        public double Resultado(int antiguedad, int nroVentana,double metrosCuadrados)
        {
            double precioBase = 25000;
            double total = precioBase;


            if (antiguedad < 15)
            {
                total = total - ((1 * precioBase) / 100);
            }
            else
            {
                total = total - ((2 * precioBase) / 100);
            }
            if (metrosCuadrados > 50)
            {
                total = total + ((1 * total) / 100);
            }
            if (nroVentana <= 1)
            {
                total = total - ((2 * total) / 100);
            }
            else
            {
                if (nroVentana > 4)
                {
                    total = total + ((2 * total) / 100);
                }
            }
            return total;
        }
    }
}
