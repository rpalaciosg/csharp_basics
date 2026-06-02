partial class Program
{
  static void InstanceObjects()
  {
   // instancia de car
   Carr car = new Carr();
   car.Model = "Toyota Camry";
    car.Year = 2020;
    // WriteLine(car.ShowInfo());
    // car.ShowMessage();
    // car.ChangeModel("Patrol"); 
    // car.ShowMessage("Model Changed!");
    // WriteLine(car.ShowInfo());
    // Car.GeneralInfo();
    // 
    // inicializar a travez de un constructor
    Carr sportCar = new Carr("Ferrari F8", 2021);
    WriteLine(car.ShowInfo());

    //Siontaxis simplificada de objetos: permite crear e inicializar un objeto en una sola expresión utilizando la sintaxis de inicialización de objetos.
    Carr suv = new Carr{Model="Jeep Grand Cherokee", Year=2022};
    WriteLine(suv.ShowInfo());

    // Listas de objetos
    WriteLine("* * * List of Cars: * * *");
    List<Carr> cars = new List<Carr>{
      new Carr("Renault Duster", 2020),
      new Carr("Honda Civic", 2019),
      new Carr("Ford Mustang", 2020),
      new Carr("Chevrolet Camaro", 2021)
    };
    
    foreach(var c in cars)
    {
      WriteLine(c.ShowInfo());
    }
  }

}

class Carr
{
  public string? Model {get; set;}
  public int? Year {get; set;}
  
  //constructor
  public Carr(string model, int year)
  {
    Model = model;
    Year = year;
  }
  
  // constructor vacio
  public Carr(){}

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