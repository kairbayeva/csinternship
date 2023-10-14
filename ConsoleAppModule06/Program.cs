using ClassLibraryModule6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("User", "User", 30, 1);
            string personInfo = PersonUtility.GetPersonInfo(person);
            Console.WriteLine(personInfo);
            Console.ReadKey();
        }
    }
}