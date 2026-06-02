partial class Program
{
  static void Properties()
  {
    Animal animal = new Animal("Forest");
    animal.Species = "wolf";
    animal.Age = 5;
    WriteLine($"Where does the {animal.Species} live? It lives in the {animal.Habitat} and is a {animal.Category}. It is {animal.Age} years old.");
  }
}

class Animal
{
  //properties
  public string Species{get; set;}= "Unknown";
  public string Category{get;} = "Mammal";
  private int age;

  public int Age
  {
    get {return age;}
    set
    {
      if(value < 0)
      {
        throw new ArgumentException("Age cannot be negative.");
      }
      age = value;
    }
  }

  public string Habitat {get;}

  public Animal(String habitat)
  {
    Habitat = habitat;
  }
}