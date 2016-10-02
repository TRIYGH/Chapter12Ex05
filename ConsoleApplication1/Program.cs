using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************  Weight Converter  *****************\n");
            Console.Write("Please enter in # of grams: ");
            int numGrams;
            try
            {
                string input = "";
                input = Console.ReadLine();
                numGrams = int.Parse(input);

                float convRatio = 0.035274f;
                float result = 0.00f;

                result = numGrams * convRatio;

                Console.WriteLine("{0} grams equals {1} ounces", numGrams, result);

                if (result >= 16)
                {
                    double pounds = result / 16;
                    Console.WriteLine("...or {0:f2} pounds.",pounds);
                }

                Console.ReadKey();

            }
            catch (System.FormatException e)
            {
                Console.WriteLine("\nPlease enter a value (not letters) next time.\n"+e.Message);
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("\nMath Error.\n" + e.Message);
            }

            

        }
    }
}
