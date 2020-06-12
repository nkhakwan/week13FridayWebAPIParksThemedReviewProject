# _State And National Park Data_

#### _Epicodus Week13 Friday Review Project_

#### By _**Khan Sahab**_

## Description

_A website that keeps the data for State and National Parks and provide that data in the form of API to Authorized users only from other websites like Postman. It can add, edit, search and delete parks data.  All the data is kept in a table in the database_

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
3. CD to "StateNationalPks and run "dotnet restore" and "dotnet build".
4. Run "dotnet ef migrations add <yourtag>
5. Run "dotnet ef database update"
6. Run "dotnet watch run"
7. Data base is named s_n_pks but "dotnet ef database update would automatically create it and populate it with three parks.
8. You don't need to populate the table with parks as StateNationalPks.cs has been coded to seed three parks with update command.
9. run "dotnet watch run"
10. Against the norms appsettings.json is available for teachers viewing. Didn't include it in .gitignore.

## Technical Specs

#### I am deviating from usual way of writing specs in "| Spec | Input | Output |" manner as following these steps would be much more convinient.
1. _**Authenticat yourself**_
    * Open Postman and do a POST command  for http://localhost:5000/api/users/authenticate and put the follwoing in the body
    { "Id": 2, "Username": "Travis","Password": "test"} 

    * You'll recieve a token.

2. _**Recieve the data about all parks**_
  * Make a Get command at http://localhost:5000/api/parks/ . But before that:
  * Open tab "authorization-->Bearer token
  * And paste the token received in the token slot on the right
  * You'll get the parks data. All of the National and State Parks in the table.

3. _**Search Park with ParkId**_
  * Now keeping the token there you can make a Get command to http://localhost:5000/api/parks/3 and 
  * you'll get the data about Park with ParkID = 3

4. _**Add Park to the Data base**_
  * Keeping the token alive make a POST command at http://localhost:5000/api/parks/ with the following in the body
  * { "type": "National","name": "RedWood", "description": "Avenue of Giants need to be seen","rating": 7, "imageUrl": "https://cdn.travelpulse.com/images/65aaedf4-a957-df11-b491-006073e71405/c8f899f1-a4af-4ea3-b5dd-447ebbaeb40e/630x355.jpg" }
  * Now make a Get command to http://localhost:5000/api/parks/ and you'll see that instead of 3, 4 items are returned with "RedWood" forest park added.

5. _**Delet a Park**_
  * Make a DELETE Command thru postman with http://localhost:5000/api/parks/4 and 
  * you'll see park with ParkId 4 has been deleted.

6. _**Edit a Park Data**_
  * Make a PUT command thru Postman with http://localhost:5000/api/parks/4 and provide New data and 
  * you'll see data for park at ParkId 4 has been changed.

7. _**Search Park with TYPE, Name or Rating**_
  * Make a GET command thru Postman with http://localhost:5000/api/parks/?type=state and you'll get all the state parks. 
  * Make a GET command thru Postman with http://localhost:5000/api/parks/?type=national&rating=4 and 
  * you'll get all the national parks with rating of 4

## Known Bugs
 
None. Everything is working fine.
 
## Support and contact details

_Have a bug or an issue with this application? Email post_khan@yahoo.com_

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* Razor
* Git and GitHub
* mysql database
* Entity
* JWT (Jason Web Token)

## Brief Documentation for JWT
* Built with ASP.NET Core 2.2

* Following files were written into to implement JWT

    Controllers

        UsersController.cs

    Models

        User.cs

    Helpers

        AppSettings.cs

    Services

        UserService.cs

    appsettings.Development.json

    appsettings.json

    Program.cs

    Startup.cs

    StateNationalPks.csproj

* Tutorial is available at https://jasonwatmore.com/post/2018/08/14/aspnet-core-21-jwt-authentication-tutorial-with-example-api

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Khan Sahab_**
