/**
    exceed the requirements 
    1. In PromptFactory.cs I check to make sure a prompt is only used once.
    2. In Program.cs I check and make sure the menu selection is valid 
**/

class Program
{
    static void Main(string[] args)
    {
        Boolean continueLoop = true;
        PromptFactory promptFactory = new();
        Journal journal = new();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            String userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int action) && action > 0 && action < 6)
            {
                switch (action)
                {
                    case 1:
                        DateTime now = DateTime.Now;
                        String prompt = promptFactory.GetNextRandomPrompt();
                        Console.WriteLine($"{prompt} ");
                        Console.Write("> ");
                        String userResponse = Console.ReadLine();
                        journal.AddEntry(new()
                        {
                            _entry = userResponse,
                            _prompt = prompt,
                            _date = now.ToString("MM/dd/yyyy")
                        });

                        break;
                    case 2:
                        journal.Display();
                        break;
                    case 3:
                        Console.Write("What is the filename? ");
                        String filenameLoad = Console.ReadLine();
                        journal.Load(filenameLoad);
                        break;
                    case 4:
                        Console.Write("What is the filename? ");
                        String filenameSave = Console.ReadLine();
                        journal.Save(filenameSave);
                        break;
                    case 5:
                        continueLoop = false;
                        break;
                }

            }
            else
            {
                Console.WriteLine("");
            }
        } while (continueLoop);
    }
}