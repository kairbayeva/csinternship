using System;
using System.Collections.Generic;

interface IPart
{
    void Build();
}

interface IWorker
{
    void Work(IPart part);
}
public class Basement : IPart
{
    public void Build()
    {
        Console.WriteLine("The basement is built");
    }
}

public class Walls : IPart
{
    public void Build()
    {
        Console.WriteLine("The walls is built");
    }
}

public class Door : IPart
{
    public void Build()
    {
        Console.WriteLine("The door is built");
    }
}

public class Window : IPart
{
    public void Build()
    {
        Console.WriteLine("The window is built");
    }
}

public class Roof : IPart
{
    public void Build()
    {
        Console.WriteLine("The roof is built");
    }
}

public class Worker : IWorker
{
    private string name;

    public Worker(string name)
    {
        this.name = name;
    }

    public void Work(IPart part)
    {
        part.Build();
        Console.WriteLine($"{name} is build {part.GetType().Name}");
    }
}

public class TeamLeader : IWorker
{
    private string name;

    public TeamLeader(string name)
    {
        this.name = name;
    }

    public void Work(IPart part)
    {
        Console.WriteLine($"{name} is checked and reported completion of work");
    }
}

public class Team
{
    private List<IWorker> members = new List<IWorker>();

    public void AddMember(IWorker member)
    {
        members.Add(member);
    }

    public void Work(IPart part)
    {
        foreach (var member in members)
        {
            member.Work(part);
        }
    }
}

public class House
{
    private Basement basement = new Basement();
    private Walls walls = new Walls();
    private Door door = new Door();
    private List<Window> windows = new List<Window> { new Window(), new Window(), new Window(), new Window() };
    private Roof roof = new Roof();

    public void Build(Team team)
    {
        team.Work(basement);
        team.Work(walls);
        team.Work(door);
        foreach (var window in windows)
        {
            team.Work(window);
        }
        team.Work(roof);
    }
}

public class Program
{
    static void Main()
    {
        Team team = new Team();
        team.AddMember(new Worker("Worker 1"));
        team.AddMember(new Worker("Worker 2"));
        team.AddMember(new TeamLeader("TeamLeader"));

        House house = new House();
        house.Build(team);
    }
}
