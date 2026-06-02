partial class Program
{
  static void TestingClasses()
  {
    //usando la clase
    Vehicle toyota = new Vehicle();
    toyota.Brand = "Toyota";
    toyota.Model = "Corolla";
    toyota.Year = 2020;
    toyota.ShowInfo();
    
    Vehicle jeep = new Vehicle{Brand="Jeep", Model="Wrangler", Year=2021};
    jeep.ShowInfo();
    
    Vehicle kia = new Vehicle("kia", "Sportage", 2022);
    kia.ShowInfo();
  }
}

class Vehicle
{
  //constructor
  public Vehicle(string brand, string model, int year)
  {
    Brand = brand;
    Model = model;
    Year = year;
  }
  
  public Vehicle(){}
  
  //properties
  public string? Brand {get; set;}
  public string? Model {get; set;}
  public int Year {get; set;}
  //methods
  public void ShowInfo()
  {
    WriteLine($"This Vehicle's is Brand: {Brand}, Model: {Model}, Year: {Year}");
  }
}