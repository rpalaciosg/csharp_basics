partial class Program
{
  static void SalesReport()
  {
    string product = "Laptop";
    int quantitySold = 3;
    decimal unitPrice = 750.99M;
    decimal totalAmount = quantitySold * unitPrice;
    Console.WriteLine($"Producto: {product}");
    Console.WriteLine($"Cantidad vendida: {quantitySold}");
    Console.WriteLine($"Total generado: {totalAmount:C}"); //para formatear como moneda dependiendo la configuracion regional
  }
}
