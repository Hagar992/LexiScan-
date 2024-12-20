using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScannerProject
{
    public class Lexer
    {
        private readonly string _input;
        private int _position;

      private static readonly List<(string Type, string Pattern)> TokenPatterns = new List<(string, string)>
        {
            ("KEYWORD", @"\b(for|if|while|do|return|int|float|double|char|bool|count)\b"),
            ("IDENTIFIER", @"\b[a-zA-Z_][a-zA-Z0-9_]*\b"),
            ("COMMENT", @"//.*"), 
            ("NUMERIC_CONSTANT", @"\b[-+]?\d+(\.\d+)?([eE][-+]?\d+)?\b"), 
            ("OPERATOR", @"[<>!=+\-*/%]"),
            ("SPECIAL_CHARACTER", @"[(){}[\];]"),
            ("WHITESPACE", @"\s+") 
        };

        public Lexer(string input)
        {
            _input = input;
            _position = 0;
        }

      public Token? GetNextToken()
        {
            if (_position >= _input.Length) return null;

            while (_position < _input.Length)
            {
                
                if (char.IsWhiteSpace(_input[_position]))
                {
                    _position++;
                    continue;
                }

                Console.WriteLine($"Processing character: '{_input[_position]}' at position {_position}");


                foreach (var (type, pattern) in TokenPatterns)
                {
                    var regex = new Regex($"^{pattern}");
                    var match = regex.Match(_input.Substring(_position));
                    if (match.Success)
                    {
                        _position += match.Length;

                        if (type == "WHITESPACE") continue;

                        return new Token(type, match.Value);
                    }
                }

                var unexpectedChar = _input[_position];
                _position++;
                return new Token("UNKNOWN", unexpectedChar.ToString());
            }

            return null;
        }
        public List<Token> Tokenize()
        {
            var tokens = new List<Token>();
            Token? token;
            while ((token = GetNextToken()) != null)
            {
                tokens.Add(token);
            }
            return tokens;
        }
    }
    
}