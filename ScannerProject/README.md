# Token 

This project is a simple Token Parser in C#, designed to parse programming expressions and identify tokens such as keywords, identifiers, operators, numbers, and comments.
_____________________________________________________
## Features

- **Token Identification**: Recognizes keywords, identifiers, numeric constants, operators, special characters, and comments.
- **Logging**: Outputs detailed logs to help trace each character’s processing.
- **For Loop Parsing**: Specifically designed to parse and tokenize expressions with a `for` loop.
______________________________________________________
## Usage

To run this parser, simply execute the code and input a programming expression when prompted. The parser will log the tokens it identifies for each character in the expression.
______________________________________________________
### Example Output

Enter an expression:
#### for ( count = 1 ; count = x2 + 3.4e+6 ; count = count + 1 ) //outer loop

Tokens:
- Token Type: KEYWORD, Value: for
- Token Type: SPECIAL_CHARACTER, Value: (
- Token Type: IDENTIFIER, Value: count
- Token Type: OPERATOR, Value: =
- Token Type: NUMERIC_CONSTANT, Value: 1
- Token Type: SPECIAL_CHARACTER, Value: ;
- Token Type: IDENTIFIER, Value: count
- Token Type: OPERATOR, Value: =
- Token Type: IDENTIFIER, Value: x2
- Token Type: OPERATOR, Value: +
- Token Type: NUMERIC_CONSTANT, Value: 3.4e+6
- Token Type: SPECIAL_CHARACTER, Value: ;
- Token Type: IDENTIFIER, Value: count
- Token Type: OPERATOR, Value: =
- Token Type: IDENTIFIER, Value: count
- Token Type: OPERATOR, Value: +
- Token Type: NUMERIC_CONSTANT, Value: 1
- Token Type: SPECIAL_CHARACTER, Value: )
- Token Type: COMMENT, Value: //outer loop


____________________________________________________
### Code Structure

- Main Program: Initializes the parsing process and reads expressions from the user.
- ParseExpression: Parses each character in the expression, identifying the token type and value. It also logs each processing step for easier debugging.

___________________________________________________
### Build and Run the Project:

- Open the project in Visual Studio or any .NET-compatible IDE.
- Run the project.

___________________________________________________
### Run on Command Line (if you prefer CLI):

- dotnet run

____________________________________________________
### Requirements

- .NET 6.0 SDK or later
- Basic understanding of C# programming language

____________________________________________________
### Contributing

- Feel free to open issues or submit pull requests if you would like to contribute to this project.

____________________________________________________
### License

- This project is open-source and available under the MIT License.
