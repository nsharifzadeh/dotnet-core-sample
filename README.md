# MyApp

A .NET Core console application with unit tests.

## Project Structure

```
MyApp/
├── src/
│   └── MyApp/              # Main application
├── tests/
│   └── MyApp.Tests/        # Unit tests
└── MyApp.sln               # Solution file
```

## Prerequisites

- .NET 8.0 SDK or later

## Project Setup

### Create the Structure Using CLI

1. Create the project directory:
```bash
mkdir MyApp
cd MyApp
```

2. Create a solution:
```bash
dotnet new sln -n MyApp
```

3. Create the console app project inside `src`:
```bash
dotnet new console -o src/MyApp
```

4. Create a test project inside `tests`:
```bash
dotnet new xunit -o tests/MyApp.Tests
```

5. Add both projects to the solution:
```bash
dotnet sln add src/MyApp/MyApp.csproj
dotnet sln add tests/MyApp.Tests/MyApp.Tests.csproj
```

6. Add a reference from the test project to the main app:
```bash
dotnet add tests/MyApp.Tests/MyApp.Tests.csproj reference src/MyApp/MyApp.csproj
```

7. Run the tests:
```bash
dotnet test
```

## Getting Started

### Clone and Setup

```bash
git clone <repository-url>
cd MyApp
dotnet restore
```

### Build

```bash
dotnet build
```

### Run Tests

```bash
dotnet test
```

### Run Application

```bash
dotnet run --project src/MyApp/MyApp.csproj
```

## Development

This project uses:
- **.NET 8.0** - Target framework
- **xUnit** - Testing framework

## License

MIT
