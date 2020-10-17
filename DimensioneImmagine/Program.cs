using System;

namespace DimensioneImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            double colorazione, larghezza, altezza, pixel, b, kb, temp;
            pixel = 0;
            kb = 0;
            Console.WriteLine("Choose the coloring of your image(2,4,8,16 bit)");
            colorazione = double.Parse(Console.ReadLine());
            temp = colorazione;
            Console.Write("Choose the width of your image: ");
            larghezza = double.Parse(Console.ReadLine());
            if (larghezza > 0)
            {
                Console.Write("Choose the height of your image:");
                altezza = int.Parse(Console.ReadLine());
                if (altezza > 0)
                {
                    switch (colorazione)
                    {
                        case 2:
                            pixel = larghezza * altezza;
                            b = 2 / 8;
                            kb = (pixel * b) / 1024;
                            break;
                        case 4:
                            pixel = larghezza * altezza;
                            b = 4 / 8;
                            kb = (pixel * b) / 1024;
                            break;
                        case 8:
                            pixel = larghezza * altezza;
                            b = 8 / 8;
                            kb = (pixel * b) / 1024;
                            break;
                        case 16:
                            pixel = larghezza * altezza;
                            b = 16 / 8;
                            kb = (pixel * b) / 1024;
                            break;
                    }
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
