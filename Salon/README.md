Claire's Salon
By: Kayla Weaver
Description
A hair salon Application created with ASP.NET Core MVC.

Technologies Used
C#
ASP.NET Core MVC
Razor Pages
Setup/Installation Requirements
Note: An installation of the .NET SDK is required in order to run this application locally. See Here for installation.
Clone this repo.

Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "Salon.Solution".

Create a file named appsettings.json: $ touch appsettings.json

Within appsettings.json add the following code, replacing the uid and pwd values with your own username and password for MySQL.

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=salon;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
  }
}
Set up the Database. Follow the instructions in the LearnHowToProgram.com lesson "Creating a Test Database: Exporting and Importing Databases with MySQL Workbench" to use the ryans_todo_from_section3.sql file located at the top level of this repo to create a new database in MySQL Workbench with the name ryans_todo_from_section3.

Navigate to the project directory: $ cd Salon

Run $ dotnet watch run in the command line to start the project in development mode with a watcher.

Open the browser at: https://localhost:5001. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: Redirecting to HTTPS and Issuing a Security Certificate.

Known Bugs
Database not yet setup
License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) Kayla Weaver 2023