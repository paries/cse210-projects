using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            int guessCnt = 0;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
                do
                {
                    guessCnt++;
                    Console.Write("What is your guess? ");
                    String userGuess = Console.ReadLine();
                    int guess = int.Parse(userGuess);
                    if ( guess > magicNumber)
                    {
                        Console.WriteLine("Lower");                
                    }else if ( guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! in {guessCnt} tries.");
                        break;
                    }

                    if ( guessCnt >= 20)
                    {
                        Console.WriteLine($"I am sorry, to many guesses {guessCnt}. ");
                        break;
                    }
                } while ( true );
 
            Console.Write("Do you want to play again [y/n]? ");
            if ( Console.ReadLine() != "y")
            {
                break;
            }
                    
        }while(true);
   }
}