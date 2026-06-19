/*
=====================================
Análisis de Ventas con LINQ y Excepciones
=====================================
*/
// 🏆 Ejercicio:
// Desarrollar un sistema para analizar las ventas de una empresa usando colecciones y LINQ.
// Tendrás una clase "Sale" con las siguientes propiedades:
//  - Product (public)
//  - Category (public)
//  - Amount (public)
//
// También una lista con 6 ventas ficticias.
// Lo que tendrás que desarrollar es:
// [X] 1. Filtrar y mostrar las ventas con monto superior a 1000.
// [X] 2. Agrupar las ventas por categoría y calcular el total de ventas por categoría.
// [ ] 3. Manejar excepciones en caso de errores al procesar los datos.

partial class Program
{
    static void SalesAnalysis()
    {
      try
      {
        List<Sale> sales = new()
        {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };

        //Manejo de errores
        if(sales == null)
        {
          throw new ArgumentNullException(nameof(sales), "La colleccion no puede ser null");
        }
        if ( sales.Count == 0 )
        {
          Console.ForegroundColor = ConsoleColor.Red;
          WriteLine($"La coleccion {nameof(sales)} esta vacia.");
        }

         // Console.ForegroundColor = default; esto no permitia ver letras en consola
        //1. Filtrar y mostrar las ventas con monto superior a 1000;
        var salesGreaterThan1000 = from s in sales
                                    where s.Amount > 1000
                                    select s;
        var salesGreaterThan1000Method = sales.Where(s => s.Amount > 1000);
        WriteLine($"Ventas con monto mayor a 1000");
        foreach (var sale in salesGreaterThan1000Method)
        {
          WriteLine($"Producto: {sale.Product}, Categoría: {sale.Category}, Monto: {sale.Amount:C}");
        }

        // 2. Total de ventas por categoria
        var totalSalesCategoryQuery = from s in sales
                                 group s by s.Category into groupCategory
                                 select new {CategoryName = groupCategory.Key,
                                             TotalSales= groupCategory.Sum(s => s.Amount) };
        var totalSalesCategoryMethod = sales
                                        .GroupBy( s => s.Category)
                                        .Select( categoryGroup => new
                                        {
                                         CategoryName = categoryGroup.Key,
                                         TotalSales = categoryGroup.Sum(s => s.Amount)
                                        });
        WriteLine("\nTotal de ventas por categoría:");
        foreach (var category in totalSalesCategoryMethod)
        {
          WriteLine($"Categoria: {category.CategoryName}, TotalVentas: {category.TotalSales:C}");
        }
      }
      catch (Exception ex)
      {
        WriteLine($"Error al procesar las ventas: {ex.Message}");
      }
    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}
