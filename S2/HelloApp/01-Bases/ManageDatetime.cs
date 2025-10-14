partial class Program
{
  static void ShowTime()
  {
    DateTime now = DateTime.Now; //fecha y hora
    DateTime today = DateTime.Today; //fecha
    DateTime oneWeekAgo = now.AddDays(-7); //suma dias
    DateTime customDate = new DateTime(2025, 10, 15); //fecha custom
    DayOfWeek weekDay = now.DayOfWeek; //descripcion del dia de la semana.

    Console.WriteLine($"Fecha y hora actual: {now}");
    Console.WriteLine($"Fecha actual: {today}");
    Console.WriteLine($"Hace una semana la fecha {now} era {oneWeekAgo.ToString("dd/MM/yyyy")}");
    Console.WriteLine($"Fecha personalizada: {customDate}");
    Console.WriteLine($"Dia de la semana: {weekDay}");
  }
}
