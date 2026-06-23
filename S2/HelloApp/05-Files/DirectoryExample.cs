partial class Program
{
  static void DirectoryExample()
  {
    var directoryPath = "./05-Files/";

    // crear directorio
    Directory.CreateDirectory($"{directoryPath}/DirEjemplo/OtherDir");

    // verificar si existe directorio
    if (Directory.Exists($"{directoryPath}/DirEjemplo/OtherDir"))
    {
      WriteLine("El directorio ya existe");
    }

    //Eliminar directorio, pero que sea de manera recursiva porque sino da error si es que no esta vacio
    Directory.Delete($"{directoryPath}/DirEjemplo", recursive: true);
  }
}
