/* Return the century of the input year. The input will always be a 4 digit string, so there is no need for validation.
 * Examples
 * 
 * "1999" --> "20th"
 * "2011" --> "21st"
 * "2154" --> "22nd"
 * "2259" --> "23rd"
 * "1124" --> "12th"
 * "2000" --> "20th"
 */
 
public class Kata
{
  public static string WhatCentury(string year)
  {
    // Utilized this block due to testing of strings with <4 digits
    if (year.Length == 1)
    {
        year = "000" + year;
    }
    if (year.Length == 2)
    {
        year = "00" + year;
    }
    if (year.Length == 3)
    {
        year = "0" + year;
    }
    //
    
    int yearInt = int.Parse(year);
    int cenInt = int.Parse(year.Substring(0, 2));
    if (year.Substring(2, 2) != "00")
    {
        cenInt += 1;
    }

    switch (yearInt % 1000)
    {
        case 0:
            return cenInt + "th";
    }

    switch (cenInt % 100)
    {
        case 10:
        case 11:
        case 12:
        case 13:
            return cenInt + "th";
    }

    switch (cenInt % 10)
    {
        case 1:
            return cenInt + "st";
        case 2:
            return cenInt + "nd";
        case 3:
            return cenInt + "rd";
        default:
            return cenInt + "th";
    }
  }
}
