# Test Execution (Go)

To run the Go unit tests in this project, ensure the following prerequisites are installed and properly configured.

---

## 1. Go (Golang)

- **Required**: Go 1.18 or higher
- **Check if installed**:
  ```bash
  go version
  ```

- **Install if missing**:
  - **macOS** (using Homebrew):
    ```bash
    brew install go
    ```
  - **Windows/Linux**:
    Download and install from the official site: [https://go.dev/dl/](https://go.dev/dl/)

---

## 2. Running the Tests

Navigate to the root directory of the Go module (where `go.mod` is located) and run:

```bash
go test ./...
```

This command will recursively run all tests in the module.

---

## 📁 Typical Project Structure

```text
my-go-project/
├── go.mod
├── main.go
└── mypackage/
    ├── mycode.go
    └── mycode_test.go
```

Make sure your test files follow the `*_test.go` naming convention and use Go’s built-in `testing` package.

---

## ℹ️ Resources

- [Go Documentation](https://golang.org/doc/)
- [Testing in Go](https://golang.org/pkg/testing/)
