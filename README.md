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
