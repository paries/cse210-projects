using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);
        String letterGrade;
        String letterSign="";
        if ( grade >= 90 )
        {
            letterGrade = "A";
            if ( grade % 10  < 3)
            {
                letterSign = "-";
            }
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            if ( grade % 10  > 7)
            {
                letterSign = "+";
            }
            else if (grade % 10  < 3)
            {
                letterSign = "-";
            }
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            if ( grade % 10  > 7)
            {
                letterSign = "+";
            }
            else if (grade % 10  < 3)
            {
                letterSign = "-";
            }
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            if ( grade % 10  > 7)
            {
                letterSign = "+";
            }
            else if (grade % 10  < 3)
            {
                letterSign = "-";
            }
        }
        else
        {
            letterGrade = "F";
        }



        String message = "You have passed the course, Congrats";
        if (grade < 70)
        {
            message = "You have not passed. Better luck next time";
        }

        Console.WriteLine($"Your grade is a {letterGrade}{letterSign}. {message}");
    }
}