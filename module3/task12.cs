using System;

namespace Module03
{
    internal class task12
    {
        static void Main()
        {
            string text = "class";
            char[] wordArray = text.ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] == 's')
                {
                    wordArray[i] = '1';
                }
            }

            Console.WriteLine(wordArray);
            Console.ReadKey();



        }
    }
}
