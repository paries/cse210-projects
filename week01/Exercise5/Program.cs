using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        String userInput =  Console.ReadLine();
        return int.Parse(userInput);
    }

    static int SquareNumber(int numberToSquare)
    {
        return numberToSquare * numberToSquare;
    }


    static void DisplayResult(String usersName, int numberSquared)
    {
        Console.WriteLine($"{usersName}, the square of your number is {numberSquared}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        String usersName = PromptUserName();
        int usersNumber = PromptUserNumber();
        int numberSquared = SquareNumber(usersNumber);
        DisplayResult(usersName, numberSquared);
    }
}