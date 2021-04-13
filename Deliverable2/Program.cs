using System;

namespace Deliverable2
{
    class Program
    {
        private static string userInput;
        private static string userLowerInput;


        static void Main(string[] args)
        {
            int c1 = 1;
            int c2 = 1;
            int c3 = 1;

            Console.Write("Hello.  I'm Harry Chatter!");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("");
                Console.WriteLine("What would you like to say?   hello / sup / hello there / bye");
                Console.WriteLine("");

                userInput = Console.ReadLine();
                userLowerInput = userInput.ToLower();

                if (userLowerInput == "hello" && c1 == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Hi, good to see you!");
                    c1++;
                }

                else if (userLowerInput == "sup" && c2 == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("I am good");
                    c2++;
                }

                else if (userLowerInput == "hello there" && c3 == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("General Kenobi");
                    c3++;
                }

                else if (userLowerInput == "bye")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Good bye!");
                    Console.WriteLine("");
                }

                else if ((userLowerInput == "hello" && c1 > 1) || (userLowerInput == "sup" && c2 > 1) || (userLowerInput == "hello there" && c3 > 1))
                {
                    Console.WriteLine("");
                    Console.WriteLine("I'm sorry but you have already said that.");
                    Console.WriteLine("");
                }

                else if ((userLowerInput != "hello") || (userLowerInput != "sup") || (userLowerInput != "hello there") || (userLowerInput != "bye"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("I dont understand.");
                }
            }

            while (userLowerInput != "bye");
        }

    }
}


