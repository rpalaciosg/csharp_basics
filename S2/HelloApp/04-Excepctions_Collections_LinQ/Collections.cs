partial class Program
{
  public static void Collections()
  {
    // Listas
    List<string> names = ["Luis", "Ricardo", "Erick", "David", "Milton", "Angel", "JuanPablo", "Pablo"];//definicion de la Colecction List
    names.Add("Richard");//Adicion item a list
    ShowNames(names);
    WriteLine("Despues de remover a 'Luis'");
    names.Remove("Luis");//Remove item de list
    ShowNames(names);
  }

  private static void ShowNames(List<string> names)
  {
    foreach (var name in names)
    {
      WriteLine(name);
    }
  }
}