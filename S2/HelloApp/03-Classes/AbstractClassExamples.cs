partial class Program
{
  // las clases abstractas sirven como basr para otras clases

  static void AbstractClassExamples()
  {
    HomeAppliance myWasher = new WashingMachine { Brand = "Samsumg"};
    HomeAppliance myMicrowave = new Microwave { Brand = "Electrolux"};
    myWasher.ShowBrand();
    myWasher.TurnOn();

    myMicrowave.ShowBrand();
    myMicrowave.TurnOn();
    
  }
}

// clase abstracta
abstract class HomeAppliance
{
  public string? Brand {get; set;}

  public abstract void TurnOn();
  public void ShowBrand()
  {
    WriteLine($"La marca del electrodomestico: {Brand}");
  }
  
}

// implementacion de la clase abstracta
class WashingMachine : HomeAppliance
{
  public override void TurnOn()
  {
    WriteLine($"La lavadora a inicializado el ciclo del lavado");
  }
}

//implementacion de otra clase abastracta
class Microwave : HomeAppliance
{
 public override void TurnOn()
 {
  WriteLine("El microondas esta calentando la comida.");
 } 
}