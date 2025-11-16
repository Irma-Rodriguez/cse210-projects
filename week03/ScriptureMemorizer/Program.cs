//I addded GetTotalWords() and GetHiddenCount() methods to show how many words are hidden and to show the total of words.//

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his only begotten Son, tha whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nTap ENTER so you can hide the words or write (quit) to quit the program: ");

            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words have been hidden");

                int totalWords = scripture.GetTotalWords();
                int hiddenWords = scripture.GetHiddenWordsCount();

                Console.WriteLine($"\nYou have hidden {hiddenWords} out of {totalWords} words!");
                break;
            }
        }
    }
}
