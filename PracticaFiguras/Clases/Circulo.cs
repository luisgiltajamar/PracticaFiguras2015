using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFiguras.Clases
{
    public class Circulo : Figura
    {
        public double  Radio { get; set; }

        public Circulo() : base("Circulo")
        {
        }

        public override double Area()
        {
            return Math.PI*Math.Pow(Radio,2);
        }

        public override double Perimetro()
        {
            return 2*Math.PI*Radio;
        }
    }
}
