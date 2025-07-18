using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference chapter = new Reference("2 Nephi", 28, 30);

        string verse = "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have.";

        Scripture scripture = new Scripture(chapter, verse);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}
        // Console.Clear();
        // Console.WriteLine(scripture.GetDisplayText());
        // Console.Write("Thank you");


        // Console.WriteLine(word);

        // while (true)
        // {
        //     Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        //     string test = Console.ReadLine();

        //     if (test == "")
        //     {
        //         Console.Clear();
        //         string[] palavras = word.Split();
        //         // for (int i = 0; i < word.Length; i++)
        //         // {
        //         //     Console.WriteLine(palavras[i]);
        //         // }
        //         Console.WriteLine(new string('_', word.Length));
        //     }
        //     else if (test == "quit")
        //     {
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Sorry, try again");
        //     }

        // }
//     }
// }