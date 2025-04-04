using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();
        Address address1 = new Address("USA", "California", "Los Angeles", "123 Main St");
        Address address2 = new Address("USA", "Texas", "College Station", "4302 Roxborough Place");
        Address address3 = new Address("USA", "Idaho", "Rexburg", "600 S 2nd E");

        Reception reception = new Reception("johndoe@gmail.com", "Wedding Reception", "A beautiful wedding reception", "2025-04-27", "10:00 am", address3);
        Outdoor outdoor = new Outdoor("Sunny", "Picnic", "A fun picnic in the park", "2025-05-15", "12:00 pm", address2);
        Lecture lecture = new Lecture("Dr. Smith", 400, "Science Lecture", "An informative science lecture", "2025-06-10", "2:00 pm", address1);

        Event[] events = { reception, outdoor, lecture };

        foreach (Event eventItem in events)
        {
            Console.WriteLine("Standard Display:");
            eventItem.StandardDisplay();
            Console.WriteLine("\nFull Display:");
            eventItem.FullDisplay();
            Console.WriteLine("\nShort Display:");
            eventItem.ShortDisplay();
            Console.WriteLine("\n-----------------------------------\n");
        }
        
    }
}