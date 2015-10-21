using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFiguras.Clases
{
   public class Rectangulo:Figura
    {
       public double Alto { get; set; }
        public double Ancho { get; set; }

        public Rectangulo() : base("Un rectangulo")
        {
        }

        public override double Area()
       {
           return Alto*Ancho;
       }

       public override double Perimetro()
       {
           return 2*(Ancho + Alto);
       }
    }
}
