using System.Globalization;

partial class Program
{
  static void ParseToDatetime()
  {
    // CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");
    // CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-EC");

    //Tener en cuenta que la conversion de datos depende mucho de la cultura.
    //Podemos cambiar la cultura para adaptarnos a diferentes regiones

    int friends = int.Parse("101");
    double cost = 23.50;
    DateTime birthday = DateTime.Parse("2 Marzo 2025");// solo para espaniol
    // DateTime birthday = DateTime.Parse("2 March 2025");// solo para ingles US
    WriteLine($"Tengo {friends} amigos para invitar a mi fiesta.");
    WriteLine($"La celebracion de mi cumpleanios sera {birthday}.");
    WriteLine($"Formato largo {birthday:D}");//formato de fecha larga
    WriteLine($"El costo de la entrada sera: {cost:C} ");// formato de currency
  }
}
