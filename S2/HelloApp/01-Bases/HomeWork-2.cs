using System.Globalization;

partial class Program
{
  static void DaysOfLife()
  {
    DateTime birthDate = new DateTime(1991, 3, 19);
    TimeSpan difference = DateTime.Now - birthDate;
    Console.WriteLine($"Has vivido {difference.Days} dias.");
  }

  static void DaysUntilNextBirthday()
  {
    Console.Write("Introduce tu fecha de nacimiento (dd/mm/aaaa): ");
    DateTime birthDate;
    string birthdate_input = Console.ReadLine()!;
    birthDate = DateTime.ParseExact(birthdate_input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
    DateTime currentDate = DateTime.Now.Date;
    DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);
    if (nextBirthday < currentDate)
    {
      nextBirthday = nextBirthday.AddYears(1);
    }
    int dayRemaining = (nextBirthday - currentDate).Days;
    Console.WriteLine($"Faltan {dayRemaining} dias para tu proximo cumpleanios.");
  }
}
