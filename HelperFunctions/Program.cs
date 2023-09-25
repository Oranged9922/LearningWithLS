using Newtonsoft.Json;

namespace HelperFunctions;

public class HelperFunctionsClass
{
    private static Random Random { get; set; } = new Random();
    private static HashSet<string> RandomEmployeeNames = new()
    {
        "Alice", "Bob", "Charlie", "David", "Eva",
        "Frank", "Grace", "Helen", "Ivy", "Jack",
        "Karen", "Leo", "Mia", "Nina", "Oscar",
        "Paul", "Quinn", "Rita", "Sam", "Tina",
        "Uma", "Vera", "Wendy", "Xavier", "Yvonne",
        "Zack", "Aaron", "Bella", "Caleb", "Diana",
        "Ethan", "Fiona", "George", "Hannah", "Isaac",
        "Julia", "Kevin", "Linda", "Michael", "Nancy",
        "Olivia", "Peter", "Queenie", "Robert", "Sarah",
        "Thomas", "Ursula", "Victor", "Winnie", "Xander",
        "Yolanda", "Zoe", "Adam", "Ben", "Cathy", "David",
        "Daniel", "Emily", "Fred", "Gina", "Henry", "Iris",
        "John", "Kathy", "Liam", "Mason", "Nathan", "Owen",
        "Patrick", "Quentin", "Rachel", "Steven", "Tracy",
        "Ulysses", "Vincent", "Walter", "Xavier", "Yvonne",
        "Zachary", "Abby", "Bobby", "Cindy", "Dennis", "Eric",
        "Felix", "Gloria", "Hank", "Irene", "Jason", "Kelly",
        "Lily", "Maggie", "Natalie", "Olive", "Peggy", "Quincy",
        "Randy", "Sally", "Terry", "Ursula", "Vivian", "Wendy",
        "Xena", "Yolanda", "Zelda", "Amanda", "Brenda", "Cathy",
        "Derek", "Eddie", "Fiona", "Gordon", "Helen", "Ivy",
        "Jenny", "Kenny", "Linda", "Mandy", "Nora", "Oscar",
        "Patty", "Quinn", "Rita", "Sandy", "Tina", "Uma",
        "Vera", "Wendy", "Xavier", "Yvonne", "Zack", "Aaron",
        "Bella", "Caleb", "Diana", "Ethan", "Fiona", "George",
        "Hannah", "Isaac", "Julia", "Kevin", "Linda", "Michael",
        "Nancy", "Olivia", "Peter", "Queenie", "Robert", "Sarah",
        "Thomas", "Ursula", "Victor", "Winnie", "Xander", "Yolanda",
        "Zoe", "Adam", "Ben", "Cathy", "David", "Daniel", "Emily",
    };

    private static HashSet<string> RandomProjectNames = new()
    {
        "Apollo", "Borealis", "Cosmos", "Delta", "Epsilon",
        "Falcon", "Galaxy", "Helix", "Icarus", "Jupiter",
        "Kronos", "Lunar", "Meteor", "Nebula", "Orion",
        "Pegasus", "Quantum", "Rocket", "Saturn", "Titan",
        "Uranus", "Venus", "Warp", "Xenon", "Yankee",
        "Zulu", "Aurora", "Borealis", "Cosmos", "Delta",
        "Epsilon", "Falcon", "Galaxy", "Helix", "Icarus",
        "Jupiter", "Kronos", "Lunar", "Meteor", "Nebula",
        "Orion", "Pegasus", "Quantum", "Rocket", "Saturn",
        "Titan", "Uranus", "Venus", "Warp", "Xenon",
        "Project A", "Project B", "Project C", "Project D",
        "Project E", "Project F", "Project G", "Project H",
        "Project I", "Project J", "Project K", "Project L",
        "Project M", "Project N", "Project O", "Project P",
        "Project Q", "Project R", "Project S", "Project T",
        "Project U", "Project V", "Project W", "Project X",
        "Project Y", "Project Z", "Project AA", "Project BB",
        "Project CC", "Project DD", "Project EE", "Project FF",
        "Project GG", "Project HH", "Project II", "Project JJ",
        "Project KK", "Project LL", "Project MM", "Project NN",
        "Project OO", "Project PP", "Project QQ", "Project RR",
        "Project SS", "Project TT", "Project UU", "Project VV",
        "Project WW", "Project XX", "Project YY", "Project ZZ",
        "Project AAA", "Project BBB", "Project CCC", "Project DDD",
        "Project EEE", "Project FFF", "Project GGG", "Project HHH",
        "Project III"
    };
    public HelperFunctionsClass(int seed)
    {
        Random = new Random(seed);
    }
    public int GetRandomInt()
    {
        return Random.Next();
    }

    public int GetRandomInt(int max)
    {
        return Random.Next(max);
    }

    public int GetRandomInt(int min, int max)
    {
        return Random.Next(min, max);
    }


    public char GetRandomChar()
    {
        return (char)Random.Next(65, 91);
    }

    public string GetRandomString(int length)
    {
        string randomString = "";
        for (int i = 0; i < length; i++)
        {
            randomString += GetRandomChar();
        }
        return randomString;
    }

    public string GetRandomString(int minLength, int maxLength)
    {
        int length = Random.Next(minLength, maxLength);
        return GetRandomString(length);
    }

    public string GetRandomString()
    {
        return GetRandomString(5, 10);
    }

    public string GetRandomEmployeeName()
    {
        return RandomEmployeeNames.ToList()[GetRandomInt(RandomEmployeeNames.Count)];
    }

    public string GetRandomProjectName()
    {
        return RandomProjectNames.ToList()[GetRandomInt(RandomProjectNames.Count)];

    }

    public object ToJson(object? result)
    {
        return JsonConvert.SerializeObject(result, Formatting.Indented);
    }
}