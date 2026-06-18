/*
=============
🏆 Ejercicio 
=============
*/

// [X] 1. Crear una clase base "Employee" con las siguientes propiedades protegidas:
//    - Name (string)
//    - Salary (double)
//    - Position (string)
//
// [X] 2. Implementar un constructor en "Employee" que inicialice sus valores.
//
// [X] 3. Agregar un método virtual "CalculateBonus()" que retorne un bono del 5% del salario.
//
// [X] 4. Agregar un método "ShowInfo()" que muestre los detalles del empleado:
//    - Nombre
//    - Cargo
//    - Salario
//    - Bono calculado
//
// [X] 5. Crear dos clases derivadas de "Employee":
//    - "TeamLeader": Su bono es del 10% del salario.
//    - "Developer": Su bono es del 7% del salario.
//
// [ ] 6. Instanciar una lista de empleados con al menos los siguientes datos:
//    - Carlos (Team Leader, 5000)
//    - Ana (Developer, 4000)
//    - Laura (Team Leader, 6000)
//    - Luis (Developer, 3500)
//
// 7. Recorrer la lista de empleados y mostrar la información de cada uno con el método "ShowInfo()".

partial class Program
{
  static void ShowEmployeesInformation()
  { 
    List<Employee> employees = new List<Employee>();

    // TeamLeader Carlos = new TeamLeader("Carlos", 5000m);
    // Developer Ana = new Developer("Ana", 4000m);
    // TeamLeader Laura = new TeamLeader("Laura", 6000m);
    // Developer Luis = new Developer("Luis", 3500m);
    
    employees.Add(new TeamLeader("Carlos", 5000m));
    employees.Add(new Developer("Ana", 4000m));
    employees.Add(new TeamLeader("Laura", 6000m));
    employees.Add(new Developer("Luis", 3500m));

    WriteLine("Detalles de Empleados:");
    foreach(var employee in employees)
    {
      employee.ShowInfo();
    }
  } 
}

class Employee
{
  protected string? Name {get; set;}
  protected decimal? Salary {get; set;}
  protected string? Position {get; set;}
  
  public Employee( string name, decimal salary, string position){
    Name = name;
    Salary = salary;
    Position = position;
  }

  public virtual decimal? CalculateBonus()
  {
    return Salary * 0.05m;
  }
  
  public void ShowInfo()
  {
    WriteLine($"- Empleado: Nombre: {Name},\tCargo: {Position},\tSalario: {Salary:C},\tBono calculado: {CalculateBonus():C}");  
  }
}

// TeamLeader": Su bono es del 10% del salario.
class TeamLeader : Employee 
{
  //el base es para llamar explicitamente el constructor de nuestra clase base o padre.
  public TeamLeader(string name, decimal salary) : base(name, salary, "Team Leader")
  {}
  
  public override decimal? CalculateBonus()
  {
    return Salary * 0.10m;
  }
}

class Developer : Employee
{
  public Developer(String name, decimal salary) : base(name, salary, "Developer")
  {}

  public override decimal? CalculateBonus()
  {
    return Salary * 0.07m;
  }
}