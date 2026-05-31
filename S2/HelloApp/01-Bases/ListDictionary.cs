partial class Program
{
  static void ListDictionary()
  {
    /*
     * listas: ideales para almacenar y manipular colecciones ordenadas
     */
    List<string> names = new List<string>{"Ana", "Carlos", "Juan"};
    names.Add("Lucia");
    names.Add("Richard");
    names.Add("Celia");
    Console.WriteLine($"Total de nombres: {names.Count}");
    foreach(var name in names){
      Console.WriteLine(name);
    }
    names.Remove("Ana");
    names.Remove("Juan");
    bool isExistAna = names.Contains("Ana");
    Console.WriteLine($"Ana esta en la lista? {isExistAna}");
    bool isExisteRichard = names.Contains("Richard");
    Console.WriteLine($"Richard esta en la lista?: {isExisteRichard}");

    /*
    * Dictionary<clave,valor>
    */
    Dictionary<int,string> students = new Dictionary<int,string>
    {
      {1, "Ana"},
      {2, "Felipe"},
      {3, "Elena"}
    };

    // acceder directamente a travez de su key
    Console.WriteLine($"El estudiante con ID 1 es: {students[1]}");

    // how to iterate o recorro our diccionary
    foreach(var student in students)
    {
      // asi obtendo todo el elemento
      Console.WriteLine(student);
      // si quiero obtener solo el key
      // Si quiero obtener solo el value
      Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");

    }
  }
}
