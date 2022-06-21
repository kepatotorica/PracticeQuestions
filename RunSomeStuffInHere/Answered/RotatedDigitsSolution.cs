public class RotatedDigitsSolution
{
  public List<char> rotateableNumbers = new List<char> { '2', '5', '6', '9' };
  public List<char> selfRotateNumbers = new List<char> { '0', '1', '8' };
  public List<char> nonRotatingNumbers = new List<char> { '3', '4', '7', };

  public int RotatedDigits(int n)
  {
    var rotations = 0;
    for (int i = 1; i <= n; i++)
    {
      var numString = i.ToString();
      var nonRotating = numString.Intersect(nonRotatingNumbers).Any();
      var rotateable = numString.Intersect(rotateableNumbers).Any();
      if (nonRotating)
      {
        rotations--;
      };
      if (!nonRotating && !rotateable)
      {
        rotations--;
      };
      rotations++;
    }
    return rotations;
  }
}