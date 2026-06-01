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
  }
}