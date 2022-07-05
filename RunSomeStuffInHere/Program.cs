int[][] listOfInts = {
  //new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 },
  new int[] {9,1,4,7,3,-1,0,5,8,-1,6 }
};


foreach (var list in listOfInts)
{
  Console.WriteLine(new Solution().LongestConsecutive(list));
}




//INDEX OPERATOR https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#index-from-end-operator-