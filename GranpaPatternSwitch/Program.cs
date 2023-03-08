using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            string question = Console.ReadLine();


            string response = question switch
            {
                "How are you ?" => "I`m fine , thank you",
                "What`s your name ?" => "Gran ` pa",
                "what`s your mission ?" => "Destroy Mankind",
                _ => "You got me , i am not that smart",


            };


            Console.WriteLine(response);


        }
    }
}
