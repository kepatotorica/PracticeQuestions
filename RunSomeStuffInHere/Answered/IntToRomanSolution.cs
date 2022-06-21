public class IntToRomanSolution
{
  public string IntToRoman(int num)
  {
    var numerals = new List<RomanNumeral>()  {
      new RomanNumeral { Roman ="M",  Value = 1000},
      new RomanNumeral { Roman ="CM",  Value = 900},
      new RomanNumeral { Roman ="D",  Value = 500},
      new RomanNumeral { Roman ="CD",  Value = 400},
      new RomanNumeral { Roman ="C",  Value = 100},
      new RomanNumeral { Roman ="XC",  Value = 90},
      new RomanNumeral { Roman ="L",  Value = 50},
      new RomanNumeral { Roman ="XL",  Value = 40},
      new RomanNumeral { Roman ="X",  Value = 10},
      new RomanNumeral { Roman ="IX",  Value = 9},
      new RomanNumeral { Roman ="V",  Value = 5},
      new RomanNumeral { Roman ="IV",  Value = 4},
      new RomanNumeral { Roman ="I",  Value = 1},
    };

    var leftOver = num;
    var currentRomanNumeral = "";
    foreach (var numeral in numerals)
    {
      var numberOfNumerals = leftOver / numeral.Value;
      for (int i = 0; i < numberOfNumerals; i++)
      {
        currentRomanNumeral += numeral.Roman;
      }
      leftOver %= numeral.Value;
    }
    return currentRomanNumeral;
  }
}

public class RomanNumeral
{
  public int Value { get; set; }
  public string? Roman { get; set; }
}