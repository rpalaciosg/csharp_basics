partial class Program
{
  static void LoopGame()
  {
    // juego de adivinar el numero
    int counter = 0;
    WriteLine("Welcome to the Number Guessing Game!");
    WriteLine("🎮 Pulse any key to start... and increment the counter");
    WriteLine("🎴Pulse ESC for exit...\n");
    while(true)
    {
      var key = ReadKey(true).Key;
      if(key == ConsoleKey.Escape)
      {
        WriteLine($"How many times you pressed a key: {counter} times.");
        WriteLine("🧨Exiting the game. Thanks for playing!");
        break;  
      }
      counter++;
      // WriteLine($"You pressed a key! Current count: {counter}");
    }
  }
}