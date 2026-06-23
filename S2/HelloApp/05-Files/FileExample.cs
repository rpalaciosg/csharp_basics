partial class Program
{
  static void FileExample()
  {
    string pathFile = "./05-Files/Ejemplo.txt";
    // leemos un archivo
    // 1era forma: retorna un string con todo concatenado
    var content = File.ReadAllText(pathFile);
    // WriteLine(content);

    // 2da forma: decirle que va a leer varias lineas, cada linea seria un elmento del arreglo.
    // esto devuelve un arreglo de strings
    var lines = File.ReadAllLines(pathFile);
    foreach (var line in lines)
    {
      WriteLine(line);
    }
    WriteLine(lines[1]);

    // copiar nuestro archivo
    File.Copy(pathFile, "./05-Files/EjemploCopia.txt", overwrite: true);

    // borrar archivo
    File.Delete("./05-Files/EjemploCopia.txt");
  }
}
