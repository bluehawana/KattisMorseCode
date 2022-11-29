// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace KattisProblemA
{
    internal class Program
    {
        private static Dictionary<char, string> MorseDic { get; } = new Dictionary<char, string>()
        { 
          
        {'a', ".-"},
        {'b', "-..."},
        {'c', "-.-."},
        {'d', "-.."},
        {'e', "."},
        {'f', "..-."},
        {'g', "--."},
        {'h', "...."},
        {'i', ".."},
        {'j', ".---"},
        {'k', "-.-"},
        {'l', ".-.."},
        {'m', "--"},
        {'n', "-."},
        {'o', "---"},
        {'p', ".--."},
        {'q', "--.-"},
        {'r', ".-."},
        {'s', "..."},
        {'t', "-"},
        {'u', "..-"},
        {'v', "...-"},
        {'w', ".--"},
        {'x', "-..-"},
        {'y', "-.--"},
        {'z', "--.."},
        {'0', "-----"},
        {'1', ".----"},
        {'2', "..---"},
        {'3', "...--"},
        {'4', "....-"},
        {'5', "....."},
        {'6', "-...."},
        {'7', "--..."},
        {'8', "---.."},
        {'9', "----."}
    };

            static void Main()
            {
                var userInput = GetUserInput();
                if (IsValidMorse(userInput))
                {
                    Console.WriteLine(Translate(userInput) + "is a MorseCodePalindrome");
                }
                else
                {
                    Console.WriteLine(Translate(userInput) + "is not a MorseCodePalindrome");
                }
                Console.WriteLine("[Press ANY KEY to exit]");
                Console.ReadLine();
            }

            private static string GetUserInput()
            {
                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    input = input.ToLower();
                }
                return input ?? "";
            }

            private static string Translate(string input)
            {
                var stringBuilder = new StringBuilder();

                foreach (var c in input)
                {
                    if (MorseDic.TryGetValue(c, out var v))
                    {
                        stringBuilder.Append(v);
                    }
                }
                return stringBuilder.ToString();
            }

            static bool IsValidMorse(string input)
            {
                var morse = Translate(input);

                var result = string.Join("", morse.Reverse());

                return morse == result;
            }
        }
    }
   