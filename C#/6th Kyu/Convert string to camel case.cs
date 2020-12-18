/* Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).
 * Examples
 * 
 * Kata.ToCamelCase("the-stealth-warrior") // returns "theStealthWarrior"
 * 
 * Kata.ToCamelCase("The_Stealth_Warrior") // returns "TheStealthWarrior"
 */
 
using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    char[] delimiters = { '-', '_' };

    string[] words = str.Split(delimiters);

    str = words[0];

    for (int i = 1; i < words.Length; i++)
    {
        string word = char.ToUpper(words[i][0]) + words[i].Substring(1);
        str += word;
    }

    return str;
  }
}
