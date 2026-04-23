# 🚀 .NET 10 + C# 14 Complete Roadmap (6 Months)
### Zero se Production-Level Backend Developer Banne Ki Journey (Hinglish Edition)

---

## 📖 Introduction - Pehle Ye Padho!

Bhai/Behen, welcome to your **.NET journey**! Tumhara Python background hai, toh bahut saari concepts familiar lagengi. Par C# ek **strongly-typed, compiled** language hai — matlab galtiyan compile-time pe pakdi jati hain, runtime pe nahi. Ye enterprise software ka backbone hai — banks, healthcare, government, Microsoft ki har cheez isi pe chalti hai.

### 🎯 6 Months Mein Kya Milega?
- **Month 1**: C# Language Fundamentals
- **Month 2**: Object-Oriented Programming (OOP) mastery
- **Month 3**: Advanced C# (Async, LINQ, Delegates, Modern Features)
- **Month 4**: ASP.NET Core Web API development
- **Month 5**: Databases (SQL Server + EF Core + NoSQL)
- **Month 6**: Enterprise Architecture, Testing, DevOps aur Deployment

### 🛠️ Tools Jo Install Karne Honge (Day 1 pe)
1. **.NET 10 SDK** (November 2025 mein LTS release hua) - `dotnet.microsoft.com` se download karo
2. **Visual Studio 2022/2026** (Community Edition FREE) — full-featured IDE
3. **VS Code** + C# Dev Kit extension — lightweight option
4. **SQL Server Express** + **SSMS** (SQL Server Management Studio) — Month 5 ke liye
5. **Git** + **GitHub account** — version control
6. **Postman** ya **Bruno** — API testing ke liye
7. **Docker Desktop** — Month 6 ke liye

### 📚 Daily Study Plan Recommendation
- **Weekdays**: 2-3 ghante (1hr theory + 1-2hr coding)
- **Weekends**: 4-5 ghante (chapter project banao)
- **Rule**: Har topic ke baad 10 questions SOLVE karo — padhna kaam nahi karta, likhna kaam karta hai!

### ⚠️ Golden Rules
1. **Code likho, mat copy karo** — har example khud type karo
2. **GitHub pe daily push** — employers tumhara commit history dekhte hain
3. **Notes banao** — apni language mein (Hinglish ya jo comfortable ho)
4. **Stuck ho toh fine** — 30 min khud try karo, phir Google/AI se help lo
5. **Har chapter ka project LinkedIn pe post karo** — visibility milegi

---

# 🗓️ MONTH 1: C# FUNDAMENTALS (Weeks 1-4)

## 📘 Chapter 1: .NET Ecosystem Aur Setup (Week 1)

### Topic 1.1: .NET Kya Hai aur Kaise Kaam Karta Hai?

**Concepts to Learn:**
- .NET vs .NET Framework vs .NET Core vs .NET 5/6/7/8/9/**10**
- CLR (Common Language Runtime) kya karta hai
- BCL (Base Class Library) aur FCL (Framework Class Library)
- JIT (Just-In-Time) compilation kaise kaam karta hai
- IL (Intermediate Language) / MSIL
- Managed vs Unmanaged code
- Garbage Collector (GC) ka role
- .NET 10 ke naye features ka overview (LTS release — 3 saal support)
- NativeAOT kya hai (ahead-of-time compilation)

**Python se Comparison**: Python interpreted hai, C# compiled (IL → native code via JIT). Python dynamic typing, C# static typing.

### 🎯 Practice Questions (Topic 1.1):
1. .NET Framework aur .NET 10 mein 5 differences likho.
2. CLR kya kaam karta hai? 3 responsibilities batao.
3. JIT compilation aur interpreted execution mein fark samjhao.
4. Managed code ka matlab kya hai? Ek example do.
5. Garbage Collector kyun zaroori hai? Memory leak kaise rokta hai?
6. IL/MSIL kya hai? Kyun zaroori hai?
7. .NET 10 LTS hai — LTS ka matlab kya hai aur iska fayda kya hai?
8. NativeAOT aur JIT mein fark kya hai? Kab kaunsa use karoge?
9. BCL mein 5 important namespaces ke naam batao.
10. Cross-platform ka matlab kya hai? .NET 10 kaunse OS support karta hai?

---

### Topic 1.2: .NET 10 SDK Install Karna aur First Project

**Concepts:**
- `dotnet` CLI commands (`dotnet --version`, `dotnet new`, `dotnet run`, `dotnet build`)
- Project templates (`console`, `classlib`, `webapi`, `mvc`, `blazor`)
- `.csproj` file structure samjho
- `global.json` kya karta hai
- NuGet packages install karna (`dotnet add package`)
- Solution (`.sln`) files vs Projects
- File-based apps (naya .NET 10 feature — single file C# scripts!)

**Pehla Program:**
```csharp
// Program.cs
Console.WriteLine("Namaste Duniya!");  // Hello World in Hinglish!
```

### 🎯 Practice Questions (Topic 1.2):
1. Terminal mein `dotnet --info` run karke output ka screenshot lo.
2. `HelloWorld` naam ka console project banao CLI se.
3. `.csproj` file open karke TargetFramework badlo aur samjhao kya hua.
4. `Newtonsoft.Json` package install karo CLI se.
5. Ek single-file C# script likho (.NET 10 file-based apps feature).
6. Visual Studio Code mein C# Dev Kit install karo aur debugger chalao.
7. `dotnet build` aur `dotnet run` mein kya fark hai?
8. `bin/` aur `obj/` folders mein kya hota hai?
9. Ek solution banao jismein 2 projects ho (console + classlib).
10. Ek project ko Release mode mein build karo — file size compare karo Debug vs Release.

---

### Topic 1.3: Visual Studio IDE ka Tour

**Concepts:**
- Solution Explorer, Toolbox, Properties window
- IntelliSense (C# ka autocomplete - bahut powerful!)
- Breakpoints, Watch window, Immediate window
- Shortcuts (F5, F10, F11, Ctrl+. for quick fixes)
- Debugger ka use karna
- Extensions install karna (ReSharper, CodeMaid)

### 🎯 Practice Questions (Topic 1.3):
1. 5 VS keyboard shortcuts likho jo daily use honge.
2. Breakpoint set karke variable ki value inspect karo.
3. Conditional breakpoint kya hai? Ek example do.
4. Watch window mein expression add karo.
5. "Edit and Continue" feature kya hai?
6. Call Stack window mein kya dekhne ko milta hai?
7. "Step Into" aur "Step Over" mein kya fark hai?
8. Ek bug ko debug karke theek karo (intentionally galti karo).
9. Output window aur Debug Console mein kya fark hai?
10. Hot Reload feature use karke code change karo without restart.

---

### 🏆 Chapter 1 Project: **Personal Info Console App**

Ek console app banao jo:
- User ka naam, age, city, email, phone puche
- Input validate kare (age number ho, email mein @ ho)
- Saari info ek formatted table mein print kare
- File mein save kare (text file)
- Menu system ho (1: Add Info, 2: View, 3: Exit)

**Deliverable**: GitHub pe push karo, README.md likho, screenshots attach karo.

---

## 📘 Chapter 2: C# Syntax Basics (Week 2)

### Topic 2.1: Variables, Constants, Data Types

**Concepts:**
- Value types: `int`, `long`, `short`, `byte`, `float`, `double`, `decimal`, `bool`, `char`
- Reference types: `string`, `object`, arrays, classes
- `var` keyword (type inference)
- `const` vs `readonly`
- Nullable value types: `int?`, `bool?`
- Nullable reference types (C# 8+) — `string?` vs `string`
- `dynamic` keyword
- Default values (`default(T)`, `default`)
- Stack vs Heap memory

**Python vs C#:**
| Python | C# |
|--------|-----|
| `x = 5` | `int x = 5;` |
| `name = "Raj"` | `string name = "Raj";` |
| Dynamic typing | Static typing |

### 🎯 Practice Questions (Topic 2.1):
1. Har primitive data type ka ek variable banao aur print karo.
2. `int`, `long`, `double`, `decimal` ki max/min values print karo (`int.MaxValue`).
3. `const` aur `readonly` mein 3 differences likho with examples.
4. Nullable `int?` use karke "value exists or not" check karo.
5. `var` use karke 5 variables declare karo — compile-time type check karo.
6. `dynamic` variable banao aur runtime pe type change karke dekho.
7. Stack pe kaunsa data store hota hai, heap pe kaunsa? 5 examples do.
8. `decimal` aur `double` mein fark kya hai? Financial apps mein kaunsa use karoge?
9. `char` aur `string` mein fark batao.
10. Ek variable banao jiska value change na ho — 2 tarike se karo.

---

### Topic 2.2: Type Conversion aur Casting

**Concepts:**
- Implicit conversion (`int` → `long`)
- Explicit conversion / casting (`(int)doubleValue`)
- `Convert.ToInt32()`, `int.Parse()`, `int.TryParse()`
- Boxing aur Unboxing (performance impact!)
- `is` aur `as` operators
- Pattern matching with `is`

### 🎯 Practice Questions (Topic 2.2):
1. `"123"` string ko int mein convert karne ke 3 tarike batao.
2. `int.Parse()` aur `int.TryParse()` mein kab kaunsa use karoge?
3. Boxing kya hai? Ek example do with performance explanation.
4. `double` se `int` mein cast karne pe kya hota hai decimal ke saath?
5. `is` operator use karke object type check karo.
6. `as` operator kya karta hai agar cast fail ho?
7. Overflow exception kab aata hai? `checked` keyword kya karta hai?
8. User input (string) se integer banao with error handling.
9. `object` type mein `int` store karo aur wapas nikaalo — unboxing dikhao.
10. Pattern matching use karke multiple types check karo ek hi if-else mein.

---

### Topic 2.3: Operators

**Concepts:**
- Arithmetic: `+`, `-`, `*`, `/`, `%`
- Comparison: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Logical: `&&`, `||`, `!`
- Assignment: `=`, `+=`, `-=`, `*=`, `/=`
- Bitwise: `&`, `|`, `^`, `~`, `<<`, `>>`
- Null-conditional: `?.`, `?[]`
- Null-coalescing: `??`, `??=`
- **Null-conditional assignment (C# 14 new!)**: `customer?.Order = GetOrder();`
- **User-defined compound assignment (C# 14)**: Custom `+=` operators
- Ternary: `condition ? true : false`

### 🎯 Practice Questions (Topic 2.3):
1. Ek calculator function banao jo 2 numbers aur operator le.
2. `??` operator use karke default value assign karo null string ko.
3. `?.` use karke nested null object safely access karo.
4. Integer division ka result kya hota hai `7 / 2`? Decimal chahiye toh?
5. Modulo operator use karke even/odd check karo.
6. Bitwise AND aur OR ka practical example do.
7. `??=` operator use karke lazy initialization karo.
8. C# 14 ka null-conditional assignment use karke code likho.
9. Ternary operator ko nested banao (3 conditions).
10. Left shift `<<` se number multiply by 2 karke dikhao.

---

### Topic 2.4: Strings aur String Manipulation

**Concepts:**
- String immutability (strings change nahi hotey, new banta hai)
- String methods: `Length`, `ToUpper()`, `ToLower()`, `Trim()`, `Replace()`, `Split()`, `Substring()`, `Contains()`, `StartsWith()`, `EndsWith()`, `IndexOf()`
- String interpolation: `$"Hello {name}"`
- Verbatim strings: `@"C:\path\file"`
- Raw string literals (C# 11+): `"""multi-line"""`
- `StringBuilder` for performance (loops mein)
- `string.Format()`
- String comparison (`StringComparison.OrdinalIgnoreCase`)
- `Span<char>` for high performance (C# 14 first-class support)

### 🎯 Practice Questions (Topic 2.4):
1. Ek sentence ko words mein split karo aur reverse print karo.
2. Check karo ki string palindrome hai ya nahi.
3. String mein vowels count karo.
4. `StringBuilder` use karke 1000 strings concatenate karo — performance compare karo `+` se.
5. Raw string literal use karke JSON snippet likho.
6. String interpolation use karke formatted bill banao.
7. Case-insensitive string comparison karo.
8. Ek email string se username aur domain alag karo.
9. Number ko words mein convert karo (`123` → "One Two Three").
10. `Span<char>` use karke substring nikaalo (no allocation).

---

### Topic 2.5: Input/Output (Console Operations)

**Concepts:**
- `Console.WriteLine()`, `Console.Write()`
- `Console.ReadLine()`, `Console.ReadKey()`
- `Console.ForegroundColor`, `Console.BackgroundColor`
- Formatted output
- Reading numbers with validation

### 🎯 Practice Questions (Topic 2.5):
1. User se 5 numbers lo aur sum print karo.
2. Colored output (red for error, green for success).
3. Password input lo jismein * dikhe (no echo).
4. Ek menu-driven app banao with 5 options.
5. Input validation with retry (wrong input pe dobara puchho).
6. Console ko clear karo aur animation dikhao (loading spinner).
7. Current cursor position manipulate karo.
8. Exit confirmation ("Press Y to exit").
9. Progress bar banao console mein.
10. Multi-line input lo jab tak user `END` na type kare.

---

### 🏆 Chapter 2 Project: **Advanced Calculator App**

Features:
- Basic operations (+, -, *, /, %)
- Scientific operations (sqrt, power, factorial, log)
- Memory functions (M+, M-, MR, MC)
- History of last 10 calculations (save in file)
- Input validation aur error handling
- Colored UI in console
- Menu-driven

---

## 📘 Chapter 3: Control Flow (Week 3)

### Topic 3.1: Conditional Statements

**Concepts:**
- `if`, `else if`, `else`
- `switch` statement
- `switch` expression (C# 8+) — bahut powerful!
- Pattern matching (type patterns, property patterns, tuple patterns, relational patterns)
- `when` clause in switch

**Modern Syntax Example:**
```csharp
string grade = marks switch
{
    >= 90 => "A+",
    >= 80 => "A",
    >= 70 => "B",
    >= 60 => "C",
    _ => "F"
};
```

### 🎯 Practice Questions (Topic 3.1):
1. Grade calculator (marks lo, grade do) — if-else se.
2. Same program switch expression se likho.
3. Leap year check karo.
4. Calculator using switch statement (operator lo).
5. Number positive/negative/zero check karo.
6. Login system (username + password check) with nested if.
7. Pattern matching use karke shape ka area calculate karo (circle, rectangle, triangle).
8. Property pattern se object check karo.
9. Relational pattern (`< 10`, `>= 50 and < 100`) use karo.
10. Fizzbuzz problem solve karo 3 tarike se (if-else, switch, switch expression).

---

### Topic 3.2: Loops

**Concepts:**
- `for` loop
- `while` loop
- `do-while` loop
- `foreach` loop (collections ke liye)
- Nested loops
- Infinite loops (be careful!)

### 🎯 Practice Questions (Topic 3.2):
1. 1 se 100 tak sum print karo (for loop).
2. Factorial calculate karo (while loop).
3. Fibonacci series pehle 20 terms print karo.
4. Multiplication table print karo (user se number lo).
5. Pyramid pattern print karo (stars).
6. Inverted pyramid, diamond pattern.
7. Prime numbers print karo 1 to 100.
8. Reverse a number (123 → 321).
9. GCD aur LCM nikalo 2 numbers ka.
10. Array mein maximum aur minimum dhundo using loops.

---

### Topic 3.3: Jump Statements

**Concepts:**
- `break` — loop se bahar
- `continue` — next iteration pe
- `return` — function se bahar
- `goto` (avoid karo, but sikhlo)
- Labeled statements

### 🎯 Practice Questions (Topic 3.3):
1. Pehle 5 even numbers print karo using `continue`.
2. Loop ko break karo jab user "quit" type kare.
3. Nested loop break karo with labels.
4. Prime number check karo with early return.
5. Menu system jo `break` pe exit ho.
6. `goto` use karke state machine banao.
7. Loop mein odd numbers skip karo.
8. Sum calculate karo jab tak 0 na aaye.
9. Password retry 3 attempts ke baad break.
10. Matrix mein specific element milne pe both loops break.

---

### 🏆 Chapter 3 Project: **Number Guessing Game + Text Adventure Game**

**Game 1: Guessing Game**
- Computer randomly number choose kare (1-100)
- User guess kare, hints do (too high, too low)
- Maximum 10 attempts
- Difficulty levels (Easy: 1-50, Medium: 1-100, Hard: 1-1000)
- High score save karo file mein

**Game 2: Text Adventure**
- Ek simple story-based game
- User ke paas choices ho (1, 2, 3)
- Multiple endings based on choices
- HP system, inventory
- Pattern matching use karo switch expression se

---

## 📘 Chapter 4: Methods, Arrays aur Collections (Week 4)

### Topic 4.1: Methods/Functions

**Concepts:**
- Method declaration syntax
- Return types (void vs typed)
- Parameters (positional, named, optional)
- Method overloading
- `ref`, `out`, `in` parameters
- `params` keyword (variable arguments)
- Local functions (function inside function)
- Expression-bodied methods (`=>`)
- `static` methods
- Recursion

### 🎯 Practice Questions (Topic 4.1):
1. Ek method banao jo 2 numbers ka maximum return kare.
2. Swap function `ref` use karke.
3. `out` parameter use karke divide function (quotient + remainder).
4. `params` use karke N numbers ka sum.
5. Method overloading dikhao: `Add(int, int)`, `Add(double, double)`, `Add(string, string)`.
6. Recursive method factorial ke liye.
7. Fibonacci recursive vs iterative — performance compare karo.
8. Local function use karke complex calculation.
9. Expression-bodied method banao.
10. Named arguments use karke method call karo.

---

### Topic 4.2: Arrays

**Concepts:**
- 1D arrays (`int[] arr = new int[5]`)
- Array initialization
- 2D arrays (matrices)
- Jagged arrays (array of arrays)
- `Array.Sort()`, `Array.Reverse()`, `Array.IndexOf()`, `Array.Copy()`
- `Array.Find()`, `Array.ForEach()`
- Array vs List differences

### 🎯 Practice Questions (Topic 4.2):
1. 10 numbers store karo array mein aur sum/average nikalo.
2. Array ko reverse karo (bina built-in method ke).
3. Array ko sort karo Bubble Sort algorithm se.
4. 2D matrix (3x3) banao aur transpose print karo.
5. Jagged array banao jismein har row ki different length ho.
6. Array mein duplicate elements dhundo.
7. 2 arrays ko merge karo.
8. Array rotate karo by K positions.
9. Second largest element dhundo array mein.
10. Binary search implement karo (sorted array pe).

---

### Topic 4.3: Basic Collections (Intro - Deep dive Month 2 mein)

**Concepts:**
- `List<T>` — dynamic array
- `Dictionary<TKey, TValue>` — key-value pairs
- Adding, removing, iterating

### 🎯 Practice Questions (Topic 4.3):
1. `List<string>` banao aur names add/remove karo.
2. `Dictionary<string, int>` banao for student-marks.
3. List ko iterate karo `foreach` se.
4. List mein element exists check karo.
5. Dictionary mein TryGetValue use karo.
6. List ko sort karo.
7. List ko array mein convert karo.
8. Nested list banao (`List<List<int>>`).
9. Dictionary ko iterate karo (KeyValuePair).
10. Shopping cart banao with List<Product>.

---

### 🏆 Chapter 4 Project: **Student Grade Management System (Console)**

Features:
- Add student (name, roll, 5 subject marks)
- View all students (table format)
- Search by roll number / name
- Edit student details
- Delete student
- Sort by name / marks / roll
- Calculate total, percentage, grade
- Class topper find karo
- Subject-wise topper
- Export to CSV file
- Load from CSV file on startup

**Files to use**: `List<Student>` in memory, save to `students.csv`

---

# 🗓️ MONTH 2: OBJECT-ORIENTED PROGRAMMING (Weeks 5-8)

## 📘 Chapter 5: Classes aur Objects (Week 5)

### Topic 5.1: Class Basics

**Concepts:**
- Class declaration, object instantiation
- Fields (private data)
- Properties (getter/setter)
- Auto-implemented properties
- **C# 14's `field` keyword** (naya — backing field ka shortcut)
- Init-only properties (`init` accessor)
- Required members (`required` keyword)
- Methods in classes
- `this` keyword
- Access modifiers: `public`, `private`, `protected`, `internal`, `protected internal`, `private protected`, `file`

**C# 14 Example:**
```csharp
public class Customer
{
    // Old way — manual backing field
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException();
    }

    // C# 14 way — field keyword
    public string Name2
    {
        get => field;
        set => field = value ?? throw new ArgumentNullException();
    }
}
```

### 🎯 Practice Questions (Topic 5.1):
1. `Car` class banao with fields, properties, methods.
2. `BankAccount` class with Balance (private), Deposit/Withdraw methods.
3. Auto-property vs full property — dono use karo.
4. `init` only property banao (immutable after creation).
5. `required` keyword use karke mandatory property banao.
6. C# 14 ka `field` keyword use karke validation property banao.
7. Access modifiers har ek ka ek example do.
8. `Person` class banao with age validation (18+).
9. Ek class banao jismein sirf private methods ho.
10. `file` scoped class banao (C# 11+).

---

### Topic 5.2: Constructors

**Concepts:**
- Default constructor
- Parameterized constructor
- Constructor overloading
- `this()` to call other constructor
- Static constructor
- Primary constructors (C# 12+)
- **Partial constructors (C# 14 NEW!)**
- Object initializer syntax

**C# 12 Primary Constructor:**
```csharp
public class Student(string name, int age)
{
    public string Name => name;
    public int Age => age;
}
```

### 🎯 Practice Questions (Topic 5.2):
1. `Employee` class with 3 constructors (default, with name, with name+salary).
2. Primary constructor use karke `Point` class banao.
3. Static constructor dikhao — kab call hota hai?
4. `this()` use karke constructor chain banao.
5. Object initializer syntax use karke object create karo.
6. `readonly` field initialize karo constructor mein.
7. Partial constructor (C# 14) ka example likho.
8. Constructor mein exception throw karo invalid input ke liye.
9. Singleton pattern constructor ke saath implement karo.
10. Record type banao (alternative to class) — comparison karo.

---

### Topic 5.3: Static Members

**Concepts:**
- Static fields, properties, methods
- Static classes
- `const` vs `static readonly`
- Static constructor execution order
- Utility/Helper classes

### 🎯 Practice Questions (Topic 5.3):
1. `MathHelper` static class banao with Add, Subtract, Multiply, Divide.
2. Static counter banao jo track kare kitne objects banne.
3. `const` vs `static readonly` ka difference code mein dikhao.
4. Static constructor kab call hota hai? Test karo.
5. Extension method banao string ke liye (static class).
6. Utility class banao for date formatting.
7. Static factory method implement karo.
8. Logger static class (simple).
9. Configuration static class banao app settings ke liye.
10. Thread-safety of static — kya static thread-safe hota hai?

---

### 🏆 Chapter 5 Project: **Library Management System v1**

Classes to build:
- `Book` (Id, Title, Author, ISBN, IsAvailable)
- `Member` (Id, Name, BorrowedBooks list)
- `Library` (Books list, Members list, methods for operations)

Features:
- Add/Remove books
- Register members
- Issue book to member
- Return book
- Search book by title/author
- View borrowed books of a member
- Static book ID generator
- Save/Load from JSON file

---

## 📘 Chapter 6: OOP Ke 4 Pillars (Week 6)

### Topic 6.1: Encapsulation

**Concepts:**
- Data hiding
- Private fields + Public properties
- Validation in setters
- Read-only properties
- Why encapsulation matters in enterprise code

### 🎯 Practice Questions (Topic 6.1):
1. `Temperature` class jismein Celsius set karne se Fahrenheit auto-calculate ho.
2. `Password` class with strength validation in setter.
3. Age property jo negative values reject kare.
4. `Email` class with format validation.
5. Read-only property from computed values.
6. Encapsulation violate karke dikhao — phir fix karo.
7. Bank account balance directly modify nahi ho sake.
8. Phone number normalize karo setter mein.
9. String length validation (max 50 chars).
10. Enum-based Status property.

---

### Topic 6.2: Inheritance

**Concepts:**
- Base class aur derived class
- `: BaseClass` syntax
- Constructor chaining with `base()`
- `sealed` keyword (class extend nahi ho sakti)
- Method hiding (`new` keyword)
- `protected` access
- Single inheritance (C# mein multiple inheritance nahi hai classes ke liye)
- `object` — root of all classes

### 🎯 Practice Questions (Topic 6.2):
1. `Animal` base class, `Dog`, `Cat`, `Cow` derived classes.
2. `Vehicle` → `Car`, `Bike`, `Truck` hierarchy banao.
3. Constructor chaining dikhao `base()` se.
4. `sealed` class banao — uska test case likho ki extend nahi ho rahi.
5. Method hiding vs overriding ka difference.
6. `protected` member access karo derived class mein.
7. Multi-level inheritance (A → B → C).
8. `object` class ke methods override karo (ToString, Equals, GetHashCode).
9. Casting base to derived (downcasting).
10. `is` aur `as` use karke safe casting.

---

### Topic 6.3: Polymorphism

**Concepts:**
- `virtual` methods in base class
- `override` in derived class
- `abstract` methods
- Runtime polymorphism
- Compile-time polymorphism (overloading)
- `base.MethodName()` to call parent
- Covariance aur contravariance intro

### 🎯 Practice Questions (Topic 6.3):
1. `Shape` base class with virtual `Area()`, derived `Circle`, `Square`, `Triangle`.
2. `Employee` → `Manager`, `Developer` with `CalculateSalary()` overridden.
3. Compile-time polymorphism (overloading) 5 examples.
4. Runtime polymorphism example with virtual method.
5. `base.Method()` use karke parent ka code chalao.
6. List of base class containing derived objects (polymorphic list).
7. Virtual property override karo.
8. Abstract method vs virtual method difference.
9. Method hiding vs overriding — which one when.
10. Banking app: different account types with different interest rates.

---

### Topic 6.4: Abstraction

**Concepts:**
- `abstract` classes (instance nahi bana sakte)
- Abstract methods (no body, must override)
- Mix of abstract + concrete methods
- When to use abstract class
- Abstract class vs interface

### 🎯 Practice Questions (Topic 6.4):
1. `Shape` abstract class with abstract `Area()` aur concrete `Describe()`.
2. `Employee` abstract class with abstract `CalculateSalary()`.
3. Abstract class ko instantiate karne ki koshish karo — error kya aata hai?
4. Template method pattern implement karo abstract class se.
5. `DatabaseConnection` abstract class, derived `SqlConnection`, `MongoConnection`.
6. Payment processor abstract class with different payment methods.
7. Abstract class mein constructor kyun hota hai?
8. Abstract property banao.
9. Partial implementation — kuch methods abstract, kuch concrete.
10. Real-world example: `Vehicle` with abstract `Start()` method.

---

### 🏆 Chapter 6 Project: **Banking System with Multiple Account Types**

Hierarchy:
```
Account (abstract)
├── SavingsAccount (interest-based)
├── CurrentAccount (overdraft allowed)
├── FixedDepositAccount (locked period)
└── LoanAccount (EMI based)
```

Features:
- Deposit, Withdraw (virtual methods with different rules per type)
- Interest calculation (abstract, each type implements)
- Transaction history
- Monthly statement generation
- Overdraft limit (only CurrentAccount)
- Maturity calculation (FixedDeposit)
- EMI calculation (Loan)
- Polymorphic list of accounts
- Bank class manages all accounts

---

## 📘 Chapter 7: Interfaces, Generics aur Advanced OOP (Week 7)

### Topic 7.1: Interfaces

**Concepts:**
- Interface declaration (`interface IRepository`)
- Implementing interfaces (`: IRepository`)
- Multiple interface implementation
- Default interface methods (C# 8+)
- Explicit interface implementation
- Interface segregation
- `I` prefix convention
- **Extension members (C# 14 NEW!)** — extension properties, static members

**C# 14 Extension Members:**
```csharp
public static class StringExtensions
{
    // C# 14 - Extension block syntax
    extension(string value)
    {
        public bool IsEmpty => string.IsNullOrEmpty(value);

        public string Truncate(int max) =>
            value.Length <= max ? value : value[..max];
    }
}
```

### 🎯 Practice Questions (Topic 7.1):
1. `IPlayable` interface with Play, Pause, Stop — implement in `MusicPlayer`, `VideoPlayer`.
2. Multiple interface implementation (`IReadable`, `IWritable`).
3. Default interface method (C# 8+) ka example.
4. Explicit interface implementation — kab use karoge?
5. `IComparable<T>` implement karo custom class ke liye.
6. `IDisposable` implement karo resource cleanup ke liye.
7. Interface vs abstract class — 5 differences.
8. Extension method (old style) banao `int` type ke liye.
9. C# 14 ka extension member syntax use karo.
10. `IEnumerable<T>` custom class mein implement karo.

---

### Topic 7.2: Generics

**Concepts:**
- Generic classes (`List<T>`, custom)
- Generic methods
- Type constraints (`where T : class`, `where T : struct`, `where T : new()`, `where T : IComparable`)
- Multiple type parameters (`Dictionary<TKey, TValue>`)
- Generic interfaces
- Covariance (`out T`) aur Contravariance (`in T`)
- Why generics? (Type safety + no boxing)

### 🎯 Practice Questions (Topic 7.2):
1. Generic `Stack<T>` class banao (push, pop, peek).
2. Generic method `Swap<T>(ref T a, ref T b)`.
3. Generic `Repository<T>` class.
4. Type constraint use karke `Max<T>` method (IComparable).
5. Multiple constraints dikhao.
6. Generic interface `IRepository<T>`.
7. Covariance example with `IEnumerable<out T>`.
8. Generic class with 2 type parameters (`Pair<T, U>`).
9. Generic method jo constraint par specific operation kare.
10. Performance: Generic `List<int>` vs `ArrayList` boxing.

---

### Topic 7.3: Sealed, Partial, Nested Classes

**Concepts:**
- `sealed` classes (no inheritance)
- `partial` classes (split across files)
- Nested classes
- `partial` methods, events, constructors (C# 14!)
- `static` classes revisited
- Readonly structs

### 🎯 Practice Questions (Topic 7.3):
1. Sealed class banao aur inherit karne ki koshish karo.
2. Partial class 2 files mein split karo.
3. Nested class banao — private helper ke liye.
4. Partial method ka example (C# 9+).
5. C# 14 partial constructor ka example likho.
6. C# 14 partial event example.
7. Readonly struct banao — benefit kya hai?
8. Static nested class vs non-static nested class.
9. Builder pattern with nested class.
10. Immutable class design principles apply karo.

---

### 🏆 Chapter 7 Project: **Generic Data Access Layer (Repository Pattern)**

Build karo:
- `IRepository<T>` interface (GetAll, GetById, Add, Update, Delete)
- `GenericRepository<T>` class (in-memory implementation)
- Domain entities: `Product`, `Customer`, `Order`
- `IEntity` interface with Id property
- Constraint: `where T : class, IEntity, new()`
- LINQ-like filtering (`Find(predicate)`)
- Unit of Work pattern intro
- Save/Load JSON

---

## 📘 Chapter 8: Collections, LINQ aur Exception Handling (Week 8)

### Topic 8.1: Collections Deep Dive

**Concepts:**
- `List<T>` — dynamic array
- `LinkedList<T>` — doubly linked list
- `Dictionary<TKey, TValue>` — hash table
- `HashSet<T>` — unique elements
- `SortedSet<T>`, `SortedDictionary<T>`, `SortedList<T>`
- `Queue<T>` — FIFO
- `Stack<T>` — LIFO
- `PriorityQueue<T, TPriority>` (.NET 6+)
- Concurrent collections (`ConcurrentDictionary`, etc.)
- `IEnumerable<T>`, `ICollection<T>`, `IList<T>` hierarchy
- Immutable collections

### 🎯 Practice Questions (Topic 8.1):
1. Sabhi collection types use karke ek example likho.
2. `HashSet<T>` use karke duplicates remove karo list se.
3. `Dictionary` vs `SortedDictionary` performance.
4. Queue use karke task scheduler banao.
5. Stack use karke balanced brackets check karo.
6. `PriorityQueue` use karke job scheduler.
7. LinkedList ka practical use case.
8. `ConcurrentDictionary` use karke thread-safe counter.
9. Custom collection banao `IEnumerable<T>` implement karke.
10. ImmutableList vs List difference.

---

### Topic 8.2: LINQ (Language Integrated Query)

**Concepts:**
- Query syntax vs Method syntax
- Filtering: `Where`
- Projection: `Select`, `SelectMany`
- Sorting: `OrderBy`, `OrderByDescending`, `ThenBy`
- Grouping: `GroupBy`
- Joining: `Join`, `GroupJoin`
- Aggregation: `Sum`, `Count`, `Average`, `Min`, `Max`
- Partitioning: `Take`, `Skip`, `TakeWhile`, `SkipWhile`
- Set operations: `Union`, `Intersect`, `Except`, `Distinct`
- Quantifiers: `Any`, `All`, `Contains`
- Elements: `First`, `FirstOrDefault`, `Single`, `SingleOrDefault`, `ElementAt`
- `ToList`, `ToArray`, `ToDictionary`, `ToHashSet`
- Deferred execution vs Immediate execution

### 🎯 Practice Questions (Topic 8.2):
1. List of numbers se sirf even nikalo (Where).
2. List of Students se names ki list banao (Select).
3. Marks ke according sort karo descending.
4. Students ko grade ke basis pe group karo.
5. Top 3 students nikalo by marks.
6. Average marks nikalo.
7. Multiple lists join karo (Students + Departments).
8. Nested collection flatten karo SelectMany se.
9. Deferred execution demonstrate karo.
10. Query syntax aur method syntax dono mein same query likho.

---

### Topic 8.3: Exception Handling

**Concepts:**
- `try-catch-finally`
- Multiple catch blocks
- Exception hierarchy (`Exception`, `SystemException`, custom)
- Throwing exceptions (`throw new`)
- Rethrowing (`throw` vs `throw ex`)
- Exception filters (`when` clause)
- `using` statement (auto dispose)
- `using` declaration (C# 8+)
- Custom exceptions
- Inner exceptions
- Best practices (don't catch general Exception)

### 🎯 Practice Questions (Topic 8.3):
1. Divide function with DivideByZeroException handling.
2. Custom exception `InvalidAgeException` banao.
3. Multiple catch blocks with specificity order.
4. Exception filter `when` use karo.
5. Inner exception example (wrap karo aur unwrap karo).
6. `using` statement with FileStream.
7. `try-finally` without catch — kab use hoga?
8. Rethrow exception properly (stack trace preserve karo).
9. AggregateException handle karo (Task se).
10. Try-pattern method banao (`TryParse` style).

---

### 🏆 Chapter 8 Project: **Employee Management System with LINQ**

Features:
- 100+ employees data (use JSON or hardcoded)
- Classes: `Employee`, `Department`, `Project`
- LINQ queries for:
  - Top 10 highest paid employees
  - Department-wise average salary
  - Employees with no project assigned
  - Youngest / Oldest employee per department
  - Name starts with specific letter
  - Hired in last 5 years
  - Group by designation, count each
  - Total payroll per department
  - Employees working on multiple projects
  - Cross-department collaboration count
- Export results to CSV
- All with proper exception handling

---

# 🗓️ MONTH 3: ADVANCED C# (Weeks 9-12)

## 📘 Chapter 9: Delegates, Events aur Lambda (Week 9)

### Topic 9.1: Delegates

**Concepts:**
- Delegate basics (type-safe function pointers)
- Custom delegates (`delegate int MathOp(int a, int b)`)
- Built-in: `Action<>`, `Func<>`, `Predicate<>`
- Multicast delegates (`+=`, `-=`)
- Delegate invocation
- Delegates vs interfaces — kab kaunsa

### 🎯 Practice Questions (Topic 9.1):
1. Custom delegate banao aur 3 methods bind karo.
2. `Func<int, int, int>` se calculator.
3. `Action<string>` se logger.
4. `Predicate<int>` se filtering.
5. Multicast delegate example.
6. Delegate ko method parameter ke tarah pass karo.
7. Sort with custom comparator using delegate.
8. Delegate se callback mechanism banao.
9. Anonymous method vs lambda.
10. Delegate vs interface comparison.

---

### Topic 9.2: Events

**Concepts:**
- Event declaration (`event EventHandler`)
- Publisher-Subscriber pattern
- `EventHandler`, `EventHandler<T>`
- Raising events (`?.Invoke()`)
- Event accessors (`add`, `remove`)
- Partial events (C# 14!)
- Weak event patterns

### 🎯 Practice Questions (Topic 9.2):
1. Button class with Click event.
2. Observer pattern with events.
3. Custom EventArgs banao.
4. Multiple subscribers example.
5. Unsubscribe karke memory leak prevent karo.
6. C# 14 partial event example.
7. Async event handler.
8. Event vs delegate — difference.
9. Thread-safe event raising.
10. Real-time notification system (stock prices).

---

### Topic 9.3: Lambda Expressions

**Concepts:**
- Lambda syntax (`x => x * 2`)
- Single vs multi-statement lambda
- Capturing variables (closures)
- Lambda in LINQ
- Expression trees intro
- **C# 14**: Lambda parameter modifiers without type (`ref`, `in`, `out`)

**C# 14 Example:**
```csharp
// Earlier: (ref int x) => x++
// C# 14 allows: delegate void Handler(ref int x);
// Handler h = (ref x) => x++;  // Type inferred!
```

### 🎯 Practice Questions (Topic 9.3):
1. Sort list using lambda.
2. Filter using lambda predicate.
3. Closure example — outer variable capture.
4. Expression tree vs Func.
5. Lambda with multiple parameters.
6. Multi-statement lambda with return.
7. Lambda as Func/Action/Predicate.
8. C# 14 lambda with ref parameter.
9. Chain lambdas (function composition).
10. Lambda in LINQ select/where/orderby.

---

### 🏆 Chapter 9 Project: **Event-Driven Stock Market Simulator**

Features:
- `Stock` class with Price (triggers PriceChanged event)
- `Investor` subscribes to stocks
- Price alerts (above/below threshold)
- Custom EventArgs with old price, new price, timestamp
- Multiple observers (console logger, file logger, email notifier)
- Delegate-based filtering
- Transaction history with lambda queries
- Portfolio value calculation

---

## 📘 Chapter 10: Async Programming (Week 10)

### Topic 10.1: Threading Basics

**Concepts:**
- Thread class
- Thread states
- Thread synchronization (lock, Monitor)
- Race conditions
- Deadlocks
- ThreadPool
- `Interlocked` class

### 🎯 Practice Questions (Topic 10.1):
1. 5 threads create karo aur run karo.
2. Shared counter with race condition — reproduce karo.
3. `lock` keyword use karke fix karo.
4. Monitor class use karo.
5. Deadlock scenario banao aur dikhao.
6. ThreadPool se work queue karo.
7. Interlocked.Increment use karke atomic counter.
8. Thread priority set karo.
9. Thread join ka use.
10. Producer-consumer pattern.

---

### Topic 10.2: Task Parallel Library (TPL)

**Concepts:**
- `Task` vs `Thread`
- `Task.Run()`
- `Task<T>` with return value
- `Task.WhenAll`, `Task.WhenAny`
- `Task.Delay`
- Task continuation (`ContinueWith`)
- Cancellation (`CancellationToken`)
- `Parallel.For`, `Parallel.ForEach`
- PLINQ (Parallel LINQ)

### 🎯 Practice Questions (Topic 10.2):
1. 10 tasks parallel mein run karo.
2. Task<int> se calculation.
3. WhenAll se multiple tasks wait karo.
4. WhenAny — first completed wala.
5. CancellationToken use karo task cancel karne ke liye.
6. Parallel.For se loop speed up karo.
7. PLINQ use karke large dataset filter.
8. Task continuation chain banao.
9. Progress reporting (IProgress<T>).
10. CPU-bound vs IO-bound — kab kya use karoge.

---

### Topic 10.3: async/await

**Concepts:**
- `async` method signature
- `await` keyword
- `Task` return type
- `async void` — sirf event handlers ke liye
- `ConfigureAwait(false)`
- Exception handling in async
- Async streams (`IAsyncEnumerable<T>`)
- `await foreach`
- Async disposable (`IAsyncDisposable`)
- Deadlocks in async (sync-over-async — avoid!)

### 🎯 Practice Questions (Topic 10.3):
1. HTTP request async mein download karo.
2. Multiple API calls parallel mein await karo.
3. Async file read/write.
4. Async exception handling.
5. ConfigureAwait(false) ka use.
6. `IAsyncEnumerable<T>` se streaming data.
7. `await using` statement.
8. Deadlock example (blocking async) — avoid karo.
9. Async LINQ (ToListAsync style).
10. Timeout implement karo using CancellationTokenSource.

---

### 🏆 Chapter 10 Project: **Multi-threaded Web Scraper / Downloader**

Features:
- Multiple URLs se data download karo parallel mein
- Progress bar for each download
- Cancellation support
- Rate limiting (max 5 concurrent)
- Retry logic on failure
- Async file save (JSON/HTML)
- Report generation (success/failure count)
- Use `HttpClient` with `async/await`
- Use `Channel<T>` or `ConcurrentQueue<T>` for queue
- `IAsyncEnumerable<T>` for streaming results

---

## 📘 Chapter 11: File I/O aur Serialization (Week 11)

### Topic 11.1: File & Directory Operations

**Concepts:**
- `File`, `FileInfo` class
- `Directory`, `DirectoryInfo`
- Reading/Writing text files
- Binary files
- `StreamReader`, `StreamWriter`
- `FileStream`
- Memory-mapped files
- Path operations (`Path.Combine`, `Path.GetExtension`)
- File watching (`FileSystemWatcher`)

### 🎯 Practice Questions (Topic 11.1):
1. Text file read karo line-by-line.
2. Large file async read karo.
3. Directory mein sabhi .txt files list karo.
4. Recursive file search (by name pattern).
5. File copy with progress.
6. FileSystemWatcher use karke folder monitor karo.
7. Path manipulation (combine, GetFileNameWithoutExtension).
8. Binary file read/write.
9. File size calculation for folder.
10. Compare two files contents.

---

### Topic 11.2: Serialization

**Concepts:**
- JSON serialization (`System.Text.Json`)
- `JsonSerializer.Serialize/Deserialize`
- Attributes: `[JsonPropertyName]`, `[JsonIgnore]`
- JsonSerializerOptions (camelCase, indent, etc.)
- Custom converters
- XML serialization
- Binary serialization (not recommended for new code)
- CSV parsing/writing
- Newtonsoft.Json vs System.Text.Json

### 🎯 Practice Questions (Topic 11.2):
1. Object ko JSON mein serialize karo.
2. JSON se object deserialize karo.
3. List<Product> ko JSON file mein save.
4. Indented JSON output.
5. Custom property names with attribute.
6. JsonIgnore use karke sensitive data hide karo.
7. DateTime custom format.
8. Polymorphic deserialization.
9. CSV file parse karke List mein load.
10. XML serialization example.

---

### 🏆 Chapter 11 Project: **Personal Finance Tracker (File-Based)**

Features:
- Income/Expense entries add karo
- Categories (Food, Transport, Bills, etc.)
- JSON file mein persistent storage
- Monthly/Yearly reports (LINQ queries)
- Export to CSV
- Import from CSV
- Backup/Restore
- Data visualization (ASCII chart in console)
- Search aur filter
- Budget alerts (threshold cross pe)
- Async file operations

---

## 📘 Chapter 12: Modern C# Features (Week 12)

### Topic 12.1: Records aur Value Types

**Concepts:**
- `record` types (C# 9+)
- `record struct` (C# 10+)
- Value-based equality
- `with` expressions (non-destructive mutation)
- Positional records
- Immutability by default
- Deconstruction

**Example:**
```csharp
public record Person(string Name, int Age);
var p1 = new Person("Raj", 25);
var p2 = p1 with { Age = 26 };  // new record
Console.WriteLine(p1 == p2);  // False (value equality)
```

### 🎯 Practice Questions (Topic 12.1):
1. Record type `Person` banao aur equality test karo.
2. `with` expression use karke modified copy.
3. Record struct vs record class difference.
4. Deconstruction use karo.
5. Record inheritance.
6. Init-only records with validation.
7. Record vs class equality behaviour.
8. Nested records.
9. Record with computed property.
10. JSON serialization with records.

---

### Topic 12.2: Pattern Matching (Advanced)

**Concepts:**
- Type patterns
- Property patterns
- Tuple patterns
- Relational patterns (`> 10`, `<= 100`)
- Logical patterns (`and`, `or`, `not`)
- List patterns (C# 11+)
- Extended property patterns

### 🎯 Practice Questions (Topic 12.2):
1. Switch expression with all pattern types.
2. Property pattern — deep nested object.
3. Tuple pattern for coordinate classification.
4. Relational + logical pattern combo.
5. List pattern — first and last element.
6. Pattern in if-statement.
7. Discard pattern (`_`).
8. Positional pattern with records.
9. Is-expression with pattern.
10. Complex matching: order status state machine.

---

### Topic 12.3: Nullable Reference Types

**Concepts:**
- `#nullable enable`
- `string` vs `string?`
- Null-forgiving operator (`!`)
- Null-conditional (`?.`)
- Null-coalescing (`??`)
- **Null-conditional assignment (C# 14 NEW!)**
- `ArgumentNullException.ThrowIfNull()`
- Best practices

### 🎯 Practice Questions (Topic 12.3):
1. Project mein nullable enable karo aur warnings fix karo.
2. Nullable parameters handle karo.
3. Null-forgiving operator ka use (aur abuse).
4. Method return nullable ya non-nullable — kab kya.
5. C# 14 null-conditional assignment use karo.
6. `ArgumentNullException.ThrowIfNull()` use karo.
7. Collection of nullable vs nullable collection (`List<string?>` vs `List<string>?`).
8. Null safety in async methods.
9. Defensive coding patterns.
10. Migrate non-nullable project to nullable.

---

### Topic 12.4: Other Modern Features

**Concepts:**
- Global usings (`global using System;`)
- File-scoped namespaces (`namespace MyApp;`)
- Top-level statements
- Target-typed `new()` (`List<Product> list = new();`)
- Collection expressions (`int[] arr = [1, 2, 3];`)
- Primary constructors (classes, structs)
- **Required members (`required` keyword)**
- UTF-8 string literals (`"abc"u8`)
- Raw string literals
- **C# 14 `field` keyword** in properties
- **C# 14 `nameof` with unbound generics**: `nameof(List<>)`
- **C# 14 Extension members**

### 🎯 Practice Questions (Topic 12.4):
1. Global usings file banao.
2. File-scoped namespace use karo saare files mein.
3. Top-level statements program.
4. Target-typed new() 5 jagah use karo.
5. Collection expression use karo.
6. Required member with validation.
7. UTF-8 string literal for performance.
8. Raw string literal for SQL query.
9. C# 14 field keyword with property.
10. C# 14 extension member (property) banao.

---

### 🏆 Chapter 12 Project: **Functional-Style Task Manager**

Features:
- All tasks as `record` types (immutable)
- Pattern matching for task filtering
- `with` expressions for updates
- Nullable reference types strictly enabled
- Functional operations (map, filter, reduce style)
- C# 14 extension members for task operations
- Collection expressions throughout
- Pure functions where possible
- JSON persistence
- Time tracking
- Priority system (enum + pattern matching)
- Statistics dashboard

---

# 🗓️ MONTH 4: ASP.NET CORE WEB API (Weeks 13-16)

## 📘 Chapter 13: ASP.NET Core Fundamentals (Week 13)

### Topic 13.1: Web Basics Refresh

**Concepts:**
- HTTP protocol (GET, POST, PUT, DELETE, PATCH)
- Status codes (2xx, 4xx, 5xx)
- Request/Response headers
- Content types (JSON, XML, multipart)
- REST principles (stateless, resource-based, uniform interface)
- URL structure (routing)
- API design best practices

### 🎯 Practice Questions (Topic 13.1):
1. HTTP methods aur unka purpose — table banao.
2. REST ke 6 constraints kya hain.
3. 10 status codes with examples.
4. Idempotent methods kaunse? Kyun?
5. URL design for blog API (posts, comments, users).
6. Query params vs path params vs body — kab kya.
7. REST vs RPC difference.
8. Content negotiation kya hai?
9. CORS kya hai, kyun problem banta hai?
10. Request/Response cycle flowchart.

---

### Topic 13.2: ASP.NET Core Project Structure

**Concepts:**
- `dotnet new webapi` template
- `Program.cs` — minimal hosting model
- `WebApplication.CreateBuilder()`
- Service registration
- Middleware pipeline (`app.Use...`)
- `appsettings.json` configuration
- `launchSettings.json`
- Environment (Development, Staging, Production)
- Minimal APIs vs Controllers
- .NET 10 ASP.NET Core new features (SSE, OpenAPI 3.1, JSON Patch in Minimal APIs)

### 🎯 Practice Questions (Topic 13.2):
1. Pehla Web API project banao.
2. Program.cs ka har line explain karo.
3. 3 environments ke liye alag config banao.
4. Launch profiles customize karo.
5. Minimal API vs Controller — side-by-side compare.
6. Appsettings se custom value padho.
7. Development-only middleware add karo.
8. Kestrel vs IIS difference.
9. HTTPS redirect middleware.
10. Static files serve karo.

---

### Topic 13.3: Controllers aur Routing

**Concepts:**
- `ControllerBase` vs `Controller`
- `[ApiController]` attribute
- Attribute routing (`[Route("api/[controller]")]`)
- HTTP verb attributes (`[HttpGet]`, `[HttpPost]`)
- Route parameters (`/products/{id}`)
- Query string parameters (`?page=1`)
- Action return types (`IActionResult`, `ActionResult<T>`)
- Result helpers (`Ok()`, `NotFound()`, `BadRequest()`, `Created()`)
- Model binding
- Model validation with attributes

### 🎯 Practice Questions (Topic 13.3):
1. `ProductsController` with 5 endpoints (CRUD).
2. Route parameters with constraints.
3. Query parameters for filtering.
4. Return ActionResult<T> with proper status codes.
5. Model binding from body, query, route.
6. `[FromBody]`, `[FromQuery]`, `[FromRoute]` explicit binding.
7. Complex object as query parameter.
8. File upload endpoint.
9. Multiple response types (`[ProducesResponseType]`).
10. Versioned route (`api/v1/products`).

---

### 🏆 Chapter 13 Project: **Todo API (Basic CRUD)**

Endpoints:
- `GET /api/todos` — all todos with filtering/pagination
- `GET /api/todos/{id}` — single todo
- `POST /api/todos` — create
- `PUT /api/todos/{id}` — full update
- `PATCH /api/todos/{id}` — partial update (status change)
- `DELETE /api/todos/{id}` — delete
- `GET /api/todos/stats` — count by status

Requirements:
- In-memory storage (List<Todo>)
- Swagger/OpenAPI documentation
- Model validation
- Proper HTTP status codes
- Error handling
- Query filtering (status, priority, date range)
- Pagination (page, pageSize)
- Sorting
- Postman collection banao test ke liye

---

## 📘 Chapter 14: Middleware, DI aur Configuration (Week 14)

### Topic 14.1: Middleware Pipeline

**Concepts:**
- Request pipeline concept
- Built-in middleware (Authentication, Authorization, CORS, Static files, Routing, Exception)
- Middleware order matters!
- `app.Use()`, `app.Run()`, `app.Map()`
- Custom middleware (class-based aur inline)
- Short-circuiting
- `IMiddleware` interface

### 🎯 Practice Questions (Topic 14.1):
1. 5 default middlewares ka order batao.
2. Custom middleware inline banao (request time log).
3. Class-based middleware implement karo.
4. `IMiddleware` interface se middleware.
5. Middleware short-circuit example.
6. `app.Map()` branch different pipeline.
7. Request header check middleware.
8. Response header add karne wala middleware.
9. Rate limiting middleware (simple).
10. Exception handling middleware banao.

---

### Topic 14.2: Dependency Injection

**Concepts:**
- Why DI? (Loose coupling, testability)
- Service lifetimes: `Transient`, `Scoped`, `Singleton`
- `builder.Services.AddTransient<T>()`, `AddScoped<T>()`, `AddSingleton<T>()`
- Constructor injection
- Method injection (`[FromServices]`)
- `IServiceProvider` (avoid service locator antipattern)
- DI in middleware, filters, controllers
- Scoped lifetime in singleton — BIG ISSUE!
- Keyed services (.NET 8+)
- `TryAddTransient`, `TryAddScoped` (conditional registration)

### 🎯 Practice Questions (Topic 14.2):
1. Interface + implementation register karo 3 lifetimes se.
2. Scoped vs Transient vs Singleton — test karo kab naya instance banta.
3. Constructor injection with multiple dependencies.
4. DI in minimal API handler.
5. `[FromServices]` parameter attribute use karo.
6. Service resolution via IServiceProvider (but avoid it).
7. Conditional registration based on environment.
8. Keyed services (.NET 8+) example.
9. Factory pattern with DI.
10. Scoped leak into singleton — problem dikhao aur fix karo.

---

### Topic 14.3: Configuration aur Options Pattern

**Concepts:**
- `IConfiguration` interface
- Configuration sources (appsettings.json, environment variables, command line, secrets)
- Hierarchical configuration
- User secrets (for dev)
- Options pattern (`IOptions<T>`, `IOptionsSnapshot<T>`, `IOptionsMonitor<T>`)
- Strongly-typed config classes
- Validation of options (`ValidateDataAnnotations`, `ValidateOnStart`)

### 🎯 Practice Questions (Topic 14.3):
1. Custom section appsettings mein banao aur read karo.
2. Options pattern se typed config access.
3. `IOptionsMonitor` se runtime changes detect karo.
4. Environment-specific config override.
5. User secrets setup karo dev mein.
6. Environment variable override.
7. Config validation attribute se.
8. `ValidateOnStart()` use karo.
9. Nested configuration object.
10. Config reload on file change.

---

### Topic 14.4: Logging

**Concepts:**
- Built-in `ILogger<T>`
- Log levels (Trace, Debug, Information, Warning, Error, Critical)
- Structured logging
- Log scopes
- Third-party: Serilog, NLog
- Log filters
- Log providers (Console, Debug, EventSource, File)

### 🎯 Practice Questions (Topic 14.4):
1. Controller mein ILogger inject karo.
2. 6 log levels ke messages likho.
3. Structured logging (`LogInformation("User {UserId} logged in", userId)`).
4. Log scope use karo (request scope).
5. Serilog setup karo with file sink.
6. Log filter configure karo.
7. JSON structured logging.
8. Exception logging properly.
9. Custom log provider banao.
10. Request/Response logging middleware.

---

### 🏆 Chapter 14 Project: **Blog API with Middleware & DI**

Features:
- Blog posts CRUD
- Services: `IPostService`, `ICategoryService`, `ITagService`
- DI setup for all services
- Custom middleware:
  - Request timing (logs duration)
  - API key validation
  - Request ID tracker
  - Global exception handler
- Logging: Serilog to console + file
- Configuration:
  - Pagination settings
  - Max file upload size
  - API key
  - Database connection (dummy for now)
- Swagger with multiple environments
- Health check endpoint

---

## 📘 Chapter 15: Advanced Web API Features (Week 15)

### Topic 15.1: Validation

**Concepts:**
- Data Annotations (`[Required]`, `[StringLength]`, `[Range]`, `[RegularExpression]`, `[EmailAddress]`)
- Custom validation attributes
- `ModelState.IsValid`
- Automatic model validation (`[ApiController]`)
- FluentValidation library
- Async validators
- Complex validation rules

### 🎯 Practice Questions (Topic 15.1):
1. User registration DTO with all common validations.
2. Custom validation attribute (e.g., Indian phone number).
3. Cross-property validation (`IValidatableObject`).
4. FluentValidation setup aur rules.
5. Async validator (DB check).
6. Conditional validation.
7. Validation error response format customize karo.
8. Nested object validation.
9. List validation (each item).
10. Localized error messages.

---

### Topic 15.2: Filters

**Concepts:**
- Filter pipeline (Authorization → Resource → Action → Exception → Result)
- Action filters (before/after action)
- Exception filters
- Authorization filters
- Resource filters (caching)
- Result filters
- Global vs Controller vs Action level
- Async filters

### 🎯 Practice Questions (Topic 15.2):
1. Global exception filter banao.
2. Action filter to log action timing.
3. Authorization filter custom.
4. Resource filter for caching.
5. Result filter to wrap response.
6. Async action filter.
7. Filter dependency injection.
8. Order of filter execution demonstrate karo.
9. Conditional filter application.
10. Filter vs Middleware — kab kya.

---

### Topic 15.3: Global Exception Handling

**Concepts:**
- `IExceptionHandler` interface (.NET 8+)
- `UseExceptionHandler` middleware
- ProblemDetails (RFC 7807)
- `IProblemDetailsService`
- Custom exception types
- Different responses for different exceptions

### 🎯 Practice Questions (Topic 15.3):
1. `IExceptionHandler` implement karo.
2. Custom `NotFoundException`, `ValidationException`, `BusinessException`.
3. ProblemDetails customize karo.
4. Different status codes for different exceptions.
5. Log exceptions with context.
6. Exception handler middleware.
7. Hide stack trace in production.
8. Include trace ID in error response.
9. Validation errors as ProblemDetails.
10. Async exception handling.

---

### Topic 15.4: API Versioning, Swagger, CORS

**Concepts:**
- API versioning strategies (URL, header, query, media type)
- `Microsoft.AspNetCore.Mvc.Versioning` package
- Swagger/OpenAPI setup (Swashbuckle)
- **.NET 10 OpenAPI 3.1 support**
- XML comments in Swagger
- Swagger grouping, authentication
- CORS configuration

### 🎯 Practice Questions (Topic 15.4):
1. URL-based versioning setup.
2. Header-based versioning.
3. Swagger customize karo (title, description, version).
4. XML comments Swagger mein include karo.
5. Multiple API versions in Swagger.
6. JWT auth support in Swagger.
7. CORS policy — allow specific origins.
8. CORS with credentials.
9. Deprecated endpoint mark karo.
10. OpenAPI 3.1 features (.NET 10).

---

### 🏆 Chapter 15 Project: **E-commerce Product Catalog API**

Features:
- Products, Categories, Brands entities
- CRUD for all
- Complex filtering (price range, brand, category, rating, search text)
- Pagination, Sorting
- Full validation (custom attributes + FluentValidation)
- API versioning (v1, v2 with different response shapes)
- Global exception handler with ProblemDetails
- Action filters:
  - Audit logging
  - Request timing
- Swagger with auth, versions, grouping
- CORS for specific frontend origins
- Rate limiting
- Image upload for products
- Output caching (.NET 7+)

---

## 📘 Chapter 16: Authentication aur Authorization (Week 16)

### Topic 16.1: Authentication Basics

**Concepts:**
- Authentication vs Authorization
- JWT (JSON Web Token) structure
- Token-based auth flow
- Bearer token
- Refresh tokens
- Storage (httpOnly cookies vs localStorage)
- Claims
- ASP.NET Core Identity
- **.NET 10: Passkey support for Identity**

### 🎯 Practice Questions (Topic 16.1):
1. JWT token structure (header.payload.signature) decode karo.
2. Login endpoint banao with JWT generation.
3. JWT validation middleware configure karo.
4. Claims add karo token mein.
5. Token expiration handle karo.
6. Refresh token mechanism design karo.
7. Secure JWT key storage.
8. Multiple auth schemes (JWT + API key).
9. Token blacklist (logout).
10. Role claim use karo.

---

### Topic 16.2: ASP.NET Core Identity

**Concepts:**
- User/Role models
- UserManager, SignInManager, RoleManager
- Identity setup with EF Core
- Password hashing (built-in)
- Email confirmation
- Password reset
- Two-factor authentication (2FA)
- Lockout on failed attempts
- Customizing User class

### 🎯 Practice Questions (Topic 16.2):
1. Identity setup karo project mein (SQLite/InMemory).
2. Register + Login endpoints.
3. Custom IdentityUser class (extra fields).
4. Password requirements customize.
5. Email confirmation flow.
6. Password reset flow.
7. 2FA setup with TOTP.
8. Lockout configuration.
9. User profile update.
10. Role creation aur assignment.

---

### Topic 16.3: Authorization

**Concepts:**
- `[Authorize]` attribute
- Role-based authorization (`[Authorize(Roles = "Admin")]`)
- Policy-based authorization
- Claims-based authorization
- Custom authorization handlers
- Resource-based authorization
- `AllowAnonymous`

### 🎯 Practice Questions (Topic 16.3):
1. Role-based `[Authorize]` use karo.
2. Policy define karo "MinimumAge" ke liye.
3. Claims-based policy (Department = "IT").
4. Custom authorization handler.
5. Resource-based auth (only owner can edit).
6. Multiple policies combine karo.
7. AllowAnonymous within Authorized controller.
8. Policy requirement se complex logic.
9. Authorization filter attribute.
10. Multi-tenant authorization.

---

### Topic 16.4: Security Best Practices

**Concepts:**
- HTTPS enforcement
- Security headers (HSTS, CSP, X-Frame-Options)
- CSRF protection
- SQL injection prevention (parameterized queries)
- XSS prevention
- Secrets management (Azure Key Vault, AWS Secrets Manager)
- OAuth 2.0 / OpenID Connect basics
- Rate limiting

### 🎯 Practice Questions (Topic 16.4):
1. HTTPS redirect enforce karo.
2. HSTS configure karo.
3. Security headers middleware.
4. Anti-forgery token example.
5. Parameterized queries (baad mein EF Core mein).
6. Rate limiter (.NET 7+) configure karo.
7. Secrets dev vs prod.
8. Google OAuth setup.
9. Login audit log.
10. Brute force prevention.

---

### 🏆 Chapter 16 Project: **Complete User Management API with JWT**

Features:
- User registration (with email confirmation)
- Login (JWT + refresh token)
- Logout (token revocation)
- Password reset
- Profile management
- Role management (Admin endpoints only)
- 2FA setup
- Admin: list all users, deactivate user
- Claims-based authorization (permissions)
- Policy-based authorization (age, department)
- Rate limiting on login
- Audit log
- Swagger with auth support
- Custom IdentityUser (phone, address, DOB)
- Password complexity
- Lockout policy

---

# 🗓️ MONTH 5: DATABASE & EF CORE (Weeks 17-20)

## 📘 Chapter 17: SQL Server Fundamentals (Week 17)

### Topic 17.1: RDBMS Basics + SQL Server Setup

**Concepts:**
- What is RDBMS?
- Tables, columns, rows, keys
- Primary key, Foreign key
- SQL Server Express install
- SSMS (SQL Server Management Studio) install
- Connection string basics
- Databases, schemas

### 🎯 Practice Questions (Topic 17.1):
1. SQL Server install karo aur SSMS se connect.
2. Naya database banao.
3. Connection string explain karo (parts).
4. Schema kya hota hai, use karo.
5. System databases kaunse hain?
6. SQL Server vs PostgreSQL vs MySQL comparison.
7. Authentication modes (Windows vs SQL).
8. Backup aur restore database.
9. Transaction log kya hai?
10. Database files (.mdf, .ldf).

---

### Topic 17.2: DDL, DML, DQL

**Concepts:**
- DDL: `CREATE`, `ALTER`, `DROP`, `TRUNCATE`
- DML: `INSERT`, `UPDATE`, `DELETE`
- DQL: `SELECT`
- Data types (VARCHAR, INT, DATETIME, DECIMAL, BIT)
- Constraints (PRIMARY KEY, FOREIGN KEY, UNIQUE, CHECK, DEFAULT, NOT NULL)
- Identity column
- Indexes (clustered, non-clustered)

### 🎯 Practice Questions (Topic 17.2):
1. Students table banao with all constraints.
2. 10 rows insert karo.
3. Column add karo ALTER se.
4. UPDATE with WHERE.
5. DELETE vs TRUNCATE difference (practical).
6. Data type conversion example.
7. Identity column with seed/increment.
8. Composite primary key.
9. Default value column.
10. CHECK constraint (age > 0).

---

### Topic 17.3: Querying

**Concepts:**
- `SELECT` basics
- `WHERE` clause
- Operators (`AND`, `OR`, `NOT`, `IN`, `BETWEEN`, `LIKE`, `IS NULL`)
- `ORDER BY`
- `GROUP BY` aur aggregate functions (`COUNT`, `SUM`, `AVG`, `MAX`, `MIN`)
- `HAVING`
- `DISTINCT`
- `TOP` / `OFFSET-FETCH`
- Subqueries (inner, correlated)
- CTE (Common Table Expressions) — `WITH`
- Window functions (ROW_NUMBER, RANK, PARTITION BY)

### 🎯 Practice Questions (Topic 17.3):
1. Top 10 highest paid employees.
2. Department-wise employee count.
3. Employees hired in specific year.
4. Average salary per department (HAVING).
5. Names starting with 'A'.
6. Subquery: employees above avg salary.
7. CTE se hierarchical query.
8. ROW_NUMBER() for pagination.
9. RANK() for top 3 per department.
10. Running total with window function.

---

### Topic 17.4: Joins

**Concepts:**
- `INNER JOIN`
- `LEFT JOIN` / `LEFT OUTER JOIN`
- `RIGHT JOIN`
- `FULL OUTER JOIN`
- `CROSS JOIN`
- Self join
- Multiple joins
- Join vs subquery

### 🎯 Practice Questions (Topic 17.4):
1. 2 table inner join.
2. Left join — unmatched records dikhao.
3. Full outer join example.
4. Self join (manager-employee).
5. 3 tables join karo.
6. Join with aggregation.
7. Join with filter.
8. Many-to-many via junction table.
9. Cross join example.
10. Performance: join vs subquery.

---

### Topic 17.5: Advanced SQL

**Concepts:**
- Stored procedures
- Functions (scalar, table-valued)
- Views
- Triggers (before, after, instead of)
- Transactions (BEGIN, COMMIT, ROLLBACK)
- Isolation levels
- Indexes (create, types, performance)
- Execution plans (basic)

### 🎯 Practice Questions (Topic 17.5):
1. Stored procedure with parameters banao.
2. Scalar function banao.
3. Table-valued function.
4. View banao complex query ka.
5. Trigger for audit log.
6. Transaction with rollback on error.
7. Isolation levels — each ka example.
8. Index banao aur execution plan compare.
9. Covering index.
10. Query optimization practical.

---

### 🏆 Chapter 17 Project: **Complete E-commerce Database Design**

Tables:
- Users, Addresses
- Categories, Brands
- Products, ProductImages, ProductVariants
- Inventory, Warehouses
- Carts, CartItems
- Orders, OrderItems, OrderStatus
- Payments, PaymentMethods
- Reviews, Ratings
- Coupons, Promotions
- Shipments, Couriers

Requirements:
- All constraints (PK, FK, UNIQUE, CHECK)
- Indexes on frequently queried columns
- Seed data (100+ products, 50+ orders)
- 20+ SQL queries for business reports:
  - Top selling products
  - Customer lifetime value
  - Monthly revenue
  - Low stock alert
  - etc.
- 5 stored procedures
- 3 views
- 2 triggers (audit, inventory update)
- Backup/restore script
- ER diagram (dbdiagram.io se)

---

## 📘 Chapter 18: Entity Framework Core (Week 18)

### Topic 18.1: EF Core Introduction

**Concepts:**
- ORM (Object-Relational Mapping) kya hai
- EF Core vs Dapper vs ADO.NET
- Code First, Database First, Model First
- DbContext, DbSet
- Providers (SQL Server, PostgreSQL, SQLite, MySQL, InMemory)
- **EF Core 10 new features** (LeftJoin/RightJoin, JSON column ExecuteUpdate, named query filters, complex types in JSON)
- NuGet packages needed

### 🎯 Practice Questions (Topic 18.1):
1. EF Core setup karo project mein.
2. DbContext class banao with 3 DbSets.
3. Provider choose karo aur connection string.
4. Code First vs Database First comparison.
5. EF Core vs Dapper when to use.
6. Scaffolding se Database First karo.
7. Multiple contexts in project.
8. Context pooling.
9. Log queries to console.
10. EF Core version check aur migration strategy.

---

### Topic 18.2: Model Configuration

**Concepts:**
- Data Annotations vs Fluent API
- `[Key]`, `[Required]`, `[MaxLength]`, `[ForeignKey]`
- `OnModelCreating` method
- `modelBuilder.Entity<T>()` configurations
- Table/column naming
- Ignoring properties
- Value conversions
- Shadow properties
- **Complex types** (especially JSON mapping in EF Core 10)

### 🎯 Practice Questions (Topic 18.2):
1. Data Annotations se Product entity configure karo.
2. Same with Fluent API.
3. Table name customize.
4. Composite key.
5. Index via Fluent API.
6. Value converter for enum.
7. Shadow property (CreatedAt).
8. Complex type (Address in User).
9. JSON column mapping (EF Core 10).
10. Global query filter.

---

### Topic 18.3: Relationships

**Concepts:**
- One-to-One
- One-to-Many (most common)
- Many-to-Many (explicit join table or skip navigation)
- Required vs Optional relationships
- Cascade delete
- `HasOne`, `HasMany`, `WithOne`, `WithMany`, `HasForeignKey`
- Eager loading (`Include`, `ThenInclude`)
- Explicit loading
- Lazy loading
- Related data manipulation

### 🎯 Practice Questions (Topic 18.3):
1. One-to-Many: User → Orders.
2. Many-to-Many: Student ↔ Course (skip navigation).
3. Many-to-Many with explicit join table + payload.
4. One-to-One: User → Profile.
5. Self-referencing (Category → Parent).
6. Cascade delete config.
7. Include + ThenInclude for nested data.
8. Explicit loading example.
9. Lazy loading setup.
10. Filtered includes (.NET 5+).

---

### Topic 18.4: Migrations

**Concepts:**
- `dotnet ef migrations add`
- `dotnet ef database update`
- `dotnet ef migrations remove`
- `Update-Database` in PMC
- Generating SQL scripts
- Seed data (`HasData`)
- Rollback
- Migration vs model inconsistency

### 🎯 Practice Questions (Topic 18.4):
1. Initial migration banao.
2. Column add karke migration banao.
3. Migration ko rollback karo.
4. SQL script generate karo migration ka.
5. Seed data add karo HasData se.
6. Multiple environments ke liye migrations.
7. Migration bundle banao deployment ke liye.
8. Custom migration operation.
9. Migration order issues.
10. Production deployment strategy.

---

### 🏆 Chapter 18 Project: **Library Management API with EF Core**

Entities:
- Book, Author, Publisher, Category
- Member, BookLoan, Reservation
- Fine, Payment

Features:
- Full CRUD with EF Core
- Complex relationships (many-to-many: Book-Author)
- Proper Fluent API configuration
- Migrations
- Seed data (sample books, authors, members)
- Business rules:
  - Max 3 books per member
  - Auto-calculate fine on late return
  - Reservation queue
- Advanced queries with includes
- Query filtering, pagination
- Swagger documentation
- Integration with previous Auth system

---

## 📘 Chapter 19: Advanced EF Core (Week 19)

### Topic 19.1: Querying & Performance

**Concepts:**
- LINQ to EF Core (translated to SQL)
- `ToList`, `ToArray`, `ToListAsync`
- `First`, `Single`, `FirstOrDefault`
- `AsNoTracking()` for read-only
- `Find()` vs `FirstOrDefault()`
- Projection (`Select`) for performance
- `AsSplitQuery()` for complex includes
- N+1 problem aur solution
- Compiled queries
- Raw SQL (`FromSqlRaw`, `ExecuteSqlRaw`)
- `ExecuteUpdate`, `ExecuteDelete` (.NET 7+)
- **EF Core 10 `ExecuteUpdate` on JSON columns**

### 🎯 Practice Questions (Topic 19.1):
1. AsNoTracking use karke read-only query.
2. N+1 problem reproduce karo aur fix.
3. AsSplitQuery ka use.
4. Projection se sirf needed columns fetch.
5. Compiled query example.
6. Raw SQL with parameters.
7. ExecuteUpdate bulk update.
8. ExecuteDelete bulk delete.
9. EF Core 10 JSON column update.
10. Performance comparison: tracking vs no-tracking.

---

### Topic 19.2: Change Tracking

**Concepts:**
- Change tracker
- Entity states (Added, Modified, Deleted, Unchanged, Detached)
- SaveChanges
- Attach, Update, Remove
- Concurrency handling (optimistic concurrency with timestamp)
- Disconnected scenarios (Web API)
- Transaction scope

### 🎯 Practice Questions (Topic 19.2):
1. Entity state inspect karo ChangeTracker se.
2. Disconnected update (Web API scenario).
3. Attach + State modification.
4. Concurrency token (RowVersion) setup.
5. Concurrency exception handle karo.
6. Explicit transaction multiple SaveChanges ke saath.
7. Bulk insert optimization.
8. ChangeTracker entries iterate karo.
9. Pre-save validation.
10. Audit log via ChangeTracker.

---

### Topic 19.3: Advanced Features

**Concepts:**
- Interceptors (save, command, connection)
- Value generators
- Owned entity types
- Table-per-hierarchy (TPH), Table-per-type (TPT), Table-per-concrete (TPC) inheritance
- Temporal tables (SQL Server)
- Global query filters (soft delete)
- **Named query filters (EF Core 10 NEW!)** — multiple filters per entity, selectively disable
- Database functions

### 🎯 Practice Questions (Topic 19.3):
1. Save interceptor for audit.
2. Command interceptor for logging.
3. Value generator for custom IDs.
4. Owned entity (Address in User).
5. TPH inheritance setup.
6. Temporal table query (as of date).
7. Global query filter for soft delete.
8. Named query filter (EF Core 10).
9. Ignore query filter for admin queries.
10. Database function mapping.

---

### Topic 19.4: Dapper (Alternative)

**Concepts:**
- Why Dapper? (Performance)
- Query, QueryAsync
- Parameterized queries
- Multi-mapping
- When to use Dapper vs EF Core
- Hybrid approach (EF + Dapper in same project)

### 🎯 Practice Questions (Topic 19.4):
1. Dapper setup.
2. Simple query with parameters.
3. QueryAsync.
4. Multi-mapping (join result to 2 entities).
5. Stored procedure call.
6. Bulk insert with Dapper.
7. Dynamic query building.
8. Transaction with Dapper.
9. Performance comparison with EF Core.
10. Dapper + EF Core in same project.

---

### 🏆 Chapter 19 Project: **Blog Platform with Complex Relationships**

Entities:
- User, Post, Comment, Category, Tag
- Like, Bookmark, Follow
- Notification

Advanced Features:
- Many-to-many Post-Tag with skip navigation
- Many-to-many User self-referencing (Follow)
- TPH for Notification types (LikeNotification, CommentNotification, FollowNotification)
- Global query filter for soft-delete
- Named query filters (EF 10) for draft/published
- Temporal table for post history
- Complex queries:
  - Feed (posts from followed users)
  - Trending posts
  - User statistics
- Interceptors:
  - Audit log
  - Slow query logger
- ExecuteUpdate for bulk operations
- Optimistic concurrency
- Dapper for read-heavy analytics queries
- Full-text search

---

## 📘 Chapter 20: NoSQL aur Caching (Week 20)

### Topic 20.1: MongoDB with .NET

**Concepts:**
- NoSQL vs SQL
- MongoDB concepts (collections, documents, BSON)
- MongoDB.Driver NuGet package
- Connection, Database, Collection
- CRUD operations
- Aggregation pipeline
- Indexing
- Transactions
- Atlas (cloud MongoDB) basics

### 🎯 Practice Questions (Topic 20.1):
1. MongoDB install karo (local ya Atlas).
2. .NET se connect karo.
3. Insert, Find, Update, Delete.
4. Filter builder use karo.
5. Aggregation pipeline (match + group + sort).
6. Index create karo.
7. Transactions example.
8. Embedded documents vs references.
9. LINQ queries with MongoDB driver.
10. MongoDB in Web API.

---

### Topic 20.2: Redis aur Caching

**Concepts:**
- In-memory cache (`IMemoryCache`)
- Distributed cache (`IDistributedCache`)
- Redis setup (Docker)
- StackExchange.Redis
- Output caching (.NET 7+)
- Response caching
- Cache-aside pattern
- Cache invalidation strategies (TTL, event-based)
- Cache stampede prevention

### 🎯 Practice Questions (Topic 20.2):
1. IMemoryCache use karke frequent query cache.
2. Redis setup Docker mein.
3. Distributed cache se session store.
4. Cache-aside pattern implement karo.
5. Output caching endpoint level.
6. Response caching with headers.
7. Cache invalidation on update.
8. Sliding vs absolute expiration.
9. Distributed lock with Redis.
10. Performance comparison: with/without cache.

---

### 🏆 Chapter 20 Project: **News Aggregator with Caching**

Features:
- Article entity in MongoDB
- Categories, Authors in MongoDB
- User preferences in SQL Server (EF Core)
- Redis caching:
  - Trending articles (5 min TTL)
  - Category-wise articles
  - User feed
- Full-text search in MongoDB
- View count with Redis (INCR)
- Rate limiting with Redis
- Hybrid approach: SQL for transactions, NoSQL for content
- Background service to fetch from multiple APIs
- Output caching for static endpoints
- Cache invalidation on new article

---

# 🗓️ MONTH 6: ENTERPRISE & PRODUCTION (Weeks 21-24)

## 📘 Chapter 21: Design Patterns & Clean Architecture (Week 21)

### Topic 21.1: SOLID Principles

**Concepts:**
- **S**ingle Responsibility Principle
- **O**pen/Closed Principle
- **L**iskov Substitution Principle
- **I**nterface Segregation Principle
- **D**ependency Inversion Principle
- Real-world violations and fixes
- DRY, KISS, YAGNI

### 🎯 Practice Questions (Topic 21.1):
1. SRP violation example + refactor.
2. OCP — extending without modifying.
3. LSP violation (Square/Rectangle classic).
4. ISP — fat interface split.
5. DIP — high-level depends on abstraction.
6. Before/after SOLID refactoring project.
7. When NOT to over-engineer.
8. DRY violations in real code.
9. KISS principle example.
10. YAGNI discussion.

---

### Topic 21.2: Common Design Patterns

**Concepts:**
- **Creational**: Singleton, Factory, Abstract Factory, Builder, Prototype
- **Structural**: Adapter, Decorator, Facade, Proxy, Composite
- **Behavioral**: Strategy, Observer, Command, Template Method, State, Chain of Responsibility, Mediator

### 🎯 Practice Questions (Topic 21.2):
1. Singleton properly (thread-safe with Lazy<T>).
2. Factory pattern for object creation.
3. Strategy pattern for payment methods.
4. Observer pattern with events.
5. Decorator pattern (logging decorator).
6. Command pattern for undo/redo.
7. Template method for algorithms.
8. Chain of Responsibility for validators.
9. Mediator pattern intro.
10. Facade for complex subsystem.

---

### Topic 21.3: Repository & Unit of Work

**Concepts:**
- Repository pattern
- Generic repository
- Specific repositories
- Unit of Work
- When NOT to use Repository (EF Core is already repository-like)
- Query objects

### 🎯 Practice Questions (Topic 21.3):
1. `IRepository<T>` generic interface.
2. Specific `IProductRepository` with domain methods.
3. Unit of Work implementation.
4. Repository with Specification pattern.
5. Transaction across multiple repositories.
6. In-memory repository for testing.
7. Repository ya direct DbContext — debate.
8. CQRS-friendly read repositories.
9. Async repository methods.
10. Repository with caching decorator.

---

### Topic 21.4: Clean Architecture

**Concepts:**
- Layers:
  - **Domain** (Entities, Value Objects, Domain Events, Interfaces)
  - **Application** (Use Cases, DTOs, Interfaces)
  - **Infrastructure** (DB, External APIs, Implementations)
  - **Presentation** (Web API, UI)
- Dependency rule (inner layers don't know outer)
- Onion Architecture
- Hexagonal Architecture (Ports & Adapters)
- DDD basics (Entities, Value Objects, Aggregates, Repositories, Domain Services)

### 🎯 Practice Questions (Topic 21.4):
1. Solution structure with 4 projects (Domain, Application, Infrastructure, Web).
2. Domain entity with behavior (not anemic).
3. Value object (Money, Address).
4. Aggregate root example.
5. Domain events.
6. Application use case (handler).
7. DTOs vs domain entities.
8. Infrastructure: EF Core repository implementation.
9. Presentation: controller calling use case.
10. Dependency direction validation.

---

### 🏆 Chapter 21 Project: **Refactor E-commerce API to Clean Architecture**

Restructure previous e-commerce project:
- `MyShop.Domain` (entities, value objects, interfaces)
- `MyShop.Application` (use cases, DTOs, validators)
- `MyShop.Infrastructure` (EF Core, external services)
- `MyShop.Api` (controllers, DI setup)
- `MyShop.Shared` (common types)

Implement:
- Domain entities with business logic
- Value objects (Money, Address, Email)
- Aggregates (Order as aggregate root)
- Domain events (OrderPlaced, PaymentReceived)
- Application use cases (CreateOrder, CancelOrder, etc.)
- Repository pattern + Unit of Work
- DTOs aur AutoMapper
- Strategy pattern for payment
- Decorator pattern for logging

---

## 📘 Chapter 22: Advanced Architecture (Week 22)

### Topic 22.1: CQRS with MediatR

**Concepts:**
- Command Query Responsibility Segregation
- Commands (write) vs Queries (read)
- MediatR library
- Handlers
- Pipeline behaviors (logging, validation, caching)
- FluentValidation with MediatR

### 🎯 Practice Questions (Topic 22.1):
1. MediatR setup.
2. Command + handler (CreateProduct).
3. Query + handler (GetProductById).
4. Validation behavior in pipeline.
5. Logging behavior.
6. Caching behavior.
7. Transaction behavior.
8. Notification (domain events).
9. Multiple handlers for notification.
10. CQRS + EF Core read/write model.

---

### Topic 22.2: Domain-Driven Design (DDD)

**Concepts:**
- Strategic DDD (Bounded Contexts, Context Mapping)
- Tactical DDD (Entities, Value Objects, Aggregates, Repositories, Domain Services, Domain Events)
- Ubiquitous Language
- Anemic vs Rich domain models
- Aggregate design rules

### 🎯 Practice Questions (Topic 22.2):
1. Bounded context identify karo e-commerce mein.
2. Rich domain model vs anemic (refactor).
3. Value object: Money with arithmetic.
4. Aggregate: Order with OrderItems.
5. Domain service when entity can't.
6. Domain event raise karo entity mein.
7. Event handler.
8. Repository per aggregate root.
9. Specification pattern.
10. DDD in Clean Architecture.

---

### Topic 22.3: Microservices Basics

**Concepts:**
- Monolith vs Microservices
- When to use microservices (NOT always!)
- Service boundaries
- API Gateway (YARP, Ocelot)
- Service discovery
- Inter-service communication (HTTP, gRPC, messaging)
- Data management (database per service)
- Saga pattern for distributed transactions
- Event-driven architecture
- Eventual consistency

### 🎯 Practice Questions (Topic 22.3):
1. 2 microservices banao (Products, Orders).
2. HTTP communication (HttpClient).
3. YARP API gateway setup.
4. gRPC service setup.
5. Service-to-service authentication.
6. Shared models via NuGet package.
7. Saga pattern concept.
8. Eventual consistency example.
9. Health checks for all services.
10. Distributed tracing concept.

---

### Topic 22.4: Messaging

**Concepts:**
- Message broker (RabbitMQ, Azure Service Bus, AWS SQS)
- Publish/Subscribe pattern
- Queue vs Topic
- MassTransit library
- Idempotent consumers
- Outbox pattern
- Dead letter queue

### 🎯 Practice Questions (Topic 22.4):
1. RabbitMQ setup (Docker).
2. MassTransit basic setup.
3. Publish message.
4. Consume message.
5. Request/Response pattern.
6. Saga with MassTransit.
7. Outbox pattern implement karo.
8. Dead letter queue handle karo.
9. Retry policy.
10. Distributed tracing with messaging.

---

### Topic 22.5: gRPC & Real-Time

**Concepts:**
- gRPC basics
- Proto files
- .NET gRPC server/client
- Streaming (server, client, bidirectional)
- SignalR for real-time
- **.NET 10 Server-Sent Events (SSE) in Minimal APIs**

### 🎯 Practice Questions (Topic 22.5):
1. gRPC service with 4 method types.
2. gRPC client.
3. Streaming example.
4. SignalR chat app.
5. SignalR groups.
6. Authentication with SignalR.
7. Server-Sent Events (.NET 10).
8. WebSocket vs SSE vs SignalR vs gRPC.
9. Load balancing gRPC.
10. Protobuf performance vs JSON.

---

### 🏆 Chapter 22 Project: **Microservices-Based Order System**

Services:
- **Product Service**: Product catalog (EF Core + SQL Server)
- **Order Service**: Orders (EF Core + SQL Server)
- **Inventory Service**: Stock management (MongoDB)
- **Notification Service**: Email/SMS (consumer only)
- **Payment Service**: Payment processing
- **API Gateway**: YARP

Features:
- CQRS + MediatR in each service
- RabbitMQ for async communication
- Outbox pattern for reliable publishing
- Saga pattern for order flow (Reserve inventory → Process payment → Confirm order)
- gRPC for sync inter-service calls
- SignalR for order status updates to frontend
- Shared contracts library
- Health checks for all services
- Serilog structured logging
- Docker Compose setup

---

## 📘 Chapter 23: Testing (Week 23)

### Topic 23.1: Unit Testing Basics

**Concepts:**
- Why testing?
- xUnit (most popular) vs NUnit vs MSTest
- Arrange-Act-Assert pattern
- `[Fact]` vs `[Theory]` (parameterized tests)
- Assertions (`Assert.Equal`, `Assert.True`, `Assert.Throws`)
- FluentAssertions library
- Test naming conventions
- Code coverage

### 🎯 Practice Questions (Topic 23.1):
1. xUnit test project banao.
2. Calculator class ke liye 10 tests.
3. Theory with InlineData (parameterized).
4. Theory with MemberData.
5. Assert.Throws for exception testing.
6. FluentAssertions use karo.
7. Setup/teardown with constructor/IDisposable.
8. Code coverage measure karo.
9. Test naming convention.
10. TestCategories.

---

### Topic 23.2: Mocking

**Concepts:**
- Why mock? (Isolate unit under test)
- Moq library
- NSubstitute
- Mocking interfaces
- `Setup`, `Returns`, `Verify`, `Callback`
- Mocking async methods
- Strict vs Loose mocks

### 🎯 Practice Questions (Topic 23.2):
1. Mock IRepository for service test.
2. Setup method to return specific value.
3. Verify method was called N times.
4. Mock async method.
5. Callback to capture arguments.
6. It.IsAny<T>() vs specific value.
7. Mock chain of calls.
8. Strict mock setup.
9. Mock virtual method.
10. NSubstitute equivalent of same tests.

---

### Topic 23.3: Integration Testing

**Concepts:**
- `WebApplicationFactory<T>`
- In-memory database (EF Core InMemory or SQLite)
- TestContainers (real DB in Docker)
- HttpClient in tests
- Seeding test data
- Authentication in tests
- Testing middleware

### 🎯 Practice Questions (Topic 23.3):
1. WebApplicationFactory setup.
2. GET endpoint integration test.
3. POST with body.
4. Auth-protected endpoint test.
5. EF Core InMemory in test.
6. SQLite in-memory for test.
7. TestContainers with real SQL Server.
8. Seed test data.
9. Reset database between tests.
10. End-to-end scenario test.

---

### Topic 23.4: TDD & Test Strategy

**Concepts:**
- Test-Driven Development (Red-Green-Refactor)
- Unit vs Integration vs E2E (test pyramid)
- BDD (SpecFlow)
- What to test, what NOT to test
- Testing guidelines
- CI integration

### 🎯 Practice Questions (Topic 23.4):
1. Solve simple problem with TDD.
2. Test pyramid diagram apne project ke liye.
3. What to test (public behaviour) vs implementation.
4. SpecFlow basic example.
5. Testing private methods — approach.
6. Testing static methods.
7. Integration test CI mein.
8. Test organization.
9. Fixture-based tests.
10. Mutation testing intro.

---

### 🏆 Chapter 23 Project: **Add Complete Tests to E-commerce API**

Add to previous project:
- Unit tests for:
  - All domain logic
  - Application use cases (with mocked repositories)
  - Value objects
  - Custom validators
- Integration tests for:
  - All API endpoints
  - Database operations
  - Authentication flow
  - Full order placement flow
- TestContainers for real SQL Server
- Code coverage 80%+
- Test naming convention
- CI workflow runs all tests
- Performance tests (BenchmarkDotNet intro)

---

## 📘 Chapter 24: DevOps, Deployment aur Production (Week 24)

### Topic 24.1: Docker

**Concepts:**
- Container vs VM
- Docker basics (image, container, Dockerfile)
- Multi-stage Dockerfile for .NET
- Docker Compose
- .dockerignore
- Container registry (Docker Hub, ACR, ECR)
- Volumes, networks
- Best practices

### 🎯 Practice Questions (Topic 24.1):
1. ASP.NET Core app ko Docker image banao.
2. Multi-stage Dockerfile (build + runtime).
3. docker-compose.yml for API + SQL Server.
4. Volume for SQL data persistence.
5. Network between containers.
6. Environment variables in Docker.
7. Image size optimize karo.
8. Non-root user in container.
9. Health check in Dockerfile.
10. Push to Docker Hub.

---

### Topic 24.2: CI/CD

**Concepts:**
- Continuous Integration
- Continuous Deployment/Delivery
- GitHub Actions
- Azure DevOps Pipelines
- Build, test, deploy stages
- Environment-specific deployments
- Secrets management in CI/CD
- Infrastructure as Code (Bicep, Terraform intro)

### 🎯 Practice Questions (Topic 24.2):
1. GitHub Actions workflow banao (build + test).
2. Deploy to staging on merge.
3. Deploy to prod on tag.
4. Secrets in GitHub Actions.
5. Matrix build (multiple .NET versions).
6. Docker build in CI.
7. Push to container registry.
8. Deploy to Azure App Service.
9. Rollback strategy.
10. Azure DevOps pipeline equivalent.

---

### Topic 24.3: Deployment & Hosting

**Concepts:**
- Azure App Service
- Azure Container Apps
- AWS ECS/Fargate
- Kubernetes basics (AKS, EKS)
- Reverse proxy (Nginx, YARP)
- HTTPS certificates (Let's Encrypt)
- Environment configuration
- Blue-green deployment
- Zero-downtime deployment

### 🎯 Practice Questions (Topic 24.3):
1. Deploy to Azure App Service (free tier).
2. Custom domain setup.
3. Application Insights setup.
4. Azure SQL connection from app.
5. Azure Key Vault for secrets.
6. Deployment slots (staging + prod swap).
7. Scale out (multiple instances).
8. Auto-scaling rules.
9. Alerts setup.
10. Log streaming.

---

### Topic 24.4: Observability & Production

**Concepts:**
- Structured logging (Serilog)
- Application Insights / OpenTelemetry
- Distributed tracing
- Metrics (Prometheus + Grafana)
- Health checks
- Feature flags (LaunchDarkly, ConfigCat)
- Performance profiling
- Memory dumps
- Load testing (k6, JMeter, Bombardier)

### 🎯 Practice Questions (Topic 24.4):
1. Serilog setup with sinks.
2. OpenTelemetry basic setup.
3. Distributed tracing across services.
4. Custom metrics.
5. Health checks endpoint (readiness + liveness).
6. Feature flag implementation.
7. Load test with k6.
8. Memory profiling dotnet-dump.
9. Application Insights alerts.
10. Grafana dashboard.

---

### Topic 24.5: Security in Production

**Concepts:**
- HTTPS always
- Secrets in environment variables / Key Vault
- Security headers
- OWASP Top 10
- Dependency scanning
- Static code analysis (SonarQube)
- Penetration testing basics

### 🎯 Practice Questions (Topic 24.5):
1. HTTPS + HSTS setup.
2. Security headers middleware.
3. OWASP Top 10 — each ka mitigation.
4. SQL injection prevention (we already have EF).
5. XSS prevention in API responses.
6. CSRF token (if using cookies).
7. Secrets scanning in CI.
8. NuGet audit (`dotnet list package --vulnerable`).
9. SonarQube integration.
10. Rate limiting + DDoS prevention.

---

### 🏆 Chapter 24 Project: **Production-Ready Deployment**

Deploy your e-commerce microservices:
- Docker Compose for local dev
- Multi-stage Dockerfiles for each service
- GitHub Actions CI/CD:
  - Build + unit tests on PR
  - Integration tests
  - Security scanning (CodeQL, Trivy)
  - Deploy to Azure Container Apps on main push
- Azure setup:
  - Azure Container Registry
  - Azure Container Apps
  - Azure SQL Database
  - Azure Cache for Redis
  - Azure Service Bus
  - Azure Key Vault (secrets)
  - Application Insights
- Observability:
  - Serilog + Application Insights
  - Custom metrics
  - Distributed tracing (OpenTelemetry)
- Health checks on all services
- Load testing with k6
- Alerts for key metrics
- Documentation:
  - README
  - API docs
  - Architecture diagrams
  - Runbook for incidents

---

# 🎓 FINAL CAPSTONE PROJECT: Complete Enterprise E-commerce Platform

**Tumhara graduation project** — resume ka showpiece!

## Requirements:

### Business Features
- User accounts with roles (Customer, Vendor, Admin)
- Product catalog with variants, images, videos
- Shopping cart + Wishlist
- Checkout + Payment (Stripe sandbox)
- Order tracking + Status updates (real-time)
- Reviews + Ratings
- Coupons + Promotions
- Multi-vendor support
- Notifications (email + push)
- Admin dashboard
- Analytics + Reports
- Search with filters (Elasticsearch optional)

### Technical Requirements
- **Architecture**: Microservices (minimum 5 services)
- **Patterns**: Clean Architecture + DDD + CQRS within each service
- **Services**:
  - Identity (Auth, JWT)
  - Catalog (Products, Categories)
  - Cart + Order
  - Payment
  - Notification
  - Inventory
- **Databases**: SQL Server + MongoDB + Redis
- **Messaging**: RabbitMQ with MassTransit
- **API Gateway**: YARP
- **Real-time**: SignalR for order updates
- **gRPC**: Service-to-service sync calls
- **Authentication**: JWT with refresh tokens, 2FA optional
- **Authorization**: Role + Policy based
- **Testing**: 80%+ coverage (unit + integration)
- **Logging**: Serilog + Application Insights
- **Caching**: Redis for frequently accessed data
- **CI/CD**: GitHub Actions
- **Deployment**: Docker Compose (local) + Azure (prod)
- **Monitoring**: Health checks + Custom metrics
- **Documentation**: Swagger + README + Architecture diagrams

### Deliverables
1. GitHub repository (public)
2. Live deployed URL (Azure/AWS free tier)
3. Video demo (5-10 min)
4. Technical blog post (Medium/Dev.to)
5. Architecture diagrams (drawn)
6. LinkedIn post showcasing work

---

# 💼 JOB PREPARATION TIPS

## Week-by-Week Resume Building

**Month 1-2 End**: "Console-based applications with C# and OOP"
**Month 3 End**: "Advanced C# with async programming, LINQ, and modern features"
**Month 4 End**: "ASP.NET Core Web APIs with authentication and authorization"
**Month 5 End**: "Full-stack backend with SQL Server and EF Core"
**Month 6 End**: "Enterprise-grade microservices with Clean Architecture, DDD, CQRS"

## Interview Prep Topics (Priority)

### Must-Know
1. OOP concepts with C# examples
2. Async/await deep dive
3. LINQ
4. ASP.NET Core middleware pipeline
5. Dependency Injection lifetimes
6. EF Core tracking, N+1, includes
7. SQL joins, indexes, execution plans
8. SOLID principles with examples
9. REST API design
10. JWT authentication flow

### Good-to-Know
1. Design patterns (Repository, Factory, Strategy, Observer)
2. Clean Architecture + DDD
3. CQRS + MediatR
4. Microservices patterns
5. Docker basics
6. CI/CD concepts

### Common Interview Questions
1. Value types vs Reference types
2. Boxing aur Unboxing
3. `string` vs `StringBuilder`
4. Delegate vs Event vs Interface
5. `Task` vs `Thread`
6. `IEnumerable` vs `IQueryable`
7. Deferred vs Immediate execution
8. `abstract class` vs `interface`
9. `virtual`/`override`/`new`/`sealed`
10. GC generations aur working
11. ASP.NET Core request pipeline
12. Middleware order matters?
13. DI lifetimes with scenarios
14. EF Core change tracking
15. N+1 problem aur solution

## Mock Projects for Resume

Besides capstone:
1. **Task Manager API** (Chapter 16 project enhanced)
2. **Real-Time Chat App** (SignalR)
3. **URL Shortener** (Redis, high-performance)
4. **Blog Platform** (full-stack with frontend)
5. **Inventory Management** (CQRS + Event Sourcing)

## GitHub Profile Tips
- Pinned 6 best repos
- README with tech stack, architecture, screenshots
- Commit history consistent (green squares)
- Proper `.gitignore`, `LICENSE`
- Professional profile README

## LinkedIn Strategy
- Post weekly about what you learned
- Share projects with demo videos
- Connect with .NET developers
- Follow Microsoft MVPs (David Fowler, Nick Chapsas, Scott Hanselman, Tim Corey)
- Engage with posts

## Where to Apply
- **Startups**: Unicorn.com, AngelList
- **Service-based**: TCS, Infosys, Wipro, Accenture, Cognizant (for freshers)
- **Product**: Microsoft, JP Morgan, Morgan Stanley, BlackRock, Goldman Sachs
- **LinkedIn Jobs**: Filter by "C#" or ".NET" + Remote/On-site
- **Naukri, Indeed, Glassdoor**: India-specific

## Salary Expectations (India, 2026)
- **Fresher**: 4-8 LPA (service), 12-25 LPA (product)
- **1-3 years**: 8-15 LPA (service), 20-40 LPA (product)
- **3-5 years**: 15-30 LPA (service), 35-70 LPA (product)
- **5+ years**: 25 LPA+ (service), 50 LPA-1.5 Cr+ (product/FAANG-like)

---

# 📚 ADDITIONAL LEARNING RESOURCES

## Official Docs (MUST)
- Microsoft Learn: https://learn.microsoft.com/dotnet
- .NET Blog: https://devblogs.microsoft.com/dotnet/
- ASP.NET Blog: https://devblogs.microsoft.com/aspnet/

## YouTube Channels (Free Gold!)
- **Nick Chapsas** — Most underrated, pure gold for .NET
- **Tim Corey (IAmTimCorey)** — Best for beginners
- **Milan Jovanović** — Clean architecture, DDD
- **Codewrinkles** — Advanced C#
- **Raw Coding** — Deep dives
- **Gavin Lon** — .NET tutorials
- **Coding Tutorials** — Project-based
- **Programming with Mosh** — C# basics

## Books
- "C# in Depth" — Jon Skeet
- "CLR via C#" — Jeffrey Richter
- "Pro ASP.NET Core 10" — Adam Freeman
- "Domain-Driven Design" — Eric Evans
- "Clean Architecture" — Robert C. Martin
- "Implementing Domain-Driven Design" — Vaughn Vernon

## Courses (Paid if budget allows)
- Pluralsight (free trial)
- Udemy (sales often)
- Dometrain (Nick Chapsas's platform)
- Microsoft Learn paths (FREE!)

## Communities
- r/dotnet (Reddit)
- .NET Discord
- Stack Overflow
- GitHub Discussions

## Blogs
- Andrew Lock — https://andrewlock.net
- Steve Smith — https://ardalis.com
- Scott Hanselman — https://hanselman.com
- Khalid Abuhakmeh — https://khalidabuhakmeh.com

---

# ✅ WEEKLY CHECKLIST TEMPLATE

Har week ke end mein ye check karo:

- [ ] Saare topics ke 10 questions solve kiye?
- [ ] Chapter project complete hai?
- [ ] GitHub pe push kiya?
- [ ] Notes banaye?
- [ ] LinkedIn post (optional par recommended)?
- [ ] Kuch naya concept jo samjha — kisi aur ko explain kar sakte ho?
- [ ] Previous concepts yaad hain ya revision chahiye?

---

# 🎯 FINAL WORDS

Bhai/Behen, ye journey **serious** hai. 6 months agar pure focus se karoge, toh tum **job-ready** ho jaoge. Bahut log .NET developer kehlate hain par unhe Clean Architecture, CQRS, microservices ki depth nahi hoti. Tum ye roadmap follow karke **top 5%** .NET developers mein aaoge.

### Golden Rules Repeat:
1. **Daily coding** — 2-3 hours minimum
2. **GitHub consistency** — green squares matter
3. **Projects over tutorials** — banana zaroori hai
4. **Teach to learn** — blog likho, YouTube banao, dost ko samjhao
5. **Networking** — LinkedIn pe active raho
6. **Never give up** — har kisi ko stuck hona padta hai, keep pushing

### Agar atak jao:
- 30 min khud try karo
- Google karo error message
- Stack Overflow dekho
- Claude/ChatGPT se puchho (par samjh ke, copy nahi)
- Discord/Reddit pe puchho
- Phir bhi nahi toh topic ko 2 din chhod ke wapas aao

**All the best! Tumhara .NET developer banna confirmed hai — bas consistency chahiye.** 🚀

---

**Author Note**: Ye roadmap November 2025 mein release hui .NET 10 (LTS, 3-year support) aur C# 14 ke hisab se banaya gaya hai. Microsoft har saal November mein naya version release karta hai, toh future mein updates dekhte rehna.

**Version**: 1.0 | **Updated**: April 2026 | **For**: .NET 10 + C# 14
