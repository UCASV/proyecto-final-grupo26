## Software utilizado
- JetBrains Rider 2021.1.2 .NET 5.0
- Microsoft SQL Server Management Studio 18
- SQL Server 2019 Express

## Sistema operativo
- Windows 10

## Paquetes externos
Paquetes de NuGet:
- Microsoft.EntityFrameworkCore.SqlServer 5.0.7
- Microsoft.EntityFrameworkCore.Design 5.0.7
- Microsoft.EntityFrameworkCore 5.0.7
- iTextSharp 5.5.13.2

## Patrones de diseño
__View Model:__ Implementamos este patron de diseño ya que no vimos necesario mostrar toda la informacion de los ciudadanos a la hora de buscar sus registros de citas para la vacuna, ya que se tiene la opcion de descargar e imprimir esta información para darsela al ciudadano se restingio a que se muestre solo el dui, nombre del ciudadano, fecha y hora de la cita para la primera dosis de la vacuna, fecha y hora de la segunda dosis de la vacuna y el lugar de vacunación.

## Requerimientos
- Antes de utilizar el programa se necesita crear la base de datos, en la carpeta "Bases de datos" se encuentra el script de dicha base con el nombre "ProCitas3.sql".

- Tener instalado JetBrains Rider 2021.1.2 con .NET 5.0 para poder correr el programa

## Manual de usuario
[ Manual de usuario]()
 
