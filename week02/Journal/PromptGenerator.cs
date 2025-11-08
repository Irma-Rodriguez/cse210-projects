public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "What was the most exiting experience that you had today?",
            "What was the best food tha you had today?",
            "Did you have a spiritual experience today?",
            "What was the worst part of your day?",
            "What was the best part of your day?",
            "Did you learn something new today?",
            "Do you have any regrets about today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}