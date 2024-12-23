using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_Bikvadratni_uravneniq_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();


                ///  input number
                Console.WriteLine("Enter ax² + bx + c = 0");
                Console.Write("Enter a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter c: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Clear() ;


                int disc = (b * b) - (4 * a * c);
                Console.WriteLine($"a: {a} \nb: {b}  \nc: {c}  \ndiscriminant: {disc}");


                if (disc > 0)
                {
                    varonetwo(a, b, disc);
                }
                else if (disc == 0)
                {
                    varone(a, b);
                }
                else if (disc < 0)
                {
                    Console.WriteLine("There aren't any solutions");
                }
                //end
                Console.ReadKey();
            }
        }
        static void varonetwo(int a , int b , int disc)
        {
            double xone = (-b + Math.Sqrt(disc)) / (2 * a);                             
            double roundedNumberone = Math.Round(xone, 2);
            double xtwo = (-b - Math.Sqrt(disc)) / (2 * a);
            double roundedNumbertwo = Math.Round(xtwo, 2);

            Console.WriteLine($"X1 = {roundedNumberone}\nX2 = {roundedNumbertwo}");
        }
        static void varone(int a , int b)
        {
            double x = (-b) / (2*a);
            double roundedNumber = Math.Round(x, 2);
            Console.WriteLine("X = " + roundedNumber);
        }
    }
}
