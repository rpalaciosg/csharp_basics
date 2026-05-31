partial class Program
{
  static void Arrays()
  {
    int[] numbers = new int[5];
    numbers[0] = 1;
    numbers[1] = 2;
    // directo
    int[] numbersArray = {5,10, 3, 4};
    int[] numbersArray2 = [5,10, 3, 4];

    //indices
    Console.WriteLine($"First element is {numbersArray[0]}");
    Console.WriteLine($"Third element is {numbersArray[2]}");

    //Tamaño del arreglo
   Console.WriteLine($"El tamaño del arreglo es {numbersArray.Length}");



  }
}
