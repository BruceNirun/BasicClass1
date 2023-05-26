public class Zoo
{
    private List<Animal> animals;

    public Zoo() 
    {
        animals = new List<Animal>();
    }
    public void AddAnimal (Animal animal)
    {
        animals.Add(animal);
    }
    public void PrintAnimal()
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Desc());
        }
    }
}

public class Animal
{
    public string Species { get; set; }

    public string Color { get; set; }

    public int Leg { get; set; }

    public Animal(string species , string colot , int leg) 
    {
        Species = species;
        Color = colot;
        Leg = leg;
    }

    public string Desc()
    {
        return $"Species : {Species} Color : {Color} Leg : {Leg}";
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        Animal lion = new Animal("Lion", "Yellow", 4);
        zoo.AddAnimal(lion);

        Animal elephant = new Animal("Elephant", "Gray", 4);
        zoo.AddAnimal(elephant);

        Animal snake = new Animal("Snake", "Green", 0);
        zoo.AddAnimal(snake);

        // แสดงรายละเอียดของสัตว์ในสวนสัตว์
        zoo.PrintAnimal();
    }
}