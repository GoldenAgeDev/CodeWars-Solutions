/* You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
 * 
 * Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. It must return the display text as shown in the examples:
 * 
 * Kata.Likes(new string[0]) => "no one likes this"
 * Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
 * Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
 * Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
 * Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
 * 
 * For 4 or more names, the number in and 2 others simply increases.
 */
 
using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    string str = "";
    string others = (name.Length - 2).ToString();
  
    if (name.Length == 0)
    {
        str = "no one likes this";
    }
  
    else if (name.Length == 1)
    {
        str = String.Format("{0} likes this", name[0]);
    }
    
    else if (name.Length == 2)
    {
        str = String.Format("{0} and {1} like this", name[0], name[1]);
    }
  
    else if (name.Length == 3)
    {
        str = String.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
    }
  
    else if (name.Length > 3)
    {
        str = String.Format("{0}, {1} and {2} others like this", name[0], name[1], others);
    }
  
    return str;
  }
}
