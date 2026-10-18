
# C# Terminal Calculator

A simple command-line calculator built with C# and .NET. It allows users to perform basic arithmetic operations through an interactive terminal menu and keeps a history of previous calculations during the current session.

## Features

- **Addition** (`+`) — Adds two integers.
- **Subtraction** (`-`) — Subtracts the second integer from the first.
- **Multiplication** (`*`) — Multiplies two integers.
- **Division** (`/`) — Divides the first integer by the second.
- **Calculation History** — Displays previous calculations and their results.
- **Input Validation** — Handles invalid numeric input and prompts the user to try again.
- **Interactive Menu** — Allows users to select operations or exit the application.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- A terminal or command-line interface.

## Getting Started

### 1. Clone the Repository

```bash
git clone <repository-url>
cd <repository-directory>
```

Replace the placeholders with your repository URL and directory name.

### 2. Build the Project

```bash
dotnet build
```

### 3. Run the Application

```bash
dotnet run
```

## Usage

When the application starts, it displays the available operations:

```text
Hello User, choose your option:

1, +
2, -
3, *
4, /
5, History
6, Exit
```

Enter the number corresponding to the operation you want to perform.

### Example: Addition

```text
Hello User, choose your option:

1, +
2, -
3, *
4, /
5, History
6, Exit

1

Choose first number:
10
Choose second number:
5

Result: 15,
Continue? (y/n)
```

After a calculation, enter `N` to exit or another key to continue.

### Viewing Calculation History

Select option `5` to display previous calculations.

Example:

```text
10+5=15
20-8=12
4*6=24
```

The history is stored in memory and is available only while the application is running.

## Project Structure

```text
Calculator/
├── Calculator.cs
├── Program.cs
├── Calculator.csproj
└── README.md
```

## Future Improvements

- Add support for decimal numbers.
- Handle division by zero explicitly.
- Persist calculation history to a file.
- Improve menu navigation and exit confirmation.
- Add unit tests for arithmetic operations.
- Refactor history storage into a dedicated calculation model instead of a flat list of integers.

## License

This project is available for personal and educational use.
