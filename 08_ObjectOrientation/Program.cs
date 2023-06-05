// The eighth project, "ObjectOrientation", would introduce the
// basics of Object-Oriented Programming (OOP). It will focus on
// classes, objects, properties, methods, and constructors. 

namespace _08_ObjectOrientation;
public class Program
{
    public static void Main(string[] args)
    {
        // Introduction to objects
        Dog myDog = new Dog();
        myDog.Name = "Bingo";
        myDog.Breed = "Beagle";
        myDog.Age = 5;

        Console.WriteLine($"{myDog.Name} is a {myDog.Breed} and is {myDog.Age} years old.");

        myDog.Bark();

        // Introduction to constructors
        Dog anotherDog = new Dog("Max", "German Shepherd", 3);
        Console.WriteLine($"{anotherDog.Name} is a {anotherDog.Breed} and is {anotherDog.Age} years old.");
        anotherDog.Bark();
    }
}

class Dog
{
    // Properties
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }

    // Default Constructor
    public Dog()
    {
    }

    // Parameterized Constructor
    public Dog(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }

    // Method
    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}
