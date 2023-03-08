using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, ask me anything you want.");
            Console.WriteLine("To end session just write \"Exit\".");
            string response;
            string user_input = "";

            while (user_input.ToLower() != "exit")
            {
                Console.WriteLine("Please what do you want to know ?");
                user_input = Console.ReadLine();

                if (user_input.ToLower() == "how are you ?"){
                    response = "I am doing great thanks for asking.";
                    }
                    else if (user_input.ToLower() == "what are you ?"){
                    response = "I am a super intelligent ChatBot that can even predict the future";
                    }
                    else if (user_input.ToLower() == "can you tell something from the future ?"){
                    response = "Benfica will win the Champions League with a Gonçalo Ramos masterclass";
                    }
                    else if (user_input.ToLower() == "if you had to choose between wearing a porto shirt or the world ending what would you choose ?"){
                    response = "Goodbye World !";
                    }
                    else if (user_input.ToLower() == "exit"){
                    response = "Until next time !";
                }
                else{
                    response = "Sorry but i am not that smart. Can you please ask again ? ";
                }
                
            Console.WriteLine(response);
            
            }

        }
    }
}
