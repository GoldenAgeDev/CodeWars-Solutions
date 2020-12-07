/* Create a function called shortcut to remove all the lowercase vowels in a given string.
 * Examples
 * 
 * Shortcut("codewars") # --> cdwrs
 * Shortcut("goodbye")  # --> gdby
 * 
 * Don't worry about uppercase vowels.
 */
 
using System;

public class Kata
{
  public static string Shortcut(string input)
  {
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };  // Vowels as delimiters
    string[] letters = input.Split(vowels);       // Split input string at each vowel

    return input = string.Join("",letters);       // Join the strings together
  }
}
