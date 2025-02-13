using System;

/*
attributes:
_scriptures: List<Scripture>

methods:
main() void
IsFinished() void
HideWords() void
*/



class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        List<Scripture> _scriptures = new List<Scripture>();
        string scripture1 = "34 Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail.\n 35 Behold, I do not condemn you; go your ways and sin no more; perform with soberness the work which I have commanded you.\n 36 Look unto me in every thought; doubt not, fear not.";
        string scripture2 = "1 And it came to pass that I, Nephi, returned from speaking with the Lord, to the tent of my father.\n 2 And it came to pass that he spake unto me, saying: Behold I have dreamed a dream, in the which the Lord hath commanded me that thou and thy brethren shall return to Jerusalem.";
        string scripture3 = "1 And now I, Moroni, write a few of the words of my father Mormon, which he spake concerning faith, hope, and charity; for after this manner did he speak unto the people, as he taught them in the synagogue which they had built for the place of worship.";
        string scripture4 = "3 Behold, the field is white already to harvest; therefore, whoso desireth to reap, let him thrust in his sickle with his might, and reap while the day lasts, that he may treasure up for his soul everlasting salvation in the kingdom of God.\n 4 Yea, whosoever will thrust in his sickle and reap, the same is called of God.";

        Scripture s1 = new Scripture(scripture1, "D&C 6:34-36");
        Scripture s2 = new Scripture(scripture2, "1 Nephi 3:1-2");
        Scripture s3 = new Scripture(scripture3, "Moroni 7:1");
        Scripture s4 = new Scripture(scripture4, "D&C 4:3-4");

        _scriptures.Add(s1);
        _scriptures.Add(s2);
        _scriptures.Add(s3);
        _scriptures.Add(s4);

        Random random = new Random();
        int index = random.Next(0, _scriptures.Count);

        while (!_scriptures[index].IsFinished() && !done)
        {
            Console.Clear();
            _scriptures[index].Display();
            Console.Write("Type 'quit' to end the program, otherwise press enter to continue: ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                done = true;
            }
            int hiddenWords = 0;
            while(hiddenWords < 3)
            {

                _scriptures[index].HideWords();
                hiddenWords++;
                
            }
            
        }
    }
    
}