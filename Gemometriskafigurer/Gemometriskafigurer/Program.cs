using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemometriskafigurer
{
    public enum ShapeType { Rectangle, Ellipse };

    class Program
    {
        static void Main(string[] args) //Anropa viewmenu. Ej avsluta ->Createchape anropas
        {
            //do
            //{
            //    switch(ViewMenu())
            //    {

            //    }

            //}

        }

        private static Shape CreateShape(ShapeType shapeType) //läser in objektets längd och bredd
        {
            input = Console.ReadLine();

            
        }

       private double ReadDoubleGraterThanZero(string prompt)
        {

        }

        private void ViewMenu()
       {
           Console.WriteLine(" ╔═══════════════════════════════════╗ ");
           Console.WriteLine(" ║          Choose a form            ║ ");
           Console.WriteLine(" ╚═══════════════════════════════════╝ ");
           Console.BackgroundColor = ConsoleColor.Black;
           Console.WriteLine(" 0. Exit.");
           Console.WriteLine(" 1. Rectangle.");
           Console.WriteLine(" 2. Ellipse.");
           Console.WriteLine("\n ═══════════════════════════════════════════\n");
           Console.Write(" Ange menyval [0-2]: ");
           Console.ResetColor();
       }

        private void ViewShapeDetail(Shape shape)
        {

        }
    }
}
