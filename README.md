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

## Seccion : Clases, objetos, herencia y polimorfismo, propiedades

1. Definición y uso de clases en C#
2. Propiedades y métodos en clases
3. Creación e instanciación de objetos
4. Constructores y destructores
5. Herencia y reutilización de código
6. Polimorfismo en métodos, clases abstractas e interfaces
7. Visibilidad y encapsulamiento en C#
8. Implementación de ejercicios prácticos de gestión de inventario, flotas de buses y empleados

## Seccion 8: proyecto ASP.NET Core MVC
En el Proyecto [/MyFirstAPI](./MyFirstApi/)
Vamos a crear un proyecto de un API usando el sigueitne comando y plantilla:

```bash
dotnet new webapi --name MyFirstApi
```
### Agregar swagger documentation OpenAPi

1. debo instalar estos paquetes:
```bash
dotnet add package Swashbuckle.AspNetCore
dotnet add package Swashbuckle.AspNetCore.Annotations
```
- Si quiero una interfaz moderna instalo el siguiente paquete:
```bash
dotnet add package AspNetCore.Scalar
```
2. Modifcar el codigo de `Program.cs`:

3. (Opcional) HAbilitar comentarios XML para mejor documentacion.
  - Agregar estas lineas en el archivo `.csproj`:
  ```xml
    <PropertyGroup>
      <GenerateDocumentationFile>true</GenerateDocumentationFile>
      <NoWarn>$(NoWarn);1591</NoWarn>
    </PropertyGroup>
  ```
  - Luego descomenta las líneas en AddSwaggerGen que incluyen los comentarios XML.