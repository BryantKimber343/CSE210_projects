
/*
properties:
 - date and time: string
 - prompt: string
 - response: string

methods:
 - display(): void
*/


public class Entry
{
    public string _dateAndTime = DateTime.Now.ToString();
    public string _prompt = new PromptManager().getPrompt();
    public string _response;

    

    public void displayEntry()
    {
        Console.WriteLine(_dateAndTime + "\n " + _prompt + "\n " + _response +"\n");
    }
}