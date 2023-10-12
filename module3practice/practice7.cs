
namespace module03practice
{
    internal class practice7
    {
        static void Main()
        {
            Console.WriteLine("Введите строку длиной 20 символов:");
            string input = Console.ReadLine();

            if (input.Length != 20)
            {
                Console.WriteLine("не имеет длину 20 символов.");
            }
            else
            {
                int digitCount = CountDigits(input);
                Console.WriteLine($"Количество цифр в строке: {digitCount}");
            }

            Console.ReadKey();
        }

        static int CountDigits(string input)
        {
            int digitCount = 0;

            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    digitCount++;
                }
            }

            return digitCount;
        }
    }
}
