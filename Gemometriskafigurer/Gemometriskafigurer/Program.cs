﻿using System;
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
            bool exit = false;

            do
            {
                ViewMenu(); //kallar på menyn
                  
                switch (Console.ReadLine())
                {
                    case "0":
                        exit = true;
                        continue;

                    case "1":
                        //Shape shapeR = CreateShape(ShapeType.Rectangle); //skapar ett nytt objekt skickar med rectangle till createshape
                        //ViewShapeDetail(shapeR);//skriver ut både Area och Omkrets som finns i Shape-klassen
                        ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                        break;

                    case "2":
                        //Shape shapeE = CreateShape(ShapeType.Ellipse); 
                        //ViewShapeDetail(shapeE);
                        ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                        break;  
                    default: 
                        ViewErrorMessage("FEL! Välj ett flyttal mellan 0-2.");//felmeddelanden
                        ViewTryMessage("\n   Tryck valfri tangent för att prova igen   "); //prova igen vid tryck av valfri knapp
                       
                    continue;

                    
                }
                ViewTryMessage("\n   Tryck valfri tangent för att prova igen   "); //prova igen vid tryck av valfri knapp
                }while (!exit);
            
             }


        private static Shape CreateShape(ShapeType shapeType) //läser in objektets längd och bredd
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║            {0,10}             ║ ",shapeType);
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.ResetColor();
            double width = ReadDoubleGraterThanZero("Skriv in bredden:  "); //anropar ReadGreaterThanZero med en string, där kollar den metoden så att värderna stämmer
            double length = ReadDoubleGraterThanZero("Skriv in längden:  ");

            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(length, width); //Skickar längden och bredden till klassen rectangle

                case ShapeType.Ellipse:
                    return new Ellipse(length, width);

                default:
                    throw new NotImplementedException();
            }


        }

        private static double ReadDoubleGraterThanZero(string prompt)
        {
            //int value = 0;
            //string input = Console.ReadLine();
            //try
            //{
            //    value = int.Parse(input);
            //    if (value <= 0)
            //    {
            //        throw new OverflowException();
            //    }
            //    break;
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("FEL! {0} kan inte tolkas som ett heltal", input);
            //}
            //catch (OverflowException)
            //    {
            //        Console.WriteLine("FEL!! \nSkriv ett tal(med siffror) som är mer än två!\n");
            //        //view message ändrar färg om det är fel
            //    }
            // }
            //return input;
            int input;

            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out input) && input > 0)//kontrollerar att användarens tal är högre än 0
                {
                    return input;
                }
                ViewErrorMessage("Tyvärr, ditt tal måste vara större än 0.");
            } while (true);
            
            
            
            
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║          Choose a form            ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine("{0,10}","0. Exit.");
            Console.WriteLine("{0,23}", "1. Rectangle.");
            Console.WriteLine("{0,35}", "2. Ellipse.");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n  ════════════════════════════════════ \n");
            Console.ResetColor();
            Console.Write(" Ange menyval [0-2]: ");
            
        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║            Detaljer               ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine(shape);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n  ════════════════════════════════════ \n");
            Console.ResetColor();
            

        }

        private static void ViewErrorMessage(string prompt)
        {
            Console.BackgroundColor = ConsoleColor.Red; //felmeddelanden
            Console.WriteLine(prompt);
            Console.ResetColor();
        }

        private static void ViewTryMessage(string prompt)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue; //prova igen meddelande
            Console.WriteLine(prompt);
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}
