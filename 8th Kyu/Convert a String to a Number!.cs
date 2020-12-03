/* We need a function that can transform a string into a number. What ways of achieving this do you know?
 * 
 * Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.
 * Examples
 * 
 * StringToNumber("1234") == 1234 
 * StringToNumber("605") == 605
 * StringToNumber("1405") == 1405
 * StringToNumber("-7") == -7
 */
 
using System;

public class Kata
{
    public static int StringToNumber(String str) 
    {
      int number = 0;
      int.TryParse(str, out number);
      return number;
    }
}
