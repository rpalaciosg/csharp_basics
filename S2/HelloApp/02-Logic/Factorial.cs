// 🏆 Ejercicio:
// Crear un método llamado `PrintFactorialTable` que reciba un número
// y muestre el factorial de todos los números desde 1 hasta el número ingresado.
// Ejemplo: PrintFactorialTable(5);
// 1! = 1
// 2! = 2
// 3! = 6
// 4! = 24
// 5! = 120
partial class Program
{
  static void PrintFactorialTable(int number)
  {
    WriteLine($"Factorial del numero {number} desde el 1 hasta el {number}:");
    WriteLine();
    int result = 1;
    for(int i=1; i <= number; i++)
    {
      result *=i;
      WriteLine($"{i}! = {result}");
    }
  }

  // solucion con metodo acumulador
  static void PrintFactorialTable1(int number)
  {
    WriteLine($"Factorial del numero {number} desde el 1 hasta el {number}:");
    WriteLine();
    for(int i=1; i <= number; i++)
    {
      WriteLine($"{i}! = {Factorial(i)}");
    }
    WriteLine();
  }

  static int Factorial(int number)
  {
    int result = 1;
    for (int i = 1; i <= number;i++)
    {
      result *= i;
    }
    return result;
  }
}
