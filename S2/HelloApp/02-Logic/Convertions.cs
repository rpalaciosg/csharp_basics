partial class Program
{
  static void Convertions()
  {
    // conversion implicita: cuando el tipo de dato de origen es mas pequeño o compatible con el tipo
    // de dato de destino, el compilador puede realizar la conversion automaticamente sin perder informacion
    int smallNumber = 42;
    double decimalNumber = smallNumber; // conversion implicita de int a double
    WriteLine($"Small Number (int): {decimalNumber}");
  }
}