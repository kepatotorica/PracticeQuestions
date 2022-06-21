//https://leetcode.com/problems/longest-substring-without-repeating-characters/
public class LongestSubstringWithoutRepeatingCharacters
{
  public int LengthOfLongestSubstring(string s)
  {
    IEnumerable<char> runningList = new List<char>();
    var maxLength = 0;
    foreach (char c in s)
    {
      var inListIndex = runningList.ToList().IndexOf(c);
      if (runningList.Count() > 95)
      {
        ;
      }
      if (inListIndex != -1)
      {
        maxLength = maxLength > runningList.Count() ? maxLength : runningList.Count();
        runningList = runningList.Skip(inListIndex + 1);
      }
      runningList = runningList.Append(c).ToList();
    }

    return runningList.Count() > maxLength ? runningList.Count() : maxLength;
  }
}