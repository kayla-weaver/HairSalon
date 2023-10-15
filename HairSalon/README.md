Claire's Salon
By: Kayla Weaver
Description
A hair salon Application created with ASP.NET Core MVC.

Technologies Used
C#
ASP.NET Core MVC
Razor Pages
VScode 
MySQL Workbench


Setup/Installation Requirements
Note: An installation of the .NET SDK is required in order to run this application locally. 

Clone this repo.



Set up the Database: 
Open MySQL Workbench and navigate to the Administration tab
Under the Management label, click Data Import/Restore
Under the Import Options tab, select the circle for Import from Self-Contained File and click the small button with two dots after the text box
In the window that pops up, navigate to the root level of this project, titled HairSalon.Solution and select the file titled kayla_weaver.sql
Under the Default Target Schema tab, select the New button and create a name for your new database
Verify your database is named properly and click the Start Import button. Once complete, you will receive a confirmation from MySQL
Once your import is complete, navigate to the Schemas tab at the top of the page. Once you click the small refresh icon in the upper right corner, your new database should populate within the list
You will be able to click the new database name, and click the tables tab to verify that both the clients and stylists tables were imported properly

Navigate to the project directory: $ cd HairSalon

Run $ dotnet watch run in the command line to start the project in development mode with a watcher.

Open the browser at: https://localhost:5001. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: Redirecting to HTTPS and Issuing a Security Certificate.


Connecting the database:
Return to your computer's terminal application to your newly cloned project
Within the production level of this directory, called HairSalon, create a new file called appsettings.json
Input the following code into your appsettings.json file { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];" } }
Replace [ YOUR-DB-NAME ] with the name of the database you just imported to MySQL Workbench
Replace [ YOUR-USER-HERE ] with your username for MySQL Workbench
Replace [ YOUR-PASSWORD-HERE ] with your password for MySQL Workbench
Make sure you save all changes you've made to the file.

Known Bugs:
No known bugs :)

License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) Kayla Weaver 2023