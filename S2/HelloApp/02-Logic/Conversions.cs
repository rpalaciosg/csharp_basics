partial class Program
{
  static void Conversions()
  {
    // conversion implicita: cuando el tipo de dato de origen es mas pequeño o compatible con el tipo
    // de dato de destino, el compilador puede realizar la conversion automaticamente sin perder informacion
    // Cuando se puede cambiar un tipo de dato mas pequenio a uno mas grande sin perdida de datos.
    int smallNumber = 42;
    double decimalNumber = smallNumber; // conversion implicita de int a double
    WriteLine($"Small Number (int): {decimalNumber}");

    //int a float
    //conversiones explicitas: pero debemos indicar que lo vamos a hacert
    //aquie corremos el riesgo de si tener perdida de datos
    //Debo tener mucho cuidado con esto
    double explicitDecimalNumber = 42.5;
    int integerNumber = (int)explicitDecimalNumber;
    WriteLine(integerNumber);

    // cadenas a numeros: usamos metodos como `convert` y `parse`
    string text = "123";
    int parsedNumber = int.Parse(text);
    WriteLine(parsedNumber);

    // convert forma explicita
    double anotherDecimalNumber = 50.8;
    int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
    WriteLine(convertedNumber);// esto va a redondear hacia arriba al hacer el casteo

    int castedNumber = (int)anotherDecimalNumber;
    WriteLine(castedNumber);// aqui no redonde sino que lo trunca en la parte decimal
  }
}
