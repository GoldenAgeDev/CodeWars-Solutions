/*
In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Example:

highAndLow("1 2 3 4 5")  // return "5 1"
highAndLow("1 2 -3 4 5") // return "5 -3"
highAndLow("1 9 3 4 -5") // return "9 -5"

Notes:

    All numbers are valid Int32, no need to validate them.
    There will always be at least one number in the input string.
    Output string must be two numbers separated by a single space, and highest number is first.
*/

import java.util.Arrays;
import java.util.Collections;

public class Kata {
  public static String highAndLow(String numbers) {
    
    String[] stringArray = numbers.split(" "); 
    Integer[] intArray = new Integer[stringArray.length];
  
    for(int i = 0; i < stringArray.length;i++)
    {
       intArray[i] = Integer.parseInt(stringArray[i]);
    }
    
    int lowest = Collections.min(Arrays.asList(intArray));
    int highest = Collections.max(Arrays.asList(intArray));
  
    return highest + " " + lowest;
  }
}
