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

    public List<Task> EditTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("**** Editar tarea ****");
        Write("Ingrese el id de la tarea que desea editar: ");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;
        if(task == null)
        {
          ForegroundColor = ConsoleColor.DarkRed;
          WriteLine($"No se encontro la tarea con el ID: {id}");
          ResetColor();
          return Tasks;
        }
        Write("Ingrese la descripcion de la tarea: ");
        var description = ReadLine()!;
        task.Description = description;
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Tarea {id} modificada con exito.");
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

    public List<Task> RemoveTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("**** Eliminar tarea ****");
        Write("Ingrese el id de la tarea que desea eliminar: ");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;
        if(task == null)
        {
          ForegroundColor = ConsoleColor.DarkRed;
          WriteLine($"No se encontro la tarea con el ID: {id}");
          ResetColor();
          return Tasks;
        }
        Tasks.Remove(task);

        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Tarea {id} modificada con exito.");
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

    public void TasksByState()
    {
      ResetColor();
      Clear();
      try
      {
        WriteLine("**** Tareas por estado ****");
        WriteLine("1. Completadas");
        WriteLine("2. Pendientes");
        Write("Ingrese la opcion de las tareas a mostrar:");
        string taskState = ReadLine()!;
        if( taskState != "1" && taskState != "2")
        {
          ForegroundColor = ConsoleColor.DarkRed;
          WriteLine("Opcion invalidad");
          ResetColor();
          return;
        }
        bool completed = taskState == "1";
        List<Task> filteredTasks = Tasks.Where(t => t.Completed == completed).ToList();
        if(filteredTasks.Count == 0)
        {
          ForegroundColor = ConsoleColor.DarkRed;
          WriteLine("No se encontraron tareas con el estado solicitado");
          ResetColor();
          return;
        }

        ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;
        Table table = new Table("Id", "Descripcion", "Estado");
        table.Config = TableConfig.Unicode();
        foreach (var task in filteredTasks)
        {
          table.AddRow(task.Id, task.Description, task.Completed ? "✔"  : "");
        }
        Write(table.ToString());
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine($"Ocurrio un error al filtrar las tareas: {ex.Message}");
      }
    }

    public void TasksByDescription()
    {

      try
      {
        Clear();
        ResetColor();
        WriteLine("**** Tareas por descripcion ****");
        WriteLine("Ingrese la descripcion de las tareas a buscar:");
        string description = ReadLine()!;
        // aqui el importante es el metodo FindAll para poder buscar por la descripcion
        List<Task> matchingTasks = Tasks.FindAll(t => t.Description
              ?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false)!;
        if( matchingTasks.Count == 0)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontraron tareas con la descripcion proporcionada.");
          ResetColor();
          return;
        }
        Table table = new Table("Id", "Descripcion", "Estado");
        table.Config = TableConfig.Unicode();
        foreach (var task in matchingTasks)
        {
          table.AddRow(task.Id, task.Description, task.Completed ? "✔"  : "");
        }
        Write(table.ToString());
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine($"Ocurrio un error al filtrar las tareas por *Descripcion*: {ex.Message}");
      }
    }


  }
}
