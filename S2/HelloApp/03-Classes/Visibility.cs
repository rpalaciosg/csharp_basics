partial class Program
{
  static void Visibility()
  {
    Jedi jedi = new Jedi();
    jedi.PowerLevel = 5000;
    jedi.LightsaberColor = "azul";
    //
    // jedi.UseForce();

    //solo muestra lo publico
    // WriteLine(jedi.PublicField);
    // WriteLine(jedi.PrivateField);
    // WriteLine(jedi.ProtectedField);
    // o si queremos acceder a aquello provate o protected lo hacemos con un metodo de la clase
    // jedi.RevealSecrets();

    Sith sith = new Sith();
    // sith.ShowProtected();
    sith.PowerLevel = 4000;
    sith.LightsaberColor = "red";
    sith.UseForce();
  }
}

//interface: es como un contrato.
interface IForceUser
{
  // todo usuario de  fuerza debe tener al menos estas 2 propiedades
  int PowerLevel {get; set;}
  string? LightsaberColor {get; set;}

  void useForce();
}

//public: tiene acceso desde cualquier parte del prpgrama
//provate: solo tienen acceso los que estan dentro de esa clase
//protected: es accesible dentro de esta clase y clases derivadas
class Jedi : IForceUser
{
  public string PublicField = "Soy un Jedi y mi poder es conocido";
  private string PrivateField = "Mis pensamientos mas profundos son privados";
  protected string ProtectedField = "El lado escuro no debe conocer mis secretos";
  public int PowerLevel {get; set;}
  public string? LightsaberColor {get; set;}

  public void UseForce()
  {
    WriteLine($"Soy un Jedi con un sable de luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
  }

  private void Meditate()
  {
    WriteLine($"Estoy en profunda meditacion con la fuerza");
  }

  protected void Train()
  {
    WriteLine($"Estoy entrenando para convertirme en el mejor Jedi.");
  }

  public void RevealSecrets()
  {
    WriteLine(ProtectedField);
    WriteLine(PrivateField);
    Meditate();
  }

    public void useForce()
    {
        throw new NotImplementedException();
    }
}


// clase derivada que
class Sith : Jedi,IForceUser
{
  public new void UseForce()
  {
    WriteLine($"Soy un sith con un sable de luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
  }

  public void ShowProtected()
  {
    WriteLine(ProtectedField);
    Train();
  }
}
//podemos heredar una sola clase
//pero podemos implementar multiples interfaces separadas por coma.
