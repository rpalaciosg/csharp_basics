partial class Program
{
  
  // LA herencia nos permite reutilizar codigo y organizar nuestras clases
  public static void Inheritance()
  {
    HogwartsStudent student = new HogwartsStudent(){Name="Harry Potter", House="Gryffindor"};
    HogwartsProfessor professor = new HogwartsProfessor(){Name="Severus Snape", Subject="Pociones"};

    student.Greet();
    student.ShowHouse();
    professor.Greet();
    professor.MySubject();

  }
}

class Character{
  public string? Name {get; set;}
  
  // un metodo virtual permite sobreescribir este metodo
  public virtual void Greet()
  {
    WriteLine($"Hola Im {Name}");
  }
}

// aqui la herencia, class hijo : padre
class HogwartsStudent: Character
{
  public string? House {get; set;}

  public void ShowHouse()
  {
    WriteLine($"Pertenezco a la casa {House} en Howgarts.");    
  }
}

class HogwartsProfessor : Character
{
  public string? Subject {get; set;}
  
  public void MySubject()
  {
    WriteLine($"Enseño {Subject} en Howgarts.");
  }
}