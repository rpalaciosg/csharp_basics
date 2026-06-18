partial class Program
{
  public static void Collections()
  {
    /*
    * Listas
    */
    List<string> names = ["Luis", "Ricardo", "Erick", "David", "Milton", "Angel", "JuanPablo", "Pablo"];//definicion de la Colecction List
    names.Add("Richard");//Adicion item a list
    // ShowNames(names);
    // WriteLine("Despues de remover a 'Luis'");
    names.Remove("Luis");//Remove item de list
                         // ShowNames(names);

    /*
    * Dictionary
    * clave - valor
    */
    //definicion
    Dictionary<int, string> employees = new()
    {
      {1, "Erick"},
      {2, "David"},
      {3, "Juan Pablo"},
      {4, "Angel"},
      {5, "Ricardo"},
      {6, "Milton"}
    };

    //Add items
    employees.Add(7, "Richard");

    // ShowEmployees(employees);

    // remover item de dictionary
    employees.Remove(4);
    // WriteLine($"\nDespues de remover '4'");
    // ShowEmployees(employees);

    /*
    * HashSet
    * Conjunto de elementos unicos
    */
    //definicion
    HashSet<string> users = ["rpalacios", "ejuca", "pgarcia"];

    //adicion
    users.Add("dalcivar");
    users.Add("aauquilla");
    users.Add("pgarcia");

    ShowUsers(users);
    // remover items
    users.Remove("ejuca");
    WriteLine($"\nDespues de remover 'ejuca'");
    ShowUsers(users);

  }

  private static void ShowUsers(HashSet<string> users)
  {
    //recorrer hash
    foreach (var user in users)
    {
      WriteLine(user);
    }
  }

  private static void ShowEmployees(Dictionary<int, string> employees)
  {
    //recorrer dictionary
    foreach (var employee in employees)
    {
      WriteLine($"Llave: {employee.Key}, Valor: {employee.Value}");
    }
  }

  private static void ShowNames(List<string> names)
  {
    foreach (var name in names)
    {
      WriteLine(name);
    }
  }
}