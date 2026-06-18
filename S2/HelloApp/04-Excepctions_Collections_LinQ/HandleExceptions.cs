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
      
      decimal amountValue = decimal.Parse(amount);
      WriteLine($"El monto que introdujiste es el siguiente: {amountValue:C}");
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
  }
}