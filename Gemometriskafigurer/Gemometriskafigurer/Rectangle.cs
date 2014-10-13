using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemometriskafigurer
{
    class Rectangle : Shape 
    {
        public double Area // Räknar ut arean
        {
            get { return Length * Width; }
        }

        public double Perimeter // Räknar ut omkretsen
        {
            get { return ((2 * Length) + (2 * Width)); }
        }

        public Rectangle(double length, double width)
            : base(length, width)
        {

        }
    }
}
