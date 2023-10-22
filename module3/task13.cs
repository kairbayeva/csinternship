using System;

namespace Module03
{
    internal class task13
    {
        static void Main()
        {
            string input = "Это строка с / и \\ символами.";

            string result = input.Replace("/", "").Replace("\\", "");

            Console.WriteLine("input string: " + input);
            Console.WriteLine("result string: " + result);
            Console.ReadKey();
        }
    }
}
