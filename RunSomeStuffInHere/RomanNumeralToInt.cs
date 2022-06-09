public class RomanNumeralToInt
{
    public Dictionary<char, int> numerals = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

    public Dictionary<string, int> subtractors = new Dictionary<string, int>()
        {
            {"IV", 2},
            {"IX", 2},
            {"XL", 20},
            {"XC", 20},
            {"CD", 200},
            {"CM", 200},
        };

    public int RomanToInt(string romanNumeral)
    {
        var count = 0;
        var previousCharacter = ' ';
        foreach (var character in romanNumeral)
        {
            numerals.TryGetValue(character, out var value);
            if (subtractors.TryGetValue($"{previousCharacter}{character}", out var specialValue))
            {
                count -= specialValue;
            }
            count += value;
            previousCharacter = character;
        }
        return count;
    }
}