namespace LeetCode;

public class _389_FindTheDifference
{
  /*
  At first glance it looks bizzare. We actually need to use the ASCII value of the characters to help us find the difference.

  We have a initial result of 0. 
  
  We XOR the result with the first string which will give us some arbitary values. Next we will XOR it with the second string. 
  
  From the constraints, s.length = t.length + 1. And if we XOR a variable with the same string twice, it will go back to it's original value.

  Hence, after we XOR the result with the second string, it should convert to the character that has been leftover.
   */
  public int[] FindTheDifference(string s, string t)
  {
    int result = 0;

    foreach (char sChar in s) result ^= sChar;
    foreach (char tChar in t) result ^= tChar;

    return (char)result;
  }
}
