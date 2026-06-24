using System.Text.Json;

namespace ManageJsonFile
{
  class Character
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
  }
  partial class Program
  {
    public static void ManageJsonFile()
    {
      List<Character> characters =
      [
        new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
        new Character { Id = 2, Name = "Tony Stark", Alias
        = "Iron Man", Team = "Avengers" },
        new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" }
      ];

      /*
      * Serializar *  la lista de estos personajes o character a un archivo JSON
      */
      // transforma los personajes al formato json
      // var charactersJson = JsonSerializer.Serialize(characters);
      var charactersJson = JsonSerializer.Serialize(characters,
                                                    new JsonSerializerOptions
                                                    {
                                                      WriteIndented = true,
                                                      Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                                                    });
      //vamos a escribir el formato json enun archivo .json
      // al hacerlo de una forma directa, al revisar el json vemos que no tiene identacion y no esta codificado a utf8
      File.WriteAllText("./05-Files/characters.json", charactersJson);

      /*
      * Deserializar * el archivo json a un objeto para poder trabajar con el desde el codigo
      */
      // leemos el archivo json
      // var charactersFromFile = File.ReadAllText("./05-Files/characters.json");
      // deserializamos a una lista de personajes
      // var characterList = JsonSerializer.Deserialize<List<Character>>(charactersFromFile);
      // //valido si es null
      // if (characterList is null)
      // {
      //   WriteLine("Error: no se pido deserializar el archivo");
      //   return; // o manejar el error apropiadamente
      // }
      // foreach (var character in characterList)
      // {
      //   WriteLine($"Id: {character.Id}, Nombre: {character.Name}, Alias: {character.Alias}, Equipo: {character.Team}");
      // }

      /*
      * Deserializar pero con pattern matching para control de excepciones
      */

      try
      {
        var charactersFromFile = File.ReadAllText("./05-Files/characters.json");

        if (JsonSerializer.Deserialize<List<Character>>(charactersFromFile) is not List<Character> characterList || characterList.Count == 0)
        {
          WriteLine("Error: el archivo esta vacio o no se pudo deserializar el archivo o no contiene personajes validos.");
          return;
        }

        foreach (var character in characterList)
        {
          WriteLine($"Id: {character.Id}, Nombre: {character.Name}, Alias: {character.Alias}, Equipo: {character.Team}");
        }
      }
      catch (FileNotFoundException)
      {
        WriteLine("El archivo no existe");
      }
      catch (JsonException ex)
      {
        WriteLine($"Error en el formato JSON: {ex.Message}");
      }
      catch (Exception ex)
      {
        WriteLine($"Error inesperado: {ex.Message}");
      }

      // PAttern matching para prevenir null reference exception en caso de que al deserializar sea null

    }
  }
}