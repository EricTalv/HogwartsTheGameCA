using System;

namespace HogwartsTheGameCA
{
    public static class Game
    {
        static void Main()
        {

            //Gameplay
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome!");
            Console.WriteLine("Pick Solution");
            Console.WriteLine("[ A ] - IF GAME\n [ B ] - IF GAME \n [ C ] - ARRAY GAME");
            Console.WriteLine("=============================================");

            string userInput = Console.ReadLine();
            

        }

        public static void IfGame()
        {
            Console.WriteLine("CHOOSE [A] [B]");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "a")
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You have chosen A! Awesome");
                Console.ResetColor();
            }

            else if (userInput.ToLower() == "b")
            {

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You have chosen B! Beautiful");
                Console.ResetColor();

            }

            else if (userInput.ToLower() == "q")
            {
                Environment.Exit(0);              
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have chosen Nothing!");
                Console.ResetColor();
            }
        }

    }
}