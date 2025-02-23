# Personal LeetCode & Programming Practice Repository

This repository is dedicated to my personal practice of solving LeetCode problems and various programming challenges using a Test-Driven Development (TDD) approach. The solutions are implemented in **C# 9.0** and **Java 18**.

## Overview

- **Languages:** C# 9.0, Java 18
- **Approach:** Test-Driven Development (TDD)
- **Purpose:** To improve problem-solving skills, experiment with TDD practices, and document solutions for future reference.

## Repository Structure

- **LeetCodeSolutions/**  
  Contains all C# solutions and corresponding tests.  
  Each problem typically has its own folder with:
  - Source code files
  - Unit tests

- **JavaLeetCode/**  
  Contains all Java solutions and corresponding tests.  
  Each problem typically has its own folder with:
  - Source code files
  - Unit tests (using JUnit or your preferred testing framework)

- **README.md**  
  This file provides an overview of the repository.

## Getting Started

### Prerequisites

- **For C#:**
  - [.NET 5+ SDK](https://dotnet.microsoft.com/download)
  - IDE: [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)
  
- **For Java:**
  - [JDK 18](https://www.oracle.com/java/technologies/javase/jdk18-archive-downloads.html) or later
  - Build tools such as [Maven](https://maven.apache.org/) or [Gradle](https://gradle.org/)
  - IDE: [IntelliJ IDEA](https://www.jetbrains.com/idea/)

### Running Tests

#### C# Solutions

1. Navigate to the specific problem directory within the `LeetCodeSolutions/` folder.
2. Run the tests using the .NET CLI:
   ```bash
   dotnet test
   
## Java Solutions

- **Navigate** to the specific problem directory within the `JavaLeetCode/` folder.
- **Run tests** using your preferred build tool:
  - **Maven:**
    ```bash
    mvn test
    ```
  - **Gradle:**
    ```bash
    gradle test
    ```

## TDD Workflow

For each problem, the following TDD cycle is followed:

1. **Write a Failing Test:**  
   Define the expected behavior by writing tests first.
2. **Implement the Code:**  
   Write the minimal code needed to pass the tests.
3. **Refactor:**  
   Clean up the code while ensuring that all tests continue to pass.

This cycle helps ensure that the solution is both correct and maintainable.

## Contribution

This repository is primarily for personal learning and practice. However, if you have suggestions or improvements, feel free to fork the repository, submit a pull request, or open an issue.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
