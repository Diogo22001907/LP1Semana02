using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height : ");
            string height_input = Console.ReadLine();
            Console.WriteLine("Now please enter the radius : ");
            string radius_input = Console.ReadLine();
            
            double height;
            double radius;
            double pi = 3.1415926;

            if (double.TryParse(height_input, out height) && (double.TryParse(radius_input, out radius)))
            {
                /* Added the limit of two decimal houses to the results of both cylinder volume and the area of surface.
                The previous push to the repository has the results without the decimal houses limit.*/
                double volume = pi * Math.Pow(radius, 2) * height;
                double area_surface = 2 * pi * radius * (radius + height);
                Console.WriteLine("The volume of the cylinder is '{0:f2}'", volume);
                Console.WriteLine("The area surface of the cylinder is '{0:f2}'", area_surface);
            }

            else
            {
                Console.WriteLine("The inputs given are not correct.");
            }


        }
    }
}



