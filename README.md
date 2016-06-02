# cl1
A DotNet Core RC2 command line project on Linux using sqlite3

*Note* DI does not work in command line dotnet apps (by design) so thsi project shows how to configure EF w/o DI

Aftet cloning, on the command line run:
dotnet ef database update

After making changes to the model, run:
dotnet build
dotnet ef migrations add [MigrationName]
dotnet ef database update
