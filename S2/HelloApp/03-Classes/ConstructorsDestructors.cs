partial class Program
{
  // Constructores y destructores:
  // Ambos son ensenciales para la gestion del ciclo de vida de los objetos, permitiendo 
  // una inicializacion adecuada y una limpieza eficiente de los recursos.
  /* 
   * Constructores: son métodos especiales que se ejecutan automáticamente cuando se
   * crea una instancia de una clase. Se utilizan para inicializar los objetos y 
   * establecer su estado inicial. Un constructor tiene el mismo nombre que la clase y
   * no tiene un tipo de retorno.
  */
  /*
    * Destructores: Limpian los recursos de un objeto. 
    * Son métodos especiales que se ejecutan automáticamente cuando un objeto
    * es destruido o liberado de la memoria. Se utilizan para realizar tareas de 
    * limpieza o liberar recursos no administrados. Un destructor tiene el mismo 
    * nombre que la clase pero con un prefijo "~" "virgulilla" y no tiene parámetros
    * ni tipo de retorno.
    */
  static void ConstructorsDestructors()
  {
   // instancia, inicializa, crea un objeto a traves de un constructor por defecto
   // estos no tienen parametros en su inicializacion, y se crean automaticamente 
   Carro car = new Carro();
   car.Model = "Toyota Camry";
    car.Year = 2020;
    
    // OTro constructor con parametros
    // Aqui hay una sobrecarga de constructores, ya que la clase Carro tiene dos 
    // constructores: uno sin parámetros y otro con parámetros.
    Carro sportCar = new Carro("Ferrari F8", 2021);
    WriteLine(sportCar.ShowInfo());

    //Siontaxis simplificada de objetos: permite crear e inicializar un objeto en una sola expresión utilizando la sintaxis de inicialización de objetos.
    Carro suv = new Carro{Model="Jeep Grand Cherokee", Year=2022};
    WriteLine(suv.ShowInfo());

    // Listas de objetos
    WriteLine("* * * List of Cars: * * *");
    List<Carro> cars = new List<Carro>{
      new Carro("Renault Duster", 2020),
      new Carro("Honda Civic", 2019),
      new Carro("Ford Mustang", 2020),
      new Carro("Chevrolet Camaro", 2021)
    };
    
    foreach(var c in cars)
    {
      WriteLine(c.ShowInfo());
    }
  }

}

class Carro
{
  public string? Model {get; set;}
  public int? Year {get; set;}
  
  //constructor con parametros
  public Carro(string model, int year)
  {
    Model = model;
    Year = year;
  }
  
  // constructor por defecto
  public Carro(){}

  // destructor (~): se ejecuta cuando el objeto es destruido o liberado de la memoria.
  ~Carro()
  {
    //se ejecutan automaticamente cuando un objeto es destruido o liberado de la memoria, se utiliza para realizar tareas de limpieza o liberar recursos no administrados.
    //sirver para liberar recursos no administrador como archivos o conexiones de base de datos, o para realizar tareas de limpieza antes de que el objeto sea destruido.
    WriteLine($"Destructor called. Resources for {Model} are being released.");
    // PAra poder probar vamos a forzar el garbage collector para fines educativos, hacerlo manualmente
    //es una mala practica, ya que de esto se encarga el garbage collector de .Net
  }
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