using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class practice6
    {
        static void Main()
        {
            string text = Console.ReadLine();

            char ch = '\0'; 
            int count = 0;   
            int maxCount = 0;      

            foreach (char i in text)
            {
                if (i == ch)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    ch = i;
                    count = 1;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }

            if (maxCount > 1)
            {
                Console.WriteLine($"Наибольшее количество идущих подряд одинаковых символов: {maxCount}");
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadKey();
        }
    }
}
