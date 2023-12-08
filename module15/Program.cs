using System;
using System.Collections.Generic;
using System.Reflection;

namespace module15
{
    class MyClass
    {
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
    }

    class Program
    {
        static void Main()
        {
            PrintConsoleMethods();
            DemonstrateReflectionWithMyClass();
            DemonstrateSubstringWithReflection();
            PrintListConstructors();
        }

        static void PrintConsoleMethods()
        {
            Type consoleType = typeof(Console);
            MethodInfo[] methods = consoleType.GetMethods();

            Console.WriteLine("Console Methods:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }

        static void DemonstrateReflectionWithMyClass()
        {
            MyClass myObject = new MyClass();
            myObject.MyProperty1 = 42;
            myObject.MyProperty2 = "Hello, Reflection!";

            Type myType = myObject.GetType();
            PropertyInfo[] properties = myType.GetProperties();

            Console.WriteLine("MyClass Properties:");
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(myObject)}");
            }
            Console.WriteLine();
        }

        static void DemonstrateSubstringWithReflection()
        {
            string myString = "Hello, Reflection!";
            Type stringType = typeof(string);
            MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });
            string result = (string)substringMethod.Invoke(myString, new object[] { 0, 5 });

            Console.WriteLine($"Substring Result: {result}");
            Console.WriteLine();
        }

        static void PrintListConstructors()
        {
            Type listType = typeof(List<>);
            ConstructorInfo[] constructors = listType.GetConstructors();

            Console.WriteLine("List<T> Constructors:");
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor);
            }
        }
    }
}
