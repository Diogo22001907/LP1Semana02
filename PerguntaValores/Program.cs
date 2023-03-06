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
                double volume = pi * Math.Pow(radius, 2) * height;
                double area_surface = 2 * pi * radius * (radius + height);
                Console.WriteLine("The volume of the cilinder is " + volume);
                Console.WriteLine("The area surface of the cilinder is " + area_surface);
            }

            else
            {
                Console.WriteLine("The input given are not correct.");
            }


        }
    }
}



