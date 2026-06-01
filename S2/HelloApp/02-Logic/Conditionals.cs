partial class Program
{
  static void Conditionals()
  {
   int age = 19;
   if(age >= 18)
   {
    WriteLine("Your are an adult.");
   }
   else {
    WriteLine("You are a minor.");
   } 
   
   
    //if ternario
    string message = age >= 18 ? "Your are and adult." : "You are a minor.";
    WriteLine(message);

    // Multiples conditions
    int temperature = 30;
    if(temperature > 35)
    {
      WriteLine("It's very hot.");
    } else if(temperature >= 20)
    {
      WriteLine("It's warm.");
    } else {
      WriteLine("It's cold.");
    }
    
    //Switch case
    int day = 3;
    switch (day)
    {
      case 1:
        WriteLine("Monday");
        break;
      case 2:
        WriteLine("Tuesday");
        break;
      case 3:
        WriteLine("Wednesday");
        break;
      default:
        WriteLine("Invalid day");
        break;
    }
    // Switch with expression
    // esto se puede usar a partir de c# 8.0 en adelante
    string dayName = day switch
    {
      1 => "monday",
      2 => "Tuesday",
      3 => "Wednesday",
      _ => "Invalid day"
    };
    WriteLine(dayName);
  }

  
}