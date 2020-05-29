# **Scissorhands Salon**

### _Database Basics - Week 11 Project at Epicodus_

#### Author: **_Jessica Hvozdovich_**
#### May 29, 2020

### Description

_The purpose of this project is to create a C# web application and employ database basics with MySQL and Entity. It also demonstrates the use of MVC routes that follow RESTful convention. This application takes user input to display different Stylists and the Clients that belong to in a one to many relationship._

### Instructions for use:

1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/jhvozdovich/hair-salon.git
cd hair-salon (or the file name you created for the main directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project directory you can open all of the files with the command:
```
code .
```
4. Create a file within the HairSalon folder named appsettings.json.
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd=YOURMYSQLPASSWORDHERE;"
  }
}
```
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

5. If you need to install the REPL dotnet script enter the following command in your terminal: 
```
dotnet tool install -g dotnet-script
```
6. To install the necessary dependencies and start a local host, after replicating the database steps below run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:

```
CREATE DATABASE `hair_salon`;
USE `hair_salon`;

CREATE TABLE `Stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
);

CREATE TABLE `Clients` (
  `StylistId` int(11) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ClientId`)
) ;
```

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at jhvozdovich@gmail.com. Thank you for your input!  
_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/hair-salon/issues) here on GitHub._

### Technologies Used

* C#
* `ASP.NET` Core
* MVC
* MySQL
* Entity Framework Core
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can navigate to a page that lists Stylists** | User Input:"Click: View Stylists" | Output: “Edward, Tim, Sally” |
| **If no Stylists have been added a message appears** | User Input:"Click: View Stylists" | Output: “You have no Stylists listed! Add a few.” |
| **User can navigate to an Add Stylists Page** | User Input:"Click: Add Stylists" | Output: “Create a new Stylist.” |
| **User can fill out the Add Stylists Form** | User Input:"Enter New Stylist Name: Sweeney Specialty: Shaves" | Output: “Stylists: Edward, Tim, Sally, Sweeney” |
| **User can click on Stylists to view their details and Clients** | User Input:"Click: Sally" | Output: “Sally Specialty-Cuts and Color, Clients: Dr. Finkelstein, Mayor” |
| **If no Clients have been added a message appears** | User Input:"Click: View Clients" | Output: “You have no Clients listed.” |
| **User can navigate to a create new Clients page for each Stylist** | User Input:"Click: Sally Click: Add Client" | Output: “Client Form" |
| **User can add a new Client for each Stylist** | User Input:"Name: Vampire #3, Address: 925 Mausoleum Ave, Regular: True, Usual: Trim" | Output: “Sally Clients: Dr. Finkelstein, Mayor, Vampire #3” |
| **User can view Client details when clicked** | User Input:"Click: Dr. Finkelstein" | Output: “Client Details: Name: Dr. Finkelstein, Address: 111 Laboratory on the Hill Way, Regular: True, Usual: Shave” |
| **User can delete all Stylists** | User Input:"Click: Delete All" | Output: “You have no Stylists listed!” |
| **User can delete single Stylists** | User Input:"Click: Delete Stylist" | Output: “You have removed this Stylist!” |
| **User can delete all Clients** | User Input:"Click: Delete All" | Output: “This Stylists has no current Clients." |
| **User can delete single Clients** | User Input:"Click: Delete Client" | Output: “You have removed this Client!” |


#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Jessica Hvozdovich_**
