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
  
## Agregar Healthchecks
instalo el paquete para poder ver formato json
```bash
dotnet add package AspNetCore.HealthChecks.UI.Client
```

## Dashboard visual de Health checks
Con una interfaz visual para monitorear:

```bash
dotnet add package AspNetCore.HealthChecks.UI
# si da warnings de seguridad en kubernetes client ejecutar mejor
   dotnet add package AspNetCore.HealthChecks.UI --version 8.0.1
# si el problema continua mejor actualizar directamente kubernetes-client
  dotnet add package KubernetesClient --version 15.0.2
dotnet add package AspNetCore.HealthChecks.UI.Client
dotnet add package AspNetCore.HealthChecks.UI.InMemory.Storage
```

Si la aplicación no usa Kubernetes, puedes ignorar esta advertencia de forma segura. Agrega esto a tu archivo .csproj:
xml
<PropertyGroup>
    <NoWarn>$(NoWarn);NU1902</NoWarn>
</PropertyGroup>

## Migrar de .sln a .slnx
USamos el comando:
```bash
dotnet sln migrate
```
Esto nos crea un archivo de solucion mas entendible para humanos ya que esta en formato .xml

## Seccion 9: Api de ejmplo para practicar

1. Crear el proyecto:
```bash
  dotnet new webapi --name TaskMasterAPI
```
2. En caso de que salga un warning por vulnerabilidad de la version 2.0.0 del paquete `Microsoft.OpenApi`:
```bash
  dotnet add package Microsoft.OpenApi
```
- Esto agregara y buscar la version mas estable y sin la vulnerabilidad que sea compatible con el proyecto.

3. Para limpiar todo el proyecto y verificar que ya no exista warnings ejecutamos:
```bash
  dotnet restore
```
