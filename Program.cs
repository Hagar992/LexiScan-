using System;
using System.Collections.Generic;

class TopDownParser
{
    private static Dictionary<string, List<string>> grammarRules = new Dictionary<string, List<string>>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dynamic Top-Down Parser for Simple Grammars!\n");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Enter Grammar Rules");
            Console.WriteLine("2. Check if Grammar is Simple");
            Console.WriteLine("3. Test a Sequence for Acceptance");
            Console.WriteLine("4. Exit");

            Console.Write("\nYour Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EnterGrammar();
                    break;
                case "2":
                    CheckSimpleGrammar();
                    break;
                case "3":
                    TestSequence();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    break;
            }
        }
    }

    static void EnterGrammar()
    {
        grammarRules.Clear();
        Console.WriteLine("\nEnter the grammar rules. (e.g., S -> aA)");
        Console.WriteLine("To stop entering rules, press Enter without typing anything.");

        while (true)
        {
            Console.Write("Enter Rule: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            string[] parts = input.Split("->");

            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid format. Use 'NonTerminal -> TerminalString'. Try again.");
                continue;
            }

            string nonTerminal = parts[0].Trim();
            string rule = parts[1].Trim();

            if (!grammarRules.ContainsKey(nonTerminal))
            {
                grammarRules[nonTerminal] = new List<string>();
            }

            grammarRules[nonTerminal].Add(rule);
        }

        Console.WriteLine("\nGrammar successfully entered!");
    }

    static void CheckSimpleGrammar()
    {
        Console.WriteLine("\nChecking if the grammar is Simple...");

        foreach (var entry in grammarRules)
        {
            var rules = entry.Value;
            HashSet<char> startingTerminals = new HashSet<char>();

            foreach (var rule in rules)
            {
                if (rule.Length == 0 || !char.IsLower(rule[0]))
                {
                    Console.WriteLine($"Grammar is NOT Simple: Rule '{entry.Key} -> {rule}' does not start with a terminal.");
                    return;
                }

                if (!startingTerminals.Add(rule[0]))
                {
                    Console.WriteLine($"Grammar is NOT Simple: Rules for '{entry.Key}' start with the same terminal '{rule[0]}'.");
                    return;
                }
            }
        }

        Console.WriteLine("Grammar is Simple!");
    }

    static void TestSequence()
    {
        if (grammarRules.Count == 0)
        {
            Console.WriteLine("No grammar rules entered. Please enter rules first.");
            return;
        }

        Console.Write("\nEnter a sequence to test: ");
        string sequence = Console.ReadLine();

        Console.Write("Enter the starting Non-terminal: ");
        string startSymbol = Console.ReadLine();

        if (string.IsNullOrEmpty(sequence) || string.IsNullOrEmpty(startSymbol))
        {
            Console.WriteLine("Invalid input. Sequence and starting Non-terminal cannot be empty.");
            return;
        }

        if (!grammarRules.ContainsKey(startSymbol))
        {
            Console.WriteLine($"Non-terminal '{startSymbol}' not found in the grammar.");
            return;
        }

        if (ParseSequence(sequence, startSymbol))
        {
            Console.WriteLine("The sequence is ACCEPTED.");
        }
        else
        {
            Console.WriteLine("The sequence is REJECTED.");
        }
    }

    static bool ParseSequence(string sequence, string currentNonTerminal)
    {
        if (sequence.Length == 0) return false;

        foreach (var rule in grammarRules[currentNonTerminal])
        {
            if (sequence.StartsWith(rule))
            {
                string remainingSequence = sequence.Substring(rule.Length);
                if (string.IsNullOrEmpty(remainingSequence)) return true;
            }
        }

        return false;
    }
}
