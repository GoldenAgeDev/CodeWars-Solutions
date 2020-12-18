/* Return the number (count) of vowels in the given string.
 * We will consider a, e, i, o, u as vowels for this Kata (but not y).
 * The input string will only consist of lower case letters and/or spaces.
 */
 
using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char c in str)
        {
          switch (c)
           {
               case 'a':
                   vowelCount++;
                   break;
               case 'e':
                   vowelCount++;
                    break;
               case 'i':
                   vowelCount++;
                   break;
               case 'o':
                   vowelCount++;
                   break;
               case 'u':
                   vowelCount++;
                   break;
               default:
                   break;
            }  
        }

        return vowelCount;
    }
}
