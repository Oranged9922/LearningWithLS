// The ninth project, "InterfaceImplementator",
// would introduce the concept of interfaces and their implementation. 
// 
// In this console application, we first define an IAnimal interface with
// Eat and Move methods. Then, we create Dog and Cat classes implementing
// this interface. Each class provides its own implementation for the Eat
// and Move methods, illustrating how different types can implement the same
// interface but provide different behaviors.

namespace _09_InterfaceImplementor;
public class Program
{

    public static void Main(string[] args)
    {
        // Introduction to interfaces and their implementation
        Dog myDog = new Dog();
        myDog.Name = "Bingo";
        myDog.Eat();
        myDog.Move();

        Cat myCat = new Cat();
        myCat.Name = "Whiskers";
        myCat.Eat();
        myCat.Move();
    }
}

// Interface definition
public interface IAnimal
{
    void Eat();
    void Move();
}

// Implementing interface in Dog class
public class Dog : IAnimal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} is running.");
    }
}

// Implementing interface in Cat class
public class Cat : IAnimal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} is jumping.");
    }
}
