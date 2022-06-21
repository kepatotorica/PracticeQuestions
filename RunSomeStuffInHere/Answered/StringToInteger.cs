//https://leetcode.com/problems/string-to-integer-atoi/

using System.Text.RegularExpressions;

public class StringToInteger //Not done yet, I need to go throuhg 1 by one instead of trying to parse. It will be easier to find letters inbetween
{
  public int MyAtoi(string s)
  {
    var firstNumberMatch = Regex.Match(s, "[0-9]");
    var firstAlphaMatch = Regex.Match(s, "[a-zA-Z]");
    var negativeMatch = s.IndexOf('-');
    var positiveMatch = s.IndexOf('+');
    if (!firstNumberMatch.Success ||
      (firstAlphaMatch.Success && firstNumberMatch.Index > firstAlphaMatch.Index) ||
      (negativeMatch != -1 && positiveMatch != -1) ||
      (positiveMatch > firstNumberMatch.Index) ||
      (negativeMatch > firstNumberMatch.Index)
      )
    {
      return 0;
    }

    s = Regex.Replace(s, "[^0-9.]", "");

    var decimalIndex = s.IndexOf(".");
    if (decimalIndex != -1)
    {
      s = s.Substring(0, decimalIndex);
    }

    if (s.Length == 0)
    {
      return 0;
    }

    if (int.TryParse(s, out var finalNumber))
      return negativeMatch != -1 ? finalNumber * -1 : finalNumber;

    return negativeMatch != -1 ? int.MinValue : int.MaxValue;
  }
}