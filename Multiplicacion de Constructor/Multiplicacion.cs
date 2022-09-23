using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_de_Constructor
{
    internal class Multiplicacion
    {
        double v1, v2;

        public Multiplicacion()
        {
        }

        public Multiplicacion(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public double multiplicar()
        {
            return v1 * v2;
        }
    }
}
