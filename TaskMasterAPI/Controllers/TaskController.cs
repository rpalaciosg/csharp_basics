using System;
using Microsoft.AspNetCore.Mvc;
using TaskMasterAPI.Services;

namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("api/[controller]")] //va a tomar el nombre del controlador y lo va a poner en minusculas, en este caso `task`
//api/task

//al hacer esta herencia va a ser un controlador de tipo API, por lo que no va a tener vistas, ni va a retornar HTML, sino que va a retornar JSON
public class TaskController:ControllerBase
{

  [HttpGet]
  public ActionResult<IEnumerable<Models.Task>> GetTasks()
  {
    return Ok(TaskDataStore.Current.Tasks);//deveulve un 200 OK con la lista de tareas en formato JSON
  }
  
  [HttpGet("{id}")]
  //api/task/1 -> este atributo id va desde la url
  public ActionResult<Models.Task> GetTask(int id)
  {
    var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
    if (task == null)
    {
      return NotFound("No se encontró la tarea.");//deveulve un 404 Not Found si no encuentra la tarea 
    }
   
    return Ok(task);//deveulve un 200 OK con la tarea en formato JSON 
  }

}
