partial class Program
{
  static void SalaryCalculator()
  {
    Console.WriteLine("****************************");
    Console.WriteLine("** Calculadora de salario **");
    Console.WriteLine("****************************");
    //Nombre y validacion
    string? nombre;
    do
    {
      Console.Write("Ingrese su nombre: ");
      nombre = Console.ReadLine();// ?? "";
      if (string.IsNullOrWhiteSpace(nombre))
      {
        Console.WriteLine("El nombre no puede estar vacio. Intente nuevamente");
      }
    } while (string.IsNullOrWhiteSpace(nombre));

    //horas y validacion
    int horasTrabajadas;
    while (true)
    {
      Console.Write("Ingrese el numero de horas trabajadas: ");
      string? horasInput = Console.ReadLine();// ?? "0";
      if (int.TryParse(horasInput, out horasTrabajadas) && horasTrabajadas >= 0)
      {
        break;
      }
      Console.WriteLine("Por favor ingrese un numero valido de horas!!!");
    }

    //validacion salario
    decimal salarioPorHora;
    while (true)
    {
      Console.Write("Ingrese el salario por hora: ");
      string? salarioInput = Console.ReadLine();// ?? "0";
      if (decimal.TryParse(salarioInput, out salarioPorHora) && salarioPorHora >= 0)
      {
        break;
      }
      Console.WriteLine("Por favor, ingrese un salario valido!!!");
    }

    decimal salarioFinal = horasTrabajadas * salarioPorHora;
    //MOstrar resultado
    Console.WriteLine("\n-- Resultado --");
    Console.WriteLine($"El salario para {nombre} es de {salarioFinal:C}");

    Console.WriteLine("\nPresiona cualquier tecla para salir...");
    Console.ReadKey();
  }
}
