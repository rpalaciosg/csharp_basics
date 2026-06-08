partial class Program
{
  // Polimorfismo: significa muchas o multiples formas, es cuando tenemos muchas clases que estan
  // relacionadas entre si por herencia
  // LA herencia permitia heredar campos y metodos de otra clases
  // En el caso del polimorfismo tiene 2 usos importantes:
  // Polimorfismo de metodos: es un clase derivada puede sobreescribir metodos en su clase base.
  // Polimorfismo de Clases: una clase base puede representar multiples clases derivadas.
  public static void Polimorfismo()
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
  // Con polimorfismo permitira que cuando haya la herencia poder sobreescribir a ese metodo.
  public virtual void Greet()
  {
    WriteLine($"Hola Im {Name}");
  }
}

// aqui la herencia, class hijo : padre
class HogwartsStudent: Character
{
  public string? House {get; set;}

 // con override voy a sobreescribir el metodo  Greet porque tengo acceso por la herencia de : character
  public override void Greet(){
    // hacemos la invocacion del mismo metodo usando `base.`
    // base.Greet();
    
    //con esta forma en cambio estamos sobreescriendo el metodo
    WriteLine($"Hola, soy {Name} y soy estudiante.");
  }

  public void ShowHouse()
  {
    WriteLine($"Pertenezco a la casa {House} en Hogwarts.");    
  }
}

class HogwartsProfessor : Character
{
  public string? Subject {get; set;}

 // sobreescrbiendo el metodo base de la clase heredada Character 
  public override void Greet()
  {
    WriteLine($"Hola, soy {Name} y soy profesor.");
  }
  public void MySubject()
  {
    WriteLine($"Enseño {Subject} en Hogwarts.");
  }
}