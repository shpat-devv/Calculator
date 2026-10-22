
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

## Future Improvements

- Add support for decimal numbers.
- Handle division by zero explicitly.
- Persist calculation history to a file.
- Improve menu navigation and exit confirmation.
- Add unit tests for arithmetic operations.
- Refactor history storage into a dedicated calculation model instead of a flat list of integers.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- A terminal or command-line interface.

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/shpat-devv/Calculator
cd Calculator
```

### 2. Build the Project

```bash
dotnet build
```

### 3. Run the Application

```bash
dotnet run
```

## License

This project is available for personal and educational use.
