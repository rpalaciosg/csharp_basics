partial class Program
{
  static void ShowNumericTypes()
  {
    // int integerNumber = int.MaxValue;
    int integerNumber = 42;

    //decimales de 64 bits para calculos generales, y termina con la letra 'd'
    double doubleNumber = 3.1416d;

    //float manejar decimales de 32 bits es menos precios que double pero usa menos memoria y termina con la letra 'f'
    float floatNumber = 274f;

    //long es para numero bastante grandes y permiten definir numeros que sobrepasen integer, debe terminar con la
    //letra 'l' o 'L', y nos permite para una mayor legibilidad de nuestros datos desde la version de c# 7 en adelante, nos
    //permite usar un separador con guion bajo "_" para pder ver de mejor forma o mas legible estos numero grandes.jkk
    long longNumber = 300_200_100L;

    //decimal: tiene mayor precision, para calculos financieros o economicos, y terminan con el sufijo 'm'
    decimal monetaryNumber = 99.99m;

    //podemos hacer que el compilador infiera el tipo de dato usando 'var'
    var numeroInferido = 5f;

    Console.WriteLine($"Entero: {integerNumber}");
    Console.WriteLine($"Decimal/double: {doubleNumber}");
    Console.WriteLine($"Float: {floatNumber}");
    Console.WriteLine($"Long: {longNumber}");
    Console.WriteLine($"Decimal/Monetary Number: {monetaryNumber}");
    WriteLine($"Número inferido: {numeroInferido}");

  }
}
