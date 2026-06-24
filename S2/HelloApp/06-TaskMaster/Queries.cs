using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;
namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private List<Task> Tasks = _tasks;
    
    public void ListTasks()
    {
      // ForegroundColor = ConsoleColor.DarkBlue;
      // WriteLine("=== Lista de tareas ===");
      // foreach (var task in Tasks)
      // {
      //   WriteLine("\n{0,-8}{1,-35}{2,-15}","Id","Descripcion","Completado");
      //   WriteLine(new string('-',58));
      //   WriteLine("\n{0,-8}{1,-35}{2,-15}",task.Id, task.Description, task.Completed);
      // }
      /* 
      * vamos a usar la libreria BetterConsoleTables para mostrar de forma mas estetica nuestros
      * datos en consola
      * dotnet add package BetterConsoleTables --version 2.0.5-rc1
      */
      ForegroundColor = ConsoleColor.DarkBlue;
      WriteLine("=== Lista de tareas ===");
      Table table = new Table("Id", "Descripcion", "Estado");
      table.Config = TableConfig.Unicode();
      foreach (var task in Tasks)
      {
        table.AddRow(task.Id, task.Description, task.Completed ? "✔"  : "");
      }
      WriteLine(table.ToString());
      // ReadKey();
    } 

  }
}