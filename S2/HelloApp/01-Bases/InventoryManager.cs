//Ejercicio
// - Mostrar inventario actualizado despues de cada compra
// - Crear un menu con las opciones "1. Comprar producto", "2. Salir".

partial class Program
{
  static void InventoryManager()
  {
    string[] products = ["Monitor", "Teclado", "Mouse", "Impresora"];
    int[] stock = [10, 20, 15, 5];
    double[] prices = [150.0, 30.0, 20.0, 100.0];

    Console.WriteLine("Bienvenido al Inventory Manager");
    Console.WriteLine("==============================");
    Console.WriteLine("1. Comprar producto");
    Console.WriteLine("2. Salir");
    Console.WriteLine("==============================");

   string ? option = Console.ReadLine();
   if(option == "1")
   {

    Console.WriteLine("Inventario de productos:");
    Console.WriteLine("---------------------------");
    for(int i=0; i<products.Length; i++)
    {
      Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: ${prices[i]:C}");
    }

   Console.WriteLine("\nIngrese producto que desea comprrar:");
   string? searchedProduct = Console.ReadLine();

   Console.WriteLine("Ingrese cantidad que desea comprar:");
   int? quantityInput = int.Parse(Console.ReadLine()! ?? "0");

   for(int i=0; i<products.Length; i++)
   {
    if(products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
    {
      if(quantityInput <= stock[i])
      {
        double? total = quantityInput * prices[i];
        Console.WriteLine($"Compra exitosa - Producto: {products[i]}, Cantidad: {quantityInput}, Total a pagar: ${total:C}");
        Console.WriteLine($"Stock restante de {products[i]}: {stock[i] - quantityInput}");
        stock[i] -= quantityInput ?? 0; // Actualizar el stock después de la compra
      } else
      {
        Console.WriteLine($"Stock insuficiente - Producto: {products[i]}, Stock disponible: {stock[i]}");
      }

    }
   }
  } else if(option == "2")
  {
    Console.WriteLine("Gracias por usar el Inventory Manager. ¡Hasta luego!");
  } else
  {
    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
  }
  }
}
