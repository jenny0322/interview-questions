# Test Execution (Python)

To run the Python unit tests in this project, ensure the following prerequisites are installed and properly configured.

---

## 1. Python

- **Required**: Python 3.8 or higher
- **Check if installed**:
  ```bash
  python --version
  ```
  or
  ```bash
  python3 --version
  ```

- **Install if missing**:
  - **macOS** (with Homebrew):
    ```bash
    brew install python
    ```
  - **Windows/Linux**:
    Download and install from: [https://www.python.org/downloads/](https://www.python.org/downloads/)

---

## 2. Install Dependencies

If your project uses a `requirements.txt` file, install dependencies using:

```bash
pip install -r requirements.txt
```

If you're using `pytest` (recommended), install it with:

```bash
pip install pytest
```

---

## 3. Running the Tests

Navigate to the root of the project and run:

```bash
pytest
```

This will automatically discover and run all test files named `test_*.py` or `*_test.py`.

To run a specific test file:

```bash
pytest tests/test_example.py
```

---

## 📁 Typical Project Structure

```text
my-python-project/
├── main.py
├── requirements.txt
└── tests/
    ├── __init__.py
    └── test_main.py
```

Make sure test files are inside a `tests/` folder and follow the naming conventions.

---

## ℹ️ Resources

- [Python Documentation](https://docs.python.org/3/)
- [pytest Documentation](https://docs.pytest.org/)
- [unittest Documentation](https://docs.python.org/3/library/unittest.html)
