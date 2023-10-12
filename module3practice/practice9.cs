using System;

class practice9
{
    static void Main()
    {
        string input = Console.ReadLine();

        int wordCount = count(input);

        Console.WriteLine(wordCount);

        Console.ReadKey();
    }

    static int count(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length >= 2 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        return count;
    }
}
