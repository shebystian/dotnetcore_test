# dotnetcore_test
first test of microservice in dotnetcore

to run execute:

dotnet run
open http://localhost:3000

to create project template
dotnet new webapi -o MyMicroservice --no-https -f net5.0

to compile project:
dotnet build

to exec:
dotnet run

for changes in databases (exporta los cambios de la bd a nuestro modelo)
dotnet ef dbcontext scaffold "Server={INSTANCENAME};Database={DBNAME};Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models

(agregamos una migracion para agregar a la bd se debe especificar el contexto ya que existen mas de 1 por pruebas)
dotnet ef migrations add Game --context CatalogContext

(agregamos los cambios a la bd desde entity framework)
dotnet ef database update --context CatalogContext

use sql server in linux:
sqlcmd -S localhost -U SA -P '<password>'

query example in sqlcmd:
select * from Catalog.dbo.Game where nombre = 'Doom'