/**
    exceed the requirements 
    1. Changed the breathing animation
    2. on user inputs verified the user put in the correct input values
**/


class Program
{
    static void Main(string[] args)
    {

        do
        {
            Activity activity = null;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Start breathing activity");
                Console.WriteLine(" 2. Start reflecting activity");
                Console.WriteLine(" 3. Start listing activity");
                Console.WriteLine(" 4. Quit");
                Console.Write("Select a choice from the menu: ");
                String userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int value))
                {
                    int menuItem = int.Parse(userInput);
                    if (menuItem == 1)
                    {
                        activity = new BreathingActivity();
                        break;
                    }
                    else if (menuItem == 2)
                    {
                        activity = new ReflectingActivity();
                        break;
                    }
                    else if (menuItem == 3)
                    {
                        activity = new ListingActivity();
                        break;
                    }
                    else if (menuItem == 4)
                    {
                        activity = null;
                        break;
                    }
                }
            } while (true);

            if (activity != null)
            {
                activity.DisplayStartingMessage();
                if (activity is BreathingActivity breathingActivity)
                {
                    breathingActivity.Run();
                }
                else if (activity is ReflectingActivity reflectingActivity)
                {
                    reflectingActivity.Run();
                }
                else if (activity is ListingActivity listingActivity)
                {
                    listingActivity.Run();
                }
                activity.DisplayEndingMessage();
            }
            else
            {
                break;
            }

        } while (true);
    }
}