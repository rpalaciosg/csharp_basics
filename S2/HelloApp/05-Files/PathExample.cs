// Manejo de rutas en c#
// Permite trabajar con rutas de archivos y directorios de forma eficiente
partial class Program
{
  static void PathExample()
  {
    var filePath = "./05-Files/Ejemplo.txt";

    // obtener nombre de archivo
    var fileName = Path.GetFileName(filePath);
    WriteLine($"Nombre del archivo: {fileName}");

    // obtiene extension del archivo
    var fileExtension = Path.GetExtension(filePath);
    WriteLine($"Extension del archivo: {fileExtension}");

    //obtiene nombre del directorio
    var directoryName = Path.GetDirectoryName(filePath);
    WriteLine($"Nombre del directorio: {directoryName}");

    // puedo combinar diirectorios
    var combinedPath = Path.Combine("~","Userrr","Documents","Ejemplo.txt");
    WriteLine($"Ruta combinada: {combinedPath}");

    //ruta completa de un archivo
    var fullFilePath = Path.GetFullPath(filePath);
    WriteLine($"Ruta completa del archivo: {fullFilePath}");
  }
}
