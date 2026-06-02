partial class Program
{
  static void Tuples()
  {
    // Tuplas: son estructuras de datos que pueden contener múltiples valores de diferentes tipos
    // Las tuplas son útiles para agrupar datos relacionados sin necesidad de crear una clase o
    // estructura personalizada

    // Creacion de una tupla
    (int, string, bool) person = (30, "Celia", true);
    WriteLine($"Age: {person.Item1}, Name: {person.Item2}, IsEmployed: {person.Item3}");

    // Tuplas con nombres de campos
    (int Age, string Name, bool IsEmployed) namedPerson = (35, "Richard", true);
    WriteLine($"Age: {namedPerson.Age}, Name: {namedPerson.Name}, IsEmployed: {namedPerson.IsEmployed}");
    
    // Desestructuración de tuplas
    var (age, name, isEmployed) = namedPerson;
    WriteLine($"Age: {age}, Name: {name}, IsEmployed: {isEmployed}");
    
    // usando metoido que devuelve una tupla
    var resultOperations = Operations(5, 10);
    WriteLine($"Sum: {resultOperations.Sum}, Product: {resultOperations.Product}");
    
    // desestructuración directa al llamar al método
    var (sum, product) = Operations(7, 3);
    WriteLine($"Sum: {sum}, Product: {product}");
  }
  
  // metodo que devuelve una tupla
  static (int Sum, int Product) Operations(int a, int b)
  {
    int sum = a + b;
    int product = a * b;
    return (sum, product);
  }
}