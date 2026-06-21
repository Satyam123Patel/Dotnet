# .NET Learning Notes

These notes are derived from the examples present in this repository. They cover key concepts in C#, Collections, and ASP.NET Core.

---

## Part 1: C# Core Concepts (`cdac-dotnet/`)

### Object-Oriented Programming (OOP)
*   **Inheritance (`ExInheritance`):**
    *   Allows a class (Child/Derived) to acquire properties and methods of another class (Parent/Base).
    *   In C#, the base class constructor is executed *before* the child class constructor.
    *   Use the `:` symbol to inherit (e.g., `class Hyundai : Mycar`).
*   **Polymorphism:**
    *   **Overloading (`ExMethodOverloading`):** Same method name, different parameters (compile-time polymorphism).
    *   **Overriding (`ExMethodOverriding`):** Redefining a base class method in a derived class using `virtual` and `override` keywords (runtime polymorphism).
    *   **Method Hiding (`ExMethodHiding`):** Using the `new` keyword to hide a base member inheritance.
*   **Abstraction (`ExAbstractClass`, `ExMultiInterface`):**
    *   **Abstract Class:** Cannot be instantiated. Can contain abstract methods (no body) and concrete methods.
    *   **Interface:** A contract defining methods/properties without implementation (prior to C# 8). Classes "implement" interfaces. C# supports implementing multiple interfaces.

### Language Features
*   **Static Members (`ExStaticMethods`, `ExStaticVariable`):** Belong to the class itself rather than a specific object instance. Accessed via `ClassName.MemberName`.
*   **Partial Classes (`ExPartialClass`):** Allows splitting a class definition across multiple files. All parts are combined when compiled.
*   **Structs (`ExStructImp`):** Value types (stored on stack) typically used for small data structures, as opposed to Classes which are reference types (stored on heap).
*   **Arrays (`ExArray`, `ExJaggedArray`, `ExMultiDimArray`):**
    *   Fixed-size collections of same-type elements.
    *   **Jagged Array:** An array of arrays (e.g., `int[][]`), where each "row" can have a different length.
    *   **Multi-dimensional Array:** Rectangular grid (e.g., `int[,]`).

---

## Part 2: Collections (`Collections/`)

Collections are used to store, manage, and manipulate groups of objects.

### Non-Generic (Legacy)
*   **ArrayList (`ExArrayList`):**
    *   Stores elements as `object`, meaning it can hold any data type mixed together.
    *   Requires **Boxing** (converting value type to object) and **Unboxing** (converting object back to value type), which has performance costs.
*   **HashTable (`ExHashTable`):**
    *   Stores key-value pairs as `object`. Keys are hashed for fast lookups.

### Generic (Preferred)
*   **List<T> (implied context):** A strongly typed list. No boxing/unboxing if `T` is a value type.
*   **Dictionary<TKey, TValue> (`ExDictionary`):**
    *   Strongly typed key-value pairs.
    *   Keys must be unique. Fast lookups.
*   **HashSet<T> (`ExHashSet`):**
    *   Collection of unique elements. Useful for removing duplicates or mathematical set operations.

---

## Part 3: ASP.NET Core (`ASP.NEt/`)

### Application Startup & Configuration
*   **Program.cs:** The entry point. Sets up the generic host, dependency injection (DI) container, and middleware pipeline.
    ```csharp
    var builder = WebApplication.CreateBuilder(args);
    // Add services to the container (DI)
    builder.Services.AddControllersWithViews();
    var app = builder.Build();
    // Configure HTTP request pipeline (Middleware)
    app.MapGet("/", () => "Hello World!");
    app.Run();
    ```

### Middleware (`ExOfMiddleware`, `ExOfCustomMiddleware`)
*   Software components assembled into an application pipeline to handle requests and responses.
*   Executed sequentially.
*   **Built-in:** `UseRouting`, `UseStaticFiles`, `UseAuthentication`.
*   **Custom:** You can write your own middleware to handle logging, error handling, etc.

### Controllers & Action Results (`ExOfActionResult`)
*   **Controller:** Handles incoming HTTP requests.
*   **ActionResult:** The return type of a controller method (Action). Common types:
    *   `ViewResult` (returns an HTML view).
    *   `JsonResult` (returns JSON data).
    *   `ContentResult` (returns plain text).
    *   `IActionResult` (interface allowing multiple return types).

### Routing
*   Determines how URL paths map to Controller Actions.
*   **Convention-based:** `/{Controller}/{Action}/{Id?}`
*   **Attribute-based:** `[Route("api/[controller]")]` directly on methods/classes.

---

## Part 4: MVC Architecture (`MVC/`)

*   **Model:** Represents data and business logic.
*   **View:** The User Interface (usually `.cshtml` Razor files). Displays data.
*   **Controller:** Accepts input, interacts with the model, and selects a view to render.
*   **CSRF (Cross-Site Request Forgery):**
    *   An attack where a malicious site tricks a user's browser into sending a request to your site.
    *   **Defense (`CSRFDefence`):** Use Anti-Forgery tokens (`@Html.AntiForgeryToken()`) in forms to validate that the request originated from your application.
