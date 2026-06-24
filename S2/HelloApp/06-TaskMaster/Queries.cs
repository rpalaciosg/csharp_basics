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
    
    public List<Task> AddTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("**** Añadir Tarea ****");
        WriteLine("Ingrese la descripcion de la tarea: ");
        var description = ReadLine() ?? "";
        //uso la liberia Guid para generar el id la creo en una clase Utils y e instancio el metodo que me devuelve el id
        Task newTask = new Task(Utils.GenerateId(), description);
        Tasks.Add(newTask);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea añadida con éxito");
        ResetColor();
        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine(ex.Message);
        return Tasks;
      }
    }
    
    public List<Task> MarkAsCompleted()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("**** Marcar tarea como Completada ****");
        WriteLine("Ingrese el id de la tarea que desea marcar como completado:");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;// esto esta mal es peligroso
        if (task is null)
        {
          ForegroundColor = ConsoleColor.DarkRed;
          WriteLine($"No se encontro la tarea con el ID: {id}");
          ResetColor();
          return Tasks;
        }
        task.Completed = true;
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Tarea {id} marcada como completada con exito.");
        ResetColor();
        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine(ex.Message);
        return Tasks;
      }
    }

  }
}