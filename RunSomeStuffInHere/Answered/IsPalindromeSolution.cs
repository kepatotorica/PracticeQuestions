//https://leetcode.com/problems/palindrome-number/submissions/
public class IsPalindromeSolution
{
  public bool IsPalindrome(int x)
  {
    if (x < 0) return false;

    var stringInt = x.ToString();
    var length = stringInt.Length;
    if (length <= 1) return true;

    for (int i = 0; i < length / 2; i++)
    {
      if (stringInt[i] != stringInt[length - 1 - i]) return false;
    }

    return true;
  }
}