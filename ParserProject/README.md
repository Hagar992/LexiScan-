# ParserProject

# Dynamic Top-Down Parser for Simple Grammars

## Overview
This project is a **Dynamic Top-Down Parser** implemented in C#. It provides functionality to parse and validate sequences based on user-defined grammar rules. It also checks whether a grammar is considered "simple" according to specific rules and allows users to test sequences for acceptance.

## Features
- **Enter Grammar Rules**: Input custom grammar rules interactively.
- **Check Simple Grammar**: Verify if the entered grammar qualifies as a "simple" grammar.
- **Test Sequence**: Evaluate whether a given sequence is accepted by the defined grammar.
- **User-Friendly Interface**: Provides an interactive menu-driven command-line interface.

## How It Works
### Grammar Rules
- Rules are entered in the format `NonTerminal -> TerminalString`.
- For example: `S -> aA` or `A -> bB`.

### Simple Grammar Validation
A grammar is considered "simple" if:
1. Every rule starts with a terminal (lowercase letter).
2. No two rules for the same non-terminal start with the same terminal.

### Sequence Testing
The program determines whether a sequence can be derived starting from a specified non-terminal using the defined grammar rules.

## Requirements
- **.NET SDK 8.0** or later
- Compatible operating system (Windows, macOS, Linux)

## Installation
1. Open a terminal or PowerShell.
2. Clone this repository or create a folder for the project.
3. Navigate to the project directory.
4. Run the following commands:
   ```bash
   dotnet build
   dotnet run
   ```

## Usage
1. Launch the program using `dotnet run`.
2. Use the interactive menu to:
   - Enter grammar rules.
   - Check if the grammar is simple.
   - Test sequences for acceptance.

### Example
#### Input Grammar:
```
S -> aA
A -> b
A -> c
```
#### Check Grammar:
```
Output: Grammar is Simple!
```
#### Test Sequence:
- Sequence: `ab`
- Starting Non-terminal: `S`
```
Output: The sequence is ACCEPTED.
```

## Code Structure
- **Main Program**: Displays the menu and handles user input.
- **EnterGrammar()**: Allows the user to input grammar rules.
- **CheckSimpleGrammar()**: Verifies if the grammar is simple.
- **TestSequence()**: Tests whether a given sequence is valid based on the grammar rules.
- **ParseSequence()**: Internal recursive method for sequence validation.

## Future Enhancements
- Support for more complex grammars (e.g., context-free grammars).
- Enhanced error handling and input validation.
- Visualization of grammar derivations.

## Author
Shams A.

## License
This project is open-source and available under the MIT License.

