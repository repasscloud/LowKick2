using System;

namespace loremipsum;

class Program
{
    static void Main(string[] args)
    {
        int numParagraphs = 3; // number of paragraphs to generate
        int numSentences = 5; // number of sentences to generate

        string[] words = { "Lorem", "ipsum", "dolor", "sit", "amet" };

        Random random = new Random();

        for (int i = 0; i < numParagraphs; i++)
        {
            for (int j = 0; j < numSentences; j++)
            {
                for (int k = 0; k < random.Next(5, 15); k++)
                {
                    Console.Write(words[random.Next(words.Length)] + " ");
                }
                Console.Write(". ");
            }
            Console.WriteLine("\n");
        }
    }
}

