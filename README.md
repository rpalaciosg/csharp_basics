# Csharp solid fundations

Reinforcing basics C# concepts

## Configuracion importacion Statica

Para qeu podamos usar solo `WriteLine` en lugar de `System.Console.WriteLine` aplicamos esta configuracion
en el archivo del proyecto `.csproj` y agregamos lo siguiente:

```xml
  <ItemGroup Label="Simplificar el uso de la consola">
    <Using Include="System.Console" Static="true"/>
  </ItemGroup>
```
