partial class Program
{
  static void ShowStringType()
  {
    string name = "Juan";
    string message = "Hola " + name;
    string interpolatedMessage = $"Hola {name}";
    Console.WriteLine(message);
    Console.WriteLine(interpolatedMessage);
    Console.WriteLine($"Tu nombre tiene {name.Length} palabras");
    Console.WriteLine($"Tu nombre en mayusculas es {name.ToUpper()}");
    Console.WriteLine($"Tu nombre en minusculas es {name.ToLower()}");

    int number = 13;
    Console.WriteLine(number.ToString());
    bool isString = true;
    Console.WriteLine(isString.ToString());
  }
}
