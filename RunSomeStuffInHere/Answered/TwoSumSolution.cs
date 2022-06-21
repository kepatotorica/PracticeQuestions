public class TwoSumSolution
{
  public int[] TwoSum(int[] nums, int target)
  {

    var sortedNums = GetSortedList(nums);
    var leftPointer = 0;
    var rightPointer = sortedNums.Count - 1;

    for (int i = 0; i < sortedNums.Count; i++)
    {
      var targetValue = sortedNums[leftPointer].Value + sortedNums[rightPointer].Value;
      if (targetValue > target)
      {
        rightPointer--;
      }
      else if (targetValue < target)
      {
        leftPointer++;
      }
      else if (targetValue == target)
      {
        return new int[] { sortedNums[leftPointer].Index, sortedNums[rightPointer].Index };
      }
      else if (rightPointer - leftPointer == 1)
      {
        return new int[] { };
      }
    }

    return new int[] { };
  }

  public List<ValueAndIndex> GetSortedList(int[] nums)
  {
    var sortedList = new List<ValueAndIndex>();
    for (int i = 0; i < nums.Length; i++)
    {
      sortedList.Add(new ValueAndIndex { Index = i, Value = nums[i] });
    }
    return sortedList.OrderBy(element => element.Value).ToList();
  }
}

public class ValueAndIndex
{
  public int Index { get; set; }
  public int Value { get; set; }
}