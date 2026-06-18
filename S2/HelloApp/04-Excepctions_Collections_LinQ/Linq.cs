partial class Program
{
  public static void Linq()
  {
    /*
    * busqueda y filtrado manual en una lista
    */
   List<int> numbers = [1,2,3,4,5,6];
   List<int> evenNumbers = [];
   
   // asi filtrariamos numeros pares sin linQ, recorrer numero a numero
   foreach (var number in numbers)
   {
      if(number % 2 == 0)
      {
        evenNumbers.Add(number);
      }
   }
   
   //Con linq tenemos 2 sintaxis posibles (pero devuelven un IEnumerable[interfaz de enumerable]):
   // Sintaxis de consulta
    var evenNumbersQuery = from num in numbers
                           where num % 2 == 0
                           select num;

   // Sintaxis de metodo
   var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

    foreach (var number in evenNumbersMethod)
    {
      WriteLine(number);
    }
  }
}