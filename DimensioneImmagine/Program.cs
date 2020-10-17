using System;

namespace DimensioneImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            int colorazione, larghezza, altezza, pixel, b, kb;
            Console.WriteLine("Choose the coloring of your image");
            colorazione = int.Parse(Console.ReadLine());

            Console.Write("Choose the width of your image: ");
            larghezza = int.Parse(Console.ReadLine());
            if (larghezza > 0)
            {
                Console.Write("Choose the height of your image:");
                altezza = int.Parse(Console.ReadLine());
                if (altezza > 0)
                {
                    pixel = larghezza * altezza;
                    b=
                }
            }

        }
    }
}
