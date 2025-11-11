partial class Program
{
  static void HandleNullables()
  {
    // No nulificable
    string firstName = "Carlos";
    //Nulificable
    string? lastName = null;
    Console.WriteLine($"Nombre: {firstName}");
    if (lastName != null)
    {
      Console.WriteLine($"Apelligo: {lastName}");
    }
    else
    {
      Console.WriteLine("Apellido no especificado");
    }
    // Operaor de coalescencia nula ??
    Console.WriteLine($"Apelligo: {lastName ?? "Apellido no especificado!!"} ");

    //Operador de acceso nulo seguro ?. (propiedad u obejeto o clase)
    string? text = null;
    Console.WriteLine(text?.Length);
  }
}
