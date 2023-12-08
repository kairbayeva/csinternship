using System;
using System.Reflection;

class MyClass
{
    private int privateField = 42;
    public string publicField = "Public Field";

    public int PublicProperty { get; set; }
    private string PrivateProperty { get; set; }

    public MyClass()
    {
      
    }

    private MyClass(int value)
    {
        this.PrivateProperty = "Private Property";
        this.PublicProperty = value;
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public Method");
    }

    private void PrivateMethod()
    {
        Console.WriteLine("Private Method");
    }

    public int CalculateSum(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        ExploreType<MyClass>();
        CreateInstanceUsingReflection();
        ManipulateObject();
        InvokePrivateMethod();
    }
    static void ExploreType<T>()
    {
        Type type = typeof(T);

        Console.WriteLine($"Имя класса: {type.Name}");

        Console.WriteLine("Конструкторы:");
        foreach (var constructor in type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(constructor);
        }

        Console.WriteLine("Поля и свойства:");
        foreach (var member in type.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            if (member is FieldInfo field)
                Console.WriteLine($"{field.FieldType} {field.Name}");
            else if (member is PropertyInfo property)
                Console.WriteLine($"{property.PropertyType} {property.Name}");
        }

        Console.WriteLine("Методы:");
        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine($"{method.ReturnType} {method.Name}");
        }

        Console.WriteLine();
    }

  
    static void CreateInstanceUsingReflection()
    {
        Type type = typeof(MyClass);
        object instance = Activator.CreateInstance(type);

        Console.WriteLine("Экземпляр MyClass создан с использованием рефлексии.");
        Console.WriteLine();
    }

  
    static void ManipulateObject()
    {
        MyClass myObject = new MyClass();

        PropertyInfo publicProperty = typeof(MyClass).GetProperty("PublicProperty");
        publicProperty.SetValue(myObject, 99);

        MethodInfo calculateSumMethod = typeof(MyClass).GetMethod("CalculateSum");
        int result = (int)calculateSumMethod.Invoke(myObject, new object[] { 5, 7 });

        Console.WriteLine($"Измененное значение PublicProperty: {myObject.PublicProperty}");
        Console.WriteLine($"Результат вызова метода CalculateSum: {result}");
        Console.WriteLine();
    }

  
    static void InvokePrivateMethod()
    {
        MyClass myObject = new MyClass();

        MethodInfo privateMethod = typeof(MyClass).GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
        privateMethod.Invoke(myObject, null);

        Console.WriteLine();
    }
}