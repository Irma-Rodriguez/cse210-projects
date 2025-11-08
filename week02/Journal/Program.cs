using System;

// ---------------------------------
// Improvement made: It automatically adds ".txt" to filenames when saving. We can avoid user errors when adding the filename.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the journaling program!");

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.WriteLine("");
            Console.Write("Choose an option (write a number): ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("< ");
                string responce = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = responce;

                myJournal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully!");
                Console.WriteLine("");
            }

            else if (choice == "4")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("You have saved your journal successfully!");
                Console.WriteLine("");
            }

            else if (choice == "5")
            {
                Console.WriteLine("You have Quit our journaling program. See you next time!");
            }

            else
            {
                Console.WriteLine("Invalid choice, try it again!");
            }
        }

    }
}