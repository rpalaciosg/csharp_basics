
partial class Program
{
  static void PrintMultiplicationTable(int number, int tableLimit=10)
  {
    WriteLine($"Tabla de multiplicar del numer {number} desde el 1 hasta el {tableLimit}.");
    WriteLine();
    for(int i= 1; i<= tableLimit; i++)
    {
      WriteLine($"{number} x {i} = {number * i}");
    }
    WriteLine();
  }

  // static void Factorial()
  // {
  //
  // }

}
