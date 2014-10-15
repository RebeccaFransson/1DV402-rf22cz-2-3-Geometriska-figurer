using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemometriskafigurer
{
    class Ellipse : Shape
    {
        public double Area // Räknar ut arean
        {
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }

        public double Perimeter // räknar ut omkretsen
        {
            get { return Math.PI*Math.Sqrt(2*(Length / 2)*(Length / 2)  +  2*(Width / 2)*(Width / 2));}
        }

        public Ellipse(double area, double perimeter) 
            :base(area, perimeter)
        {

        }
    }
}
