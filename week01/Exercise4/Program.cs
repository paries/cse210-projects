using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            String userInput = Console.ReadLine();
            int input = int.Parse(userInput);
            if ( input == 0)
            {
                break;
            }
            numbers.Add(input);
        }while(true);

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if ( number > largest)
            {
                largest = number;
            }
        }
        float avg = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        
        numbers.Sort();
        
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }


    }
}