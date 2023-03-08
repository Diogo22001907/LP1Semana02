using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height in centimeters : ");
            string height_input = Console.ReadLine();
            Console.WriteLine("Now please enter the radius in centimeters : ");
            string radius_input = Console.ReadLine();
            
            double height;
            double radius;
            

            if (double.TryParse(height_input, out height) && (double.TryParse(radius_input, out radius)))
            {
                /* Added the limit of two decimal houses to the results of both cylinder volume and the area of surface.
                The previous push to the repository has the results without the decimal houses limit.*/
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                double area_surface = 2 * Math.PI * radius * (radius + height);
                Console.WriteLine("The volume of the cylinder is {0:f2} cm", volume);
                Console.WriteLine("The area surface of the cylinder is {0:f2} cm", area_surface);
            }

            else
            {
                Console.WriteLine("The inputs given are not correct.");
            }


        }
    }
}



