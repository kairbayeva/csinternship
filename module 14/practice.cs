using System;
using System.Collections.Generic;

namespace module_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

           
            Dictionary<string, int> wordStatistics = GetWordStatistics(text);

            DisplayStatisticsTable(wordStatistics);

            Console.ReadKey();
        }

        static Dictionary<string, int> GetWordStatistics(string text)
        {
            string[] words = text.Split(new[] { ' ', '.', ',', '!', '?', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

          
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }

        static void DisplayStatisticsTable(Dictionary<string, int> wordStatistics)
        {
            Console.WriteLine("Статистика слов в тексте:");
            Console.WriteLine("_________________________");
            Console.WriteLine("| Слово      | Количество |");
            Console.WriteLine("___________________________");

            foreach (var pair in wordStatistics)
            {
                Console.WriteLine($"| {pair.Key,-10} | {pair.Value,-11} |");
            }

            Console.WriteLine("-------------------------");
        }
    }
}
