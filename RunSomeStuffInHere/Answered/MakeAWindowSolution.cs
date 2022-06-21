//https://leetcode.com/problems/string-to-integer-atoi/

public class MakeAWindowSolution
{
  public string MakeAWindow(int num)
  {
    if (num < 0)
    {
      num = 0;
    }

    var vertical = num * 2 + 3; // num * 2 because it is 2x2, +3 because there are three trim pieces
    var startingString = "".PadLeft(vertical, '-');// get the first set of dashes
    startingString += "\n";
    for (int i = 0; i < num; i++)
    {
      startingString += MakeWindowRung(num, '.', '|');
    }
    startingString += MakeWindowRung(num, '-', '+');
    for (int i = 0; i < num; i++)
    {
      startingString += MakeWindowRung(num, '.', '|');
    }

    return startingString + "".PadRight(vertical, '-');
  }

  public string MakeWindowRung(int num, char filler, char divider)
  {
    return $"|{"".PadLeft(num, filler)}{divider}{"".PadLeft(num, filler)}|\n";
  }
}