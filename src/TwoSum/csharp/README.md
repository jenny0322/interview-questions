# Test Execution (C#)

To run the C# unit tests in this project, ensure the following prerequisites are installed and properly configured.

---

## 1. .NET SDK

- **Required**: .NET SDK 6.0 or higher (depending on your project)
- **Check if installed**:
  ```bash
  dotnet --version
  ```

- **Install if missing**:
  - **macOS**:
    ```bash
    brew install --cask dotnet-sdk
    ```
  - **Windows/Linux**:  
    Download and install from the official site: [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

---

## 2. Running the Tests

Navigate to the directory containing the `.sln` or test project file and run:

```bash
dotnet test
```

This will build the project and execute all unit tests discovered in the solution.

---

## 📁 Typical Project Structure

```text
MySolution/
├── MyApp/
│   └── MyApp.csproj
├── MyApp.Tests/
│   └── MyApp.Tests.csproj
└── MySolution.sln
```

Ensure your test project references the main project using:

```bash
dotnet add MyApp.Tests/MyApp.Tests.csproj reference MyApp/MyApp.csproj
```

---

## ℹ️ Resources

- [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [xUnit](https://xunit.net/)
- [MSTest](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)
- [NUnit](https://nunit.org/)
