public class MaxDistToClosestSolution
{
  public int MaxDistToClosest(int[] seats)
  {
    var farLeft = 0;
    var farRight = 0;
    var currentDistance = 0;
    var maxDistance = 0;
    for (int i = 0; i < seats.Count(); i++)
    {
      if (seats[i] == 1)
      {
        farLeft = i + 1;
      }
      if (seats[i] == 0)
      {
        farRight = i;
      }

      if (farLeft == 0 || farRight == seats.Count() - 1)//We are at the boundries
      {
        currentDistance = farRight - farLeft;
      }
      else
      {
        currentDistance = (farRight - farLeft) / 2;
      }

      if (currentDistance > maxDistance)
      {
        maxDistance = currentDistance;
      }

    }

    return maxDistance + 1;
  }
}
