//https://leetcode.com/problems/longest-consecutive-sequence/
public class Solution
{
  public int LongestConsecutive(int[] nums)
  {
    var ordered = nums.OrderBy(i => i).Distinct();

    var longestRun = 0;
    var currentRun = 0;
    int? lastValue = null;
    foreach (var item in ordered)
    {
      if (item - lastValue == 1 || lastValue == null)
      {
        currentRun++;
      }
      else if (item - lastValue != 1)
      {
        currentRun = 1;
      }
      if (currentRun > longestRun)
      {
        longestRun = currentRun;
      }
      lastValue = item;
    }
    return longestRun;
  }
}