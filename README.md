# CDAC .NET Learning Repository

This repository contains a comprehensive collection of C# and .NET examples, exercises, and assignments designed for learning and reference. It covers core C# programming concepts, the .NET Collection framework, and web development with ASP.NET Core and MVC.

## Repository Structure

The repository is organized into several main directories, each focusing on a specific technology area or topic:

### 1. `cdac-dotnet/` - Core C# Concepts
This directory contains console applications demonstrating fundamental C# language features and Object-Oriented Programming (OOP) principles.
- **OOP:** Classes (`ExClasses`), Inheritance (`ExInheritance`), Polymorphism (`ExMethodOverriding`, `ExMethodOverloading`), Abstract Classes (`ExAbstractClass`), Interfaces (`ExMultiInterface`).
- **Basics:** Data types (`ExDatatypes`), Arrays (`ExArray`, `ExJaggedArray`), Loops (`ExLoop`), Conditions (`ExConditions`).
- **Advanced:** Partial Classes (`ExPartialClass`), Static Members (`ExStaticMethods`), Structs (`ExStructImp`).

### 2. `Collections/` - Data Structures
Examples illustrating how to use various C# collections to store and manipulate data.
- **Legacy/Non-Generic:** `ArrayList` (`ExArrayList`), `HashTable` (`ExHashTable`).
- **Generic:** `Dictionary` (`ExDictionary`), `HashSet` (`ExHashSet`), `SortedList` (`ExSortedList`).
- **Operations:** Finding elements, sorting, and iterating.

### 3. `ASP.NEt/` - ASP.NET Core Fundamentals
Projects demonstrating the building blocks of ASP.NET Core applications.
- **Architecture:** Middleware (`ExOfMiddleware`, `ExOfCustomMiddleware`), Routing (`Routing.md`), Layouts (`ExOfLayout`).
- **Controllers:** Action Results (`ExOfActionResult`), Controller logic (`ExOfController`).
- **Views:** Razor Views (`ExOfRazorView`), HTML Helpers (`ExOfHtmlRaw`).

### 4. `MVC/` - ASP.NET MVC
Examples focused on the Model-View-Controller design pattern.
- **Security:** CSRF Attack and Defense (`CSRFAttack`, `CSRFDefence`).
- **Optimization:** Bundling and Minification (`Bundling&Minimization`).
- **Web API:** Testing Web APIs (`TestWebAPI`).

### 5. `Assignment/` & Other Directories
- **Assignment/**: Contains solutions to various assignments (Assignment1, Assignment2, etc.) and test questions.
- **EmployeeManage/**, **Product-Test/**, **PruductApp/**: Larger, likely multi-layered application examples or specific case studies.

## Getting Started

To run any of the console applications or web projects:

1.  **Prerequisites:** Ensure you have the .NET SDK installed (compatible with the project versions, likely .NET 6, 7 or 8).
2.  **Open the Solution:** You can open individual `.sln` files (e.g., `cdac-dotnet.sln`, `ASP.NEt.sln`) in Visual Studio or open the root folder in VS Code.
3.  **Build and Run:**
    -   For **Console Apps**: Navigate to the specific folder (e.g., `cdac-dotnet/ExInheritance`) and run `dotnet run`.
    -   For **Web Apps**: Navigate to the project folder (e.g., `ASP.NEt/ExOfMiddleware`) and run `dotnet run` or start debugging in your IDE.

## Learning Path

If you are new to .NET, it is recommended to explore the folders in this order:
1.  `cdac-dotnet/` (Language basics)
2.  `Collections/` (Data management)
3.  `ASP.NEt/` (Web basics)
4.  `MVC/` (Web architecture)