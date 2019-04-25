# dotnet_codeChallenge_DanielGalan.
Repository for Global Gaming code challenge 2.1 for .NET applicants

## Installation

### Pakages needed
Nuget MySql.Data

## Decisions made

### Version

I chosed the last stable version of .NET core (version 2.2.203) because I use linux based O.S. to programme and .NET framework its not available.

### Database

The database has just 3 tables: 'Users', 'Books' and 'Purchases'. The 'Purchases' table creates a relation between 'Users' and 'Books' with the information of the purchase. I only have 3 tables to keep the challenge as simple as possible. In case it is wanted more complex functionalities, such as allow the user to buy more than one book in the same transaction, additional tables can be easily created and, if needed, just small changes in the already created tables are required and they can be easily done.

### API

For the API I have used an empty template of an ASP.net core application and I use MVC to handle each endpoint with its controller.
This way more controllers can easily be create to handle more endpoints and the already created controllers can be easily removed to delete existing endpoints.
The controllers are located in the folder 'Controllers' inside the project root folder.

To carry out the actions to the database, I have created a model folder that includes the classes that implement the actions.
There is the class 'BookShopDbConnection' that creates the connection to the database. The other classes implement the actions for each table of the database.  