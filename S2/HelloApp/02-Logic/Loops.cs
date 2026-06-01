partial class Program
{
  static void Loops()
  {
    //while
    int count = 0;
    while(count < 5)
    {
      WriteLine($"Iteration: {count}");
      count++;
    }
    
    //do while
    int doCount = 0;
    do {
      WriteLine($"Do-While Iteration: {doCount}");
      doCount++;
    } while (doCount < 3);

    // Usamos estos loops para iterar sobre colecciones o repetir acciones hasta que se cumplan ciertas
    //condiciones, es decir cuando conocemos el numero de iteraciones o queremos repetir una accion hasta
    //que se cumpla una condicion especifica.
    //


    //for loop: cuando sabemos eactamente cuantas iteraciones queremos hacer
    for(int i = 0; i <=5; i++)
    {
      WriteLine($"Iteration: {i}");
    }
    //for mas personalizado
    for(int i=10; i>=0; i -= 2)
    {
      WriteLine($"Custom Iteration: {i}");
    }
    // foreach loop: para iterar collecciones, como arrays, listas, etc. y no necesitamos un indice para acceder a los elementos
    // foreach array
    string[] fruits = {"Apple", "Banana", "Cherry", "pera", "grape"};
    foreach(string fruit in fruits)
    {
      WriteLine($"Fruit: {fruit}");
    }
    
    //foreach List
    List<string> colors = new List<string> {"Red", "Green", "Blue", "Yellow"};
    foreach(string color in colors)
    {
      WriteLine($"Color: {color}");
    }
  }
}