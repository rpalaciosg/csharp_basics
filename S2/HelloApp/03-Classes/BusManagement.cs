/*
=============
🏆 Ejercicio 
=============
*/
// 1. Crear una clase "Bus" con las siguientes propiedades:
//    - Brand (public)
//    - Model (public)
//    - Year (public)
//    - Price (public)
//    - TotalKilometers (public)
//
// 2. Implementar un constructor para inicializar los valores.
// 3. Agregar un método "Drive(int kilometers)" que aumente el kilometraje.
// 5. Agregar un método "ShowPrice()" que nos devuelva el precio del bus.
// 6. Crear una clase "Fleet" que administre una lista de buses.
//    - Método para agregar buses a la flota.
//    - Método mostrar el listado de buses.
//
// 7. Instanciar al menos tres objetos de la clase Bus, agregarlos a la Fleet y simular la conducción de 5000.
// 8. Mostrar los detalles de la flota antes y después de la conducción.
partial class Program
{
  static void BusFleet()
  {
    Fleet busFleet = new Fleet();
    Bus tacoma = new Bus("Toyota", "Tacoma", 2025, 58000.00m,100000);
    Bus honda = new Bus("Honda", "Civic", 2026,37000.00m, 5000);
    Bus ford = new Bus("Ford", "Explorer", 2025, 46000.00m, 200000);
    busFleet.AddBus(tacoma);
    busFleet.AddBus(honda);
    busFleet.AddBus(ford);
    busFleet.ShowFleet();
    tacoma.Drive(5000);
    honda.Drive(5000);
    ford.Drive(5000);
    busFleet.ShowFleet();
  }

}

class Bus{
  public string? Brand {get; set;}
  public string? Model {get; set;}
  public int? Year {get; set;}
  public decimal? Price {get; set;}
  public int? TotalKilometers {get; set;}

  public Bus(string brand, string model, int year, decimal price, int totalKilometers)
  {
    Brand = brand;
    Model = model;
    Year = year;
    Price = price;
    TotalKilometers = totalKilometers;
  }
    
  public void Drive(int kilometers)
  {
    if (TotalKilometers.HasValue)
    {
      TotalKilometers += kilometers;
      WriteLine($"The bus has driven {kilometers} kilometers. Total kilometers: {TotalKilometers}");
    }
  }
  
  public decimal? ShowPrice()
  {
    WriteLine($"Precio: {Price:C}");
    return Price;
  }

}

class Fleet
{
  private List<Bus> buses = new List<Bus>();

  public void AddBus(Bus bus)
  {
    buses.Add(bus);
    WriteLine($"Added {bus.Brand} {bus.Model} to the fleet.");
  }
  
  // public List<Bus> ShowFleet()
  public void ShowFleet()
  {
    WriteLine("---- Bus list ----");
    foreach( var item in buses )
    {
      WriteLine($"Marca: {item.Brand}, Modelo: {item.Model}, Año: {item.Year}, Kilometraje: {item.TotalKilometers}");
    }
  }
}