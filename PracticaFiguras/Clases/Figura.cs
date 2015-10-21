using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFiguras.Clases
{
   public  abstract  class Figura
    {
       public String Nombre { get; set; }

        protected Figura(String nombre)
        {
            Nombre = nombre;
        }

        public abstract double Area();
       public abstract double Perimetro();

       public void Detalles()
       {
           Console.WriteLine("{0} con area {1} y perimetro {2}"
               ,Nombre,Area(),Perimetro());
       }

    }
}
