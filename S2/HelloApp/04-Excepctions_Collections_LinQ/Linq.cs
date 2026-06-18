partial class Program
{
  public static void Linq()
  {
    /*
    * busqueda y filtrado manual en una lista
    */
   List<int> numbers = [1,2,3,4,5,6];
   List<int> evenNumbers = [];
   
   // asi filtrariamos numeros pares sin linQ, recorrer numero a numero
   foreach (var number in numbers)
   {
      if(number % 2 == 0)
      {
        evenNumbers.Add(number);
      }
   }
   
   //Con linq tenemos 2 sintaxis posibles (pero devuelven un IEnumerable[interfaz de enumerable]):
   // Sintaxis de consulta
    var evenNumbersQuery = from num in numbers
                           where num % 2 == 0
                           select num;

   // Sintaxis de metodo
   var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

    foreach (var number in evenNumbersMethod)
    {
      // WriteLine(number);
    }
    
    /*
    * Consultas simples
    */
    List<MarvelCharacter> characters = new List<MarvelCharacter>
    {
      new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
      new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
      new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
      new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
      new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
      new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
     };
    
    // personajes del team avengers
    // WriteLine(">> Personasjes que pertenecen a los Avengers <<");
    var avengersQuery = from c in characters
                        where c.Team == "Avengers"
                        select $"{c.Alias} {c.Name}";
    
    var avengersMethod = characters.Where(c => c.Team == "Avengers");
    // foreach (var character in avengersMethod)
    // {
    // //  WriteLine($"{character.Alias} {character.Name}"); 
    // }
    
    // podemos transformar la coleccion de datos con nuestro select
    //que todos los nombres esten en mayusculas
    var uppercaseNamesQuery = from c in characters
                              select c.Name?.ToUpper();
    
    var uppercaseNamesMethod = characters.Select(c => c .Name?.ToUpper());
    WriteLine(">> Nombres de Personasjes en mayusculas <<");
    foreach (var characterName in uppercaseNamesMethod)
    {
      WriteLine($"{characterName}"); 
    }
  }
}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}
