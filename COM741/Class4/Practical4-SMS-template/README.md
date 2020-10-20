PRACTICAL 4

README 
======
This is a basic EntityFramework project used to demonstrate connection with a Sqlite database. I used Sqlite as it does not require any additional installations on your computer.

To run the project simply open a command prompt 'in the solution folder'. 
(The example below assumes this project was installed in my home folder)
Now execute the project in the solution named SMS.Data

C:\Users\aiden\SMS> dotnet run -p SMS.Data

You should see the following output

All Students
Id:1 Name:Homer Course:COM741 Age:45
Id:2 Name:Marge Course:COM741 Age:40
Id:3 Name:Bart Course:Sleeping Age:13
Id:4 Name:Lisa Course:Maths Age:10

The Adults
Id:1 Name:Homer Course:COM741 Age:45
Id:2 Name:Marge Course:COM741 Age:40

C:\Users\aiden\SMS>


INSTRUCTIONS ON HOW TO CREATE THIS SOLUTION/PROJECT 
===================================================
If you want to know how this solution/project was created then follow the instructions below. Assumes you are using Windows 10, dotnet core 2.2 and VSCode

OPTIONAL
If you need to install Dotnet Core and VSCode download and install from links below, otherwise jump to CREATE PROJECT SMS

https://dotnet.microsoft.com/download/dotnet-core/3.1
For Windows - select .NET Core Installer x64
For Mac - select .NET Core Installer x64

https://code.visualstudio.com/download
Choose version for your operating system (Windows/Mac/Linux)

Install both and then proceed with the following instructions

CREATE PROJECT SMS
==================
1. Open a command prompt by Typing 'cmd' into the search bar
   In the command prompt create a folder to host the project 
   and move into that folder. For simplicity I am just creating
   the new folder in my home directory

2. To create a folder use the 'mkdir' command 
c:\Users\aiden> mkdir SMS   

3. To Change directory to the new folder use the 'cd' command 
c:\Users\aiden> cd SMS
c:\Users\aiden\SMS>

4. Now in the new SMS folder create a solution
c:\Users\aiden\SMS> dotnet new sln

5. Now create a console project named SMS.Data
c:\Users\aiden\SMS> dotnet new console -o SMS.Data

6. Now add the new project to the solution
c:\Users\aiden\SMS> dotnet sln add SMS.Data

7. Now change to the new project directory
c:\Users\aiden\SMS> cd SMS.Data
c:\Users\aiden\SMS\SMS.Data>

7. Now add the following packages to the SMS.Data project.
   Note I am displaying the current folder as c:> for brevity

c:> dotnet add package Microsoft.EntityFrameworkCore
c:> dotnet add package Microsoft.EntityFrameworkCore.Sqlite
c:> dotnet add package Microsoft.EntityFrameworkCore.SqlServer

