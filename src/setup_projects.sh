#!/bin/bash

# Define project name
project_name="ValidateBrackets"

# Create base directory
mkdir "$project_name"
cd "$project_name"

# C# Project
mkdir csharp
cd csharp
dotnet new sln -n ValidBrackets
dotnet new classlib -n ValidBracketsLib
dotnet new xunit -n ValidBracketsTests
dotnet sln add ValidBracketsLib
dotnet sln add ValidBracketsTests
dotnet add ValidBracketsTests reference ValidBracketsLib
cd ..

# Java Project
mkdir java
cd java
mkdir -p src/main/java/com/validatebrackets
mkdir -p src/test/java/com/validatebrackets
cd src/main/java/com/validatebrackets
echo "public class Solution { }" > Solution.java
cd ../../../../test/java/com/validatebrackets
echo "import static org.junit.Assert.*;
import org.junit.Test;
public class SolutionTest { @Test public void testBracket() { } }" > SolutionTest.java
cd ../../../../..
echo "<project>
  <modelVersion>4.0.0</modelVersion>
  <groupId>com.validatebrackets</groupId>
  <artifactId>validate-brackets</artifactId>
  <version>1.0</version>
  <dependencies>
    <dependency>
      <groupId>junit</groupId>
      <artifactId>junit</artifactId>
      <version>4.12</version>
      <scope>test</scope>
    </dependency>
  </dependencies>
</project>" > pom.xml
cd ..

# Python Project
mkdir python
cd python
echo "class Solution: pass" > solution.py
echo "import pytest
def test_brackets(): pass" > test_solution.py
cd ..

# Node.js Project
mkdir node
cd node
npm init -y
npm install --save-dev jest
echo "const solution = require('./solution');
test('bracket validation', () => { });" > test.js
echo "module.exports = class Solution { };" > solution.js
echo "{
  \"scripts\": {
    \"test\": \"jest\"
  }
}" > package.json
cd ..

# Golang Project
mkdir golang
cd golang
mkdir -p src/solution
echo "package solution
// IsValid function definition here" > src/solution/solution.go
echo "package solution_test
import (
    \"testing\"
    \"solution\"
)
func TestIsValid(t *testing.T) {
    // test cases here
}" > src/solution/solution_test.go
cd ..

# Back to root directory
cd ..

# Make scripts executable
chmod +x csharp/*.sh
chmod +x java/*.sh
chmod +x python/*.sh
chmod +x node/*.sh
chmod +x golang/*.sh

echo "Project setup completed."

