using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemometriskafigurer
{
    public enum ShapeType { Indefinite, Rectangle, Ellipse };

    class Program
    {
        static void Main(string[] args) //Anropa viewmenu. Ej avsluta ->Createchape anropas
        {
            int index;
            bool exit = false;
            ShapeType type = ShapeType.Indefinite;

            do
            {
                ViewMenu();
                if(int.TryParse(Console.ReadLine(), out index)&& index >= 0 && index <= 2)
                {
                    
                
                switch ()
                {
                    case 0:
                        exit = true;
                        continue;

                    case 1:
                        type = ShapeType.Rectangle;
                        break;

                    case 2:
                        type = ShapeType.Ellipse;
                        break;

                    default:
                        Debug.Assert(false, "Hantering av menyalternativet saknas.");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\n   Tryck tangent för att fortsätta   ");
                        Console.ResetColor();
                        continue;
                }
                Console.Clear();
                CreateShape();
            } while (!exit);
            }
        }

        private static Shape CreateShape(ShapeType shapeType) //läser in objektets längd och bredd
        {
            ReadDoubleGraterThanZero();
            //switch (shapetype)
            //{
            //    case ShapeType.Rectangle:
            //        return new Rectangle();

            //    case ShapeType.Ellipse:
            //        return new Ellipse();

            //    default:
            //        throw new NotImplementedException();
            //}
            int index; 

                        if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                        {
                            return index;
                        }
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 4.\n");
            
        }

       private double ReadDoubleGraterThanZero(string prompt)
        {
            
        }

        private static void ViewMenu()
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
