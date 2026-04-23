# Personal Information Manager 📇

A simple C# console application that allows users to securely add, validate, save, and view personal contact information. 

## Features

- **Interactive Menu:** Simple text-based UI to navigate between adding data, viewing data, and exiting.
- **Input Validation:** Ensures robust data entry:
  - Validates Name and City using Regular Expressions (letters and spaces only).
  - Checks Age as a valid numeric input.
  - Validates Email format (must contain an '@' symbol).
  - Validates Phone Number (ensures it consists of numeric digits only).
- **File I/O Data Storage:** - Appends new records cleanly to a local text file (`examples.txt`).
  - Reads and displays all saved records directly from the file.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (latest version recommended) installed on your machine.
- A C# IDE (like Visual Studio, Visual Studio Code, or JetBrains Rider) or just the standard CLI.

## How to Run

1. Clone this repository or download the source code.
2. Open a terminal or command prompt in the project directory.
3. Run the application using the .NET CLI:
   ```bash
   dotnet run
   ```
4. Follow the on-screen menu prompts:
   - Press `1` to add new data.
   - Press `2` to view saved data.
   - Press `3` to exit.

## Note to Developers / Contributors

The application currently features an absolute hardcoded file path for the read operation (Option 2):
`@"D:\\.NET\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net10.0\\examples.txt"`

For better portability across different machines, it is recommended to update this to a relative path (e.g., `"examples.txt"`), to match how the write operation in Option 1 is handled.

