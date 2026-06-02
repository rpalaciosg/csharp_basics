partial class Program
{
  static void AnonymousFunctions()
  {
    //usando funcion anonima para calcular el cuadrado de un numero
    WriteLine($"Square of 5 is: {square(5)}");
    WriteLine($"Square with lambda of 6 is: {squareLambda(6)}");
    List<int> numbers = new List<int> {1, 2, 3, 4, 5};
    // usando una funcion anonima con LINQ para filtrar los numeros pares
    var evenNumbers = numbers.Where(n => n % 2 == 0); //devuelve una nueva lista
    WriteLine("Even numbers:");
    foreach(var num in evenNumbers)
    {
      WriteLine(num);
    }
  }
  
   // funciones anonimas, son funciones sin nombre que se pueden asignar a variables o pasar como
   //  argumentos a otras funciones. Se utilizan para crear funciones rapidas y concisas, 
   // especialmente en el contexto de delegados y expresiones lambda. 
   // Una funcion anonima se puede definir usando la palabra clave delegate seguida de la lista de
   //  parametros y el cuerpo de la funcion. Tambien se pueden usar expresiones lambda, que son una 
   // sintaxis mas corta para definir funciones anonimas.
   // usa la palabra clave Func para definir un delegado 
   // que toma un <int como parametro y devuelve un int>,
   //  y luego se asigna una funcion anonima con  la palabra clave 'delegate' que calcula el 
   // cuadrado del numero.
    static Func<int, int> square = delegate(int number)
    {
      return number * number;
    };

    // forma mas consisa usando expresion lambda
    // se usa la palabra clave 'Func' para definir un delegado 
    // que toma un <int como parametro y devuelve un int>,
    //  y luego se asigna una expresion lambda que calcula el cuadrado del numero.
    static Func<int, int> squareLambda = number => number * number;
    

    // cuando trabajamos con colecciones y LINQ, las funciones anonimas son muy utiles para definir 
    // criterios de filtrado, proyeccion, ordenamiento, etc.
}