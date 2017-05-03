Sales Tracker Website
=========================

**By Alexandra Holcombe && JiWon Kang**
Webpage built with .NET Core using Entity Framework migrations, SQL Server, and Identity Authentication.  Two-day project practicing AJAX and testing for Week 3 of Epicodus .NET curriculum.

## Planning
### **1.  Configuration/Dependencies**
  * .NET Core
  * Entity Framework
  * Identity Authorization Framework

### **2.  Specs**
  * Create CRUD for each of the Models
  

### **3.  Integration**

 **Models**
  * user (username, password, totalCommission, list<transaction>)
  * item (id, name, price, quantity, cost)
  * transaction (id, user, list<item>, value, list<comment>)
  * comment (id, user, description)
  * totalSales (dollar value)
  * cart (list<item>)

  **Roles**
  * Sales Associate
    - See only this user's profile
  * Manager
    - See all profiles
    - Manage associates

  **Views**
  * Associate Profile
    > List of transactions, commission
  * Transaction details
    > Associate Comments
    > List of items & item details
    > Total transaction value
  * Products
    > All inventory
  * Product details
    > All information about product
  * Associates page
    > ONLY visible to Manager
    > Can CRUD Associates
  * Inventory Management
    > ONLY visible to Manager
    > Can CRUD products

### **4.  UX/UI**
  * Uses Bootstrap

### **5.  Polish**
  * See if refactoring is needed
  * Delete unused code
  * Revisit README

***

## Installation

### Requirements
* Microsoft .NET Core Tools (Preview 2)
* (If using Visual Studio) Visual Studio 2015 Update 3

[Microsoft .NET Core 1.0.0 Release Notes](https://github.com/dotnet/core/blob/master/release-notes/1.0/1.0.0.md)
[Release Announcement](https://blogs.msdn.microsoft.com/dotnet/2016/06/27/announcing-net-core-1-0/)

### To Build Database
In command line:
    > dotnet ef database update


## Technologies Used
* C#
* Visual Studio 2015 Update 3
* Entity Framework 1.0.0 Preview 2
* .NET Core 1.0.0 Preview 2 003131
* Microsoft SQL Server Management Studio
* Identity User Authentication

## Support and contact details
Please contact Allie Holcombe at alexandra.holcombe@gmail.com or JiWon Kang at jiwonk42@gmail.com with any questions, concerns, or suggestions

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe && JiWon Kang_**
