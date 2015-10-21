using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaFiguras.Clases;

namespace PracticaFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect=new Rectangulo()
            {
                Alto = 10,Ancho = 15
            };
            var cir=new Circulo()
            {
                Radio = 12
            };

            rect.Detalles();
            cir.Detalles();

            Console.ReadLine();

        }
    }
}
