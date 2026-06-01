partial class Program
{
  static void LoopControlExamples()
  {
    // sentencia de salto: break, continue, return
    // break: se usa para salir de un loop o switch case antes de que termine su ejecución normal
    WriteLine("\nbreak...\n");
    for(int i = 0; i < 10; i++)
    {
      if(i == 5)
      {
        WriteLine("Breaking the loop at i = 5");
        break; // sale del loop cuando i es igual a 5
      }
      WriteLine($"Iteration: {i}");
    }
    
    // continue: se usa para saltar a la siguiente iteración del loop, omitiendo el código restante en la iteración actual
    WriteLine("\ncontinue...\n");
    for(int i=0; i<10; i++)
    {
      if(i == 5 || i == 7)
      {
        WriteLine($"Skipping iteration at i = {i}");
        continue; // salta a la siguiente iteración cuando i es igual a 5 o 7
      } 
      WriteLine($"Iteration: {i}");
    }
    
    // return: se usa para salir de un método y opcionalmente devolver un valor
    // en este caso, vamos a usar return para salir de un método si se cumple una condición específica
    WriteLine("\nreturn...\n");
    for(int i = 0; i < 10;i++)
    {
      WriteLine($"Iteration: {i}");
      if(i == 3)
      {
        WriteLine("Exiting the method at i = 3");
        // return; // sale del método completamente cuando i es igual a 3  
      }
    } 
    
    // Bucle infinito: un loop que nunca termina, a menos que se use una sentencia de control como break o return para salir de él
    // while(true)
    // {
    //   WriteLine("This is an infinite loop. It will run until we break it.");
    // }
    
    //bucle infinito con for
    for(;;)
    {
      WriteLine("This is another infinite loop using for. It will also run until we break it.");
      break;
    }
  }
}