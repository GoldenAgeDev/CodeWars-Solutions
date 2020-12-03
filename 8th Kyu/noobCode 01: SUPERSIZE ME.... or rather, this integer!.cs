/* Write a function that rearranges an integer into its largest possible value.
 *
 * Kata.SuperSize(123456) //654321
 * Kata.SuperSize(105) // 510
 * Kata.SuperSize(12) // 21
 */
 
using System;
using System.Linq;

public class Kata
{
  public static long SuperSize(long num)
  {
    return long.Parse(String.Concat(num.ToString().OrderByDescending(x => x)));
  }
}
