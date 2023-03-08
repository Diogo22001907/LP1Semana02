using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                int lines = 1;
                int num;
                string letter;

                if (int.TryParse(args[0], out num))
                {
                    letter = args[1];
                }

                else if (int.TryParse(args[1], out num))
                {
                    letter = args[0];
                }

                else
                {
                    Console.WriteLine("User input incorrect");
                    return;
                }

                while (lines <= num)
                {
                    Console.WriteLine(new String(letter[0], lines));
                    lines++;
                }
            }
            else
            {
                Console.WriteLine("User input incorrect");
            }
        }
    }
}
