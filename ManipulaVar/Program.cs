using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
           if (args.Length > 0)
            {
                int x;
                if (int.TryParse(args[0], out x))
                {
                    x ++;
                    Console.WriteLine(x);
                    --x;
                    --x;
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("The input given is not valid for this operation");
                }
            }
            else
            {
                Console.WriteLine("Please enter an input");
            }
        }
    }
}
