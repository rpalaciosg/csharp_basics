partial class Program
{
  static void Methods()
  {
   // instancia de car
   Car car = new Car();
   car.Model = "Toyota Camry";
    car.Year = 2020;
    WriteLine(car.ShowInfo());
    car.ShowMessage();
    car.ChangeModel("Patrol"); 
    car.ShowMessage("Model Changed!");
    WriteLine(car.ShowInfo());
    
    Car.GeneralInfo();
  }

}

class Car
{
  public string? Model {get; set;}
  public int? Year {get; set;}

  //MEthod for change a property
  public void ChangeModel(string newModel)
  {
    Model = newModel;
  }
  
  public string ShowInfo()
  {
    return $"This car is a {Model} from {Year}.";
  }
  
  //Oveloading method(sobrecarga de métodos): capacidad de definir multiples metodos con el mismo
  // nombre pero con diferentes parametros o tipos de retorno. El compilador determina cual metodo 
  // ejecutar en base a los argumentos proporcionados al llamar al metodo.
  public void ShowMessage() => WriteLine("This is a Autimovile.");
  public void ShowMessage(string message) => WriteLine(message);
  
  // metodos estaticos: pertenecen a la clase en lugar de una instancia especifica.
  // Se puede llamar sin crear un objet de la clase. Son utiles para operaciones que no dependen del estado de un objeto en particular.
  public static void GeneralInfo()
  {
    WriteLine("The automobile is a wheeled motor vehicle used for transportation.");
  }
    
}  