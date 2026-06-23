// como escribir en archivos con C#
partial class Program
{
  static void WriteFileExample()
  {
    var filePath = "./05-Files/EjemploEscritura.txt";
    // var content = "Podemos escribir en un archivo.";
    // si teniamos antes texto, esto lo va a socreescribir
    // var content = "Primera linea";
    var content = "Esto se aniadira al final";

    // var streamWriter = new StreamWriter(filePath);
    // agregar al archivo lo que se escribe y no sobreescribir
    var streamWriter = new StreamWriter(filePath, append: true);
    streamWriter.WriteLine(content);
    streamWriter.WriteLine("La hora actual es: "+DateTime.Now.ToString("HH:mm:ss"));
    //liberar recursos, o cerrar archivo despues de escribir sobre el
    streamWriter.Dispose();
    WriteLine("Archivo creado exitosamente");


  }
}
