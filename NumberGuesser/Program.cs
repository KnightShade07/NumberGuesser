using System;
using System.Runtime.CompilerServices;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            numGuess();
            
        }

        static void numGuess()
        {
                Console.WriteLine("Think of a number, between 1 and 10, I will try and guess it!");
                bool guessingGame = true;
                //creates a new Random object.
                Random randNum = new Random();
                

                while (guessingGame)
                {
                    //creates a new random number
                    int guessedNum = randNum.Next(1, 10);
                    Console.WriteLine("Is it " + guessedNum + "?");
                    string userInput = Console.ReadLine();
                    
                    if(userInput.Equals("y"))
                    {
                        Console.WriteLine("I win!");
                        guessingGame = false;
                    }
                }
        }

    }
}

