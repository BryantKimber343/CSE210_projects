/*
properties:
    - prompts: List<string>

methods:
    - getPrompt(): string
*/


public class PromptManager
{
    public List<string> _prompts =
        new List<string>
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "What did you learn today?",
            "What is one thing you want to accomplish tomorrow?",
            "Describe a moment that made you smile today."
        };
    
    public string getPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }
}