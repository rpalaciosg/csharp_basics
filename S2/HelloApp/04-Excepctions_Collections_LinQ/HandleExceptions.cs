partial class Program
{
  static string? amount;

  static void HandleException()
  {
    try
    {
    //  int number = 10;
    //  int result = number / 0; 
      Write("Ingrese un monto: ");
      amount = ReadLine();
      if(string.IsNullOrEmpty(amount)) return;

     //Maneja errores en conversion
     //decimal, int, double tienen el metodo `TryParse` que nos devuelve true o false al parsear 
      if(decimal.TryParse(amount, out decimal amountValue))
      {
        // decimal amountValue = decimal.Parse(amount);
        WriteLine($"El monto que introdujiste es el siguiente: {amountValue:C}");
      } else
      {
      Console.ForegroundColor = ConsoleColor.Red;
        WriteLine($"No se pudo convertir el texto a número.");
      }
      
      // Ejmplo de lanzar excepciones 
      ValidateAge(16);
    }
    catch (DivideByZeroException)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      WriteLine("Error: Division por cero...");
    }
    catch(FormatException) when (amount?.Contains('$') == true) // manejo de excepcion con condicion
    {
      Console.ForegroundColor = ConsoleColor.Red;
      WriteLine("No es necesario usar el simbolo de '$'");
    }
    catch(Exception ex) //capturar todas las excepciones genericas
    {
      Console.ForegroundColor = ConsoleColor.Red;
      WriteLine(ex.Message);
    }
    finally //probando finally, siempre se ejecuta
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      WriteLine($"En `finally` : Esto siempre se ejecutara..");
    }
  }
  
  static void ValidateAge(int age)
  {
    if (age <18)
    {
      throw new ArgumentException($"La edad debe ser mayor a 18");
    }
  }
}