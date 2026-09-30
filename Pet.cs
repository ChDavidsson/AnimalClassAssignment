namespace AnimalClassAssignment;

public class Pet
{
    public string Name { get; set; }
    public string AnimalType { get; set; }
    public string FavoriteFood { get; set; }

public void ReadInfo()
    {
        Console.WriteLine("What is your name?");
        Name = Console.ReadLine()!;
        Console.WriteLine("What type of animal are you?");
        AnimalType = Console.ReadLine()!;
        Console.WriteLine("What is your favorite food?");
        FavoriteFood = Console.ReadLine()!;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name} and I am a {AnimalType} and my favorite food is {FavoriteFood}");
    }
}
