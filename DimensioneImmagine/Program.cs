using System;

namespace DimensioneImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            double colorazione, larghezza, altezza, pixel, b, kb;
            pixel = 0;
            kb = 0;
            Console.WriteLine("Choose the coloring of your image between 1-24 bit:");
            colorazione = double.Parse(Console.ReadLine());
            
            Console.Write("Choose the width of your image: ");
            larghezza = double.Parse(Console.ReadLine());
            if (larghezza > 0)
            {
                Console.Write("Choose the height of your image:");
                altezza = int.Parse(Console.ReadLine());
                if (altezza > 0)
                {
                    pixel = larghezza * altezza;
                    b = colorazione / 8;
                    kb = (pixel * b) / 1024;
                    Console.WriteLine($"The pixel of your image are: {pixel}, your image has {kb} kilobyte.");
                }
                else
                {
                    Console.WriteLine("Height not valid.");
                }
            }
            else
            {
                Console.WriteLine("Width not valid.");
            }

        }
    }
}
