> This is my submission for the technical assessment which involves using C#, Entity Framework, and SQL.
> The main function of this program is to obtain data from the two given API endpoints and save it to a SQL Database.
> The program also displays the saved data in the console.

DATABASE SETUP:
> To setup the database, I used the SQL Server Management Studio 20.
> I created a new database named "APIFetcherDB".

NOTES:
> You may need to run this command in a terminal: dotnet tool install --global dotnet-ef
> And run this command to refresh the project dependencies that were installed before in the project: dotnet restore
> Finally run this command to apply the migrations and update the database: dotnet ef database update

> This line of code, specifically in the parenthesis should be changed to whatever the local host server name in your machine is.
> Server=(INSERT LOCAL HOST SERVER NAME) in the model.cs file at line 10.


