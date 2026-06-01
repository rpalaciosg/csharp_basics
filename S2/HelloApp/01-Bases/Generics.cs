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

    // Usando clase Generica
    Console.WriteLine("\n usando un Clase generica:");
    Box<int> numberBox = new Box<int> { Content=50 };
    Box<string> stringBox = new Box<string> { Content="Ahora soy texto." };
    numberBox.Show();
    stringBox.Show();

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

  // Metodo Generico
  // vamos a crear un `Metodo Generico` que me devuelva el tamanio de cada arreglo
  // sin importar el tipo
  // estos metodos genericos nos ayudan a no duplicar codigo
  static int GetArrayLength<T>(T[] array)
  {
    return array.Length;
  }
}

// Clase generica
// nos permiten trabajar con diferentes tipos de datos
class Box<T>
{
  public T? Content  {get; set;}
  public void Show()
  {
    Console.WriteLine($"Contendio: {Content}");
  }
}
