using System;

enum Foodtype
{
    Carnivore,   
    Omnivore,    
    Herbivore    
}

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Foodtype TypeOfFood { get; set; }

    public Animal(string name, int age, Foodtype typeOfFood)
    {
        Name = name;
        Age = age;
        TypeOfFood = typeOfFood;
    }

    public void action()
    {
        Console.WriteLine($"{Name}, возраст {Age}, требует {TypeOfFood} пищу.");
    }
}

class action
{
    static void Main()
    {
        Animal lion = new Animal("Лев", 5, Foodtype.Carnivore);
        Animal bear = new Animal("Медведь", 10, Foodtype.Omnivore);
        Animal deer = new Animal("Олень", 3, Foodtype.Herbivore);

        lion.action();
        bear.action();
        deer.action();
    }
}
