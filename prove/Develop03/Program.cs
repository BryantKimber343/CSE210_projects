
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    { 
        Timer watch = new Timer();

        List<Scripture> _scriptures = new List<Scripture>();
        Scripture scripture1 = new Scripture("1 Now behold, a marvelous work is about to come forth among the children of men.\n2 Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day.\n3 Therefore, if ye have desires to serve God ye are called to the work;", "D&C 4:1-3");
        Scripture scripture2 = new Scripture("1 And now it came to pass that when Jesus had spoken these words he looked round about again on the multitude, and he said unto them: Behold, my time is at hand.\n2 I perceive that ye are weak, that ye cannot understand all my words which I am commanded of the Father to speak unto you at this time.\n3 Therefore, go ye unto your homes, and ponder upon the things which I have said, and ask of the Father, in my name, that ye may understand, and prepare your minds for the morrow, and I come unto you again.", "3 Nephi 17:1-3");
        Scripture scripture3 = new Scripture("34 Therefore fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail.\n35 Behold, I do not condemn you; go your ways and sin no more; perform with soberness the work which I have commanded you.\n 36 Look unto me in every thought; doubt not, fear not.", "D&C 6:34-36");
        Scripture scripture4 = new Scripture("38 This is the first and great commandment.\n39 And the second is like unto it, Thou shalt love thy neighbour as thyself.\n40 On these two commandments hang all the law and the prophets.", "Matthew 22:38-40");
        Scripture scripture5 = new Scripture("1 Upon you my fellow servants, in the name of Messiah I confer the Priesthood of Aaron, which holds the keys of the ministering of angels, and of the gospel of repentance, and of baptism by immersion for the remission of sins; and this shall never be taken again from the earth, until the sons of Levi do offer again an offering unto the Lord in righteousness.", "D&C 13:1");
        
        _scriptures.Add(scripture1);
        _scriptures.Add(scripture2);
        _scriptures.Add(scripture3);
        _scriptures.Add(scripture4);
        _scriptures.Add(scripture5);

        Console.Clear();
        
        
        bool done = false;
        Random random = new Random();
        int index = random.Next(0, _scriptures.Count);

        watch.Start();
        while(!done && !_scriptures[index].IsFinished())
        {
            Console.Clear();
            _scriptures[index].Display();
            Console.Write("Press enter to continue, or type 'quit' to exit");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                done = true;
            }
            for (int i = 0; i < 3; i++)
            {
                _scriptures[index].HideWord();
            }
        }
        watch.Stop();
        Console.Clear();
        _scriptures[index].Display();

        double elapsedTime = watch.GetTimePassed();
        Console.WriteLine($"Congratulations it took you {Math.Round(elapsedTime,2)} seconds to complete the scripture");  
    }
    
}