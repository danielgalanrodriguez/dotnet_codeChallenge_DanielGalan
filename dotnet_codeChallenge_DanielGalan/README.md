# dotnet_codeChallenge_DanielGalan.
Repository for Global Gaming code challenge 2.1 for .NET applicants

## Installation
### Requirements
The requirements to use this API are the followings:

* .NET Core 2.2
* Nuget MySql.Data package
* Nuget Nunit
* MySql server

### Steps
This steps are for linux O.S. . If you are using other O.S please change steps 5-8 for the appropriates of your O.S . 

1. Download the repository.
2. Install Nuget packages Nunit and MySql.data in dotnet_codeChallenge_DanielGalan/dotnet_codeChallenge_DanielGalan .
3. Import the example database 'bookShop.sql' in your MySql server.  
4. Change the configuration string 'myDbConnectionString' in dotnet_codeChallenge_DanielGalan/dotnet_codeChallenge_DanielGalan/Models/BookShopDbConnection.cs with your personal MySql configuration.
5. To run the API application open a terminal with the working directory dotnet_codeChallenge_DanielGalan/dotnet_codeChallenge_DanielGalan/ .
6. Execute the next command and open the URL generated:
```bash
dotnet run
```
7. To run the tests open a terminal with the working directory dotnet_codeChallenge_DanielGalan/dotnet_codeChallenge_DanielGalan.Tests/ .
8. Execute and see results in terminal:
```bash
dotnet test 
```

### Pakages needed
[Nuget MySql.Data](https://www.nuget.org/packages/MySql.Data/)

[Nuget Nunit](https://www.nuget.org/packages/NUnit/)



## Decisions made

### Version

I chosed the last stable version of .NET core (version 2.2.203) because I use linux based O.S. to programme and .NET framework its not available.

### Database

The database has just 3 tables: 'Users', 'Books' and 'Purchases'. The 'Purchases' table creates a relation between 'Users' and 'Books' with the information of the purchase. I only have 3 tables to keep the challenge as simple as possible.\n In case it is wanted more complex functionalities, such as allow the user to buy more than one book in the same transaction, additional tables can be easily created and, if needed, just small changes in the already created tables are required and they can be easily done.

### API

For the API I have used an empty template of an ASP.net core application and I use MVC to handle each endpoint with its controller.\n
This way more controllers can easily be create to handle more endpoints and the already created controllers can be easily removed to delete existing endpoints.
The controllers are located in the folder 'Controllers' inside the project root folder.

To carry out the actions to the database, I have created a model folder that includes the classes that implement the actions.
There is a class 'BookShopDbConnection' that creates the connection to the database with the specific configuration. The rest of the classes implement the actions for each table of the database.  

### API endpoints

Verb            endpoint                    action

POST            api/users                   A user can register to the platform.

DELETE          api/users/{id}              A user can un-register to the platform. 

GET/PUT         api/user/{id}               A user can access their personal data and update their details (no                                                      authentication required).

GET             api/books                   A user can list all books currently available in the store.

GET             api/books/{id}              A user can list the details of a specific book.

POST            api/purchases               A user can purchase books from the store.

GET             api/purchases?user_id=id    A user can access his purchase history.

### Json examples
Endpoints that consumes Json:

POST     api/users:
{
	"email": "newUser.email.com",
	"password":"newUserpass",
	"name":"newUserName",
	"surname":"newUserSurname"	
}

PUT         api/user/{id}:
{
	"email": "ModifiedUser.email.com",
	"password":"ModifiedUserpass",
	"name":"ModifiedUserName",
	"surname":"ModifiedUserSurname"	
}

POST          api/purchases:

{
	"book_id": "3",
	"user_id":"1"
}


### Testing

I use Nunit package to test the code because it is the most popular and used. I have decided not to test the get requests because it is not a critical part and I do not have many time to spend creating tests for this requests.

To test the update of a user I always update the user with id 1.

To test the elimination of a user, a new user is created and then deleted. I wanted to delete the user created to test the registration this would be my goal if I had more time.

### Logging Framework

I use the Logging extension provided in .NET core because it is the most simple way to display logs that I have found.

I used it to check the endpoint hits from the controller.