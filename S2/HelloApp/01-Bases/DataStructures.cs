partial class Program
{
  static void DataStructures()
  {
     // Clases: para usarla debo instanciar
    User richard = new() { Name="Richard", Age=33};
    richard.Greet();

    //structs: como usarlo
    Point punto = new Point { X=39, Y=29 };
    Console.WriteLine($" Punto ({punto.X},{punto.Y})");

    // records: como usarlo debo isntanaciarlas
    CellPhone nokia = new CellPhone("Nokia 2500", 2024);
    Console.WriteLine($"Mi celular con record es {nokia}");
  }
}

/*
 * Classes: usado para objetos grandes y complejos,se compara por referencia
 * para usarla debo instanciar
 */
class User
{
  public string? Name {get; set;}
  public int Age {get; set;}
  public void Greet()
  {
    Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age} anios");
  }
}

/*
 * Structs: son tipos datos para valores mas pequenios y ligeros
 */
struct Point {
  public int X { get;set; }
  public int Y { get; set; }
}

/*
 * Record: es usado para datos inmutables
 */
record CellPhone(string Model, int Year);
