//https://leetcode.com/problems/furthest-building-you-can-reach/

public class FurthestBuildingSolution
{
  public int FurthestBuilding(int[] heights, int bricks, int ladders)
  {
    var buildingsJumped = 0;
    var sortedList = new List<int>();
    for (int i = 0; i <= heights.Length - 2; i++)// -2 don't want to get out of the array
    {
      var gapSize = heights[i + 1] - heights[i];
      sortedList.Add(gapSize > 0 ? gapSize : 0);
      sortedList = sortedList.OrderBy(_ => _).ToList();
      if (i >= ladders)
      {
        var traversable = sortedList.Take(sortedList.Count - ladders);
        if (traversable.Sum() > bricks) break;
      }
      buildingsJumped++;
    }
    return buildingsJumped > heights.Length ? heights.Length : buildingsJumped;
  }
}