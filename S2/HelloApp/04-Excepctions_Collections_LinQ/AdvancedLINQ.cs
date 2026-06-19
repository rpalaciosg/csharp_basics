namespace AdvancedLinq
{
  class Character
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
  }

  class Ability
  {
    public int CharacterId { get; set; }
    public string? Description { get; set; }
  }
  class Statistic
  {
    public int CharacterId { get; set; }
    public int Power { get; set; }
  }
  class Program
  {
    /*
    * Consultas Avanzadas
    */
    public static void AdvancedLINQ()
    {
      List<Character> characters =
      [
        new Character { Id = 1, Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
        new Character { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
        new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" },
        new Character { Id = 4, Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
        new Character { Id = 5, Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
    ];

      List<Ability> abilities =
      [
        new Ability { CharacterId = 1, Description = "Sentido arácnido" },
        new Ability { CharacterId = 1, Description = "Trepar paredes" },
        new Ability { CharacterId = 2, Description = "Inteligencia y armadura de alta tecnología" },
        new Ability { CharacterId = 3, Description = "Super fuerza" },
        new Ability { CharacterId = 4, Description = "Reflejos aumentados" },
        new Ability { CharacterId = 5, Description = "Magia y hechicería" }
      ];
      List<Statistic> statistics =
      [
        new Statistic { CharacterId = 1, Power = 85 },
        new Statistic { CharacterId = 2, Power = 90 },
        new Statistic { CharacterId = 3, Power = 88 },
        new Statistic { CharacterId = 4, Power = 80 },
        new Statistic { CharacterId = 5, Power = 95 }
      ];
      
      //Agrupacion o groupby por equipo
      // Team(key) -> (value)quienes son los que estan dentro del team
      var teamsQuery = from c in characters
                       group c by c.Team into team
                       select team;
      var teamsMethod = characters.GroupBy(c => c.Team);
      // WriteLine(">> Agrupaciones por equipos: <<");
      foreach (var team in teamsMethod)
      {
        // WriteLine($"👥 Equipo: {team.Key}");
        foreach (var character in team)
        {
          // WriteLine($" - {character.Name}");
        }
      }
      
      // Union/join de colecciones por su relacion
      var charactersWithAbilities = from c in characters
                                    join a in abilities on c.Id equals a.CharacterId
                                    select new { c.Alias, c.Name, a.Description};
      var charactersWithAbilitiesMethod = characters
                                        .Join(abilities,
                                              c => c.Id,
                                              a => a.CharacterId,
                                              (c,a) => new {c.Alias, c.Name, a.Description});
      // WriteLine("🦸‍♂️ Personajes y sus habilidades:");
      foreach (var character in charactersWithAbilitiesMethod)
      {
        // WriteLine($"{character.Alias} {character.Name} - Habilidad: {character.Description}");
      }
      
      /*
      * Consulta de agregaciones: sum, count y average
      */

      // Sum: Obtener el poder total de todos los personajes, es decir suma de todos los poderes de todos
      // los personajes
      int totalPower = statistics.Sum(s => s.Power);
      WriteLine($"⚡ Poder total de todos los personajes: {totalPower}");
      
      // Average: obtener promedio de poder de los "Avengers"
      var avengersPower = (from c in characters
                           join s in statistics on c.Id equals s.CharacterId
                           where c.Team == "Avengers"
                           select s.Power).Average();
      WriteLine($"🛡️ Promedio de poder de los Avengers: {avengersPower:F2}");

      // Count: cantidad de habilidades por personaje
      var abilitiesByCaracter = from c in characters
                                join a in abilities on c.Id equals a.CharacterId
                                group a by c.Alias into groupAbilities
                                select new {Character = groupAbilities.Key, Count= groupAbilities.Count()};
      // usando join, luego grup con una proyeccion intermedia 
      var abilitiesByCaracterMethod1 = characters
                                      .Join(abilities,
                                          c => c.Id,
                                          a => a.CharacterId,
                                          (c,a) => new {Character = c, Ability = a})
                                      .GroupBy(x => x.Character.Alias)
                                      .Select(group => new
                                      {
                                        Character = group.Key, Count = group.Count()
                                      });
      
      // method alternativausando GroupJoin
      var abilitiesByCaracterMethod2 = characters
                                      .GroupJoin(abilities,
                                                 c => c.Id,
                                                 a => a.CharacterId,
                                                 (c,abilitiesGroup) => new
                                                 {
                                                   Character = c.Alias,
                                                   Count = abilitiesGroup.Count()
                                                 });
      WriteLine("📝 Cantidad de habilidades por personaje:");
      foreach (var character in abilitiesByCaracterMethod2)
      {
       WriteLine($"{character.Character}: {character.Count} habilidades");
      }
    }
  }
}