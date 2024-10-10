using System.Data;
using System.Collections.Generic;

class PromptGenerator
{

    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person you met today?",
        "What was the best part of your day?",
        "What was the strongest emotion you felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I see the Lord\'s hand in my life today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
        
    }









}