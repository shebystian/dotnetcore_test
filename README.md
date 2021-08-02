# dotnetcore_test
first test of microservice in dotnetcore

to run execute:

dotnet run
open http://localhost:3000

to create project template
dotnet new webapi -o MyMicroservice --no-https -f net5.0

for changes in databases
dotnet ef dbcontext scaffold "Server={INSTANCENAME};Database={DBNAME};Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models