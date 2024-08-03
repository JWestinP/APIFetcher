# Technical Assessment Submission

This repository contains my submission for the technical assessment, which involves using C#, Entity Framework, and SQL. The main functionality of this program is to obtain data from two given API endpoints, save it to a SQL Database, and display the saved data in the console.

## Features

- Fetch data from specified API endpoints.
- Store data in a SQL Server database.
- Display data in the console.

## Database Setup

To set up the database, I used SQL Server Management Studio 20. The database is named **`APIFetcherDB`**.

### Steps to Set Up the Database

1. **Create a New Database**:
   - Open SQL Server Management Studio.
   - Connect to your local SQL Server instance.
   - Create a new database named `APIFetcherDB`.

2. **Configure Connection String**:
   - Update the connection string in the `DatabaseContext` class.
   - Locate the line in `model.cs` at line 10.
   - Replace `Server=(INSERT LOCAL HOST SERVER NAME)` with your local server name.
   - optionsBuilder.UseSqlServer("Server=YOUR_SERVER_NAME;Database=APIFetcherDB;Trusted_Connection=True;");

### Documentations 
Here are some of the documentation and resources that I used as a guide during the development of this project:
1. **Microsoft**:
   - https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
   - https://learn.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
     


  




