partial class Program
{
  static void Generics()
  {
    /*
     * Generics: permiten escribir codigo mas flexible y reutilizable sin
     * depender de un tipo de dato especifico.
     * Un generico usa un marcador de tipo `T` para indicar que el codigo
     * puede trabajar con distintos tipos de datos.
     */
    string[] names = {"Juan", "Luis", "Barak", "Evan"};
    int[] numbers = {1,2,3};
    // usando metodos repetidos normales sin genericos
    Console.WriteLine($"Tamanio del arreglo numerico: { GetIntArrayLength(numbers) } ");
    Console.WriteLine($"Tamanio del arreglo nombres: { GetStringArrayLength(names) } ");

    // Usando un metodo generico
    Console.WriteLine("\n usando un metodo generico:");
    Console.WriteLine($"Tamanio del arreglo nombres con un metodo generico: { GetArrayLength(names) } ");
    Console.WriteLine($"Tamanio del arreglo numerico con un metodo generico: {GetArrayLength(numbers)}");

  }

  // metodos sin el uso de genericos
  static int GetIntArrayLength(int[] array)
  {
      return array.Length;
  }

  static int GetStringArrayLength(string[] array)
  {
    return array.Length;
  }

  // vamos a crear un `Metodo Generico` que me devuelva el tamanio de cada arreglo
  // sin importar el tipo
  static int GetArrayLength<T>(T[] array)
  {
    return array.Length;
  }
}
