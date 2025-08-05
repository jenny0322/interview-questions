# Test Execution (Java)

To run the Java unit tests in this project, ensure the following prerequisites are installed and properly configured.

---

## 1. Java Development Kit (JDK)

- **Required**: JDK 8 or higher  
- **Check if installed**:
  ```bash
  java -version
  javac -version
  ```

- **Install if missing**:
  - **macOS**:
    ```bash
    brew install openjdk
    ```
  - **Windows**:  
    Download and install from [Oracle Java Downloads](https://www.oracle.com/java/technologies/javase-downloads.html) or [Adoptium](https://adoptium.net/)
  - **Linux**:
    ```bash
    sudo apt install openjdk-17-jdk
    ```

---

## 2. Apache Maven

- **Required**: Maven 3.6+ recommended  
- **Check if installed**:
  ```bash
  mvn -version
  ```

- **Install if missing**:
  - **macOS**:
    ```bash
    brew install maven
    ```
  - **Windows/Linux**:  
    Download from [Apache Maven Downloads](https://maven.apache.org/download.cgi) and follow the installation instructions.

---

## 3. Running the Tests

Navigate to the project root (where `pom.xml` is located) and run:

```bash
mvn test
```

This will compile the code and execute all tests located in `src/test/java`.

---

## 📁 Typical Project Structure

```text
my-java-project/
├── pom.xml
└── src/
    ├── main/
    │   └── java/
    │       └── com/example/
    │           └── MyClass.java
    └── test/
        └── java/
            └── com/example/
                └── MyClassTest.java
```

Ensure your test classes follow standard naming conventions like `*Test.java` and include appropriate test annotations (`@Test` for JUnit).

---

## ℹ️ Resources

- [Java Documentation](https://docs.oracle.com/en/java/)
- [Apache Maven](https://maven.apache.org/)
- [JUnit 5 Documentation](https://junit.org/junit5/)
