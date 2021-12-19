using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Test.BusinessService
{
    public class LongestSequenceService
    {
        public static string InvalidInputString = "Invalid Input";
        public static char[] splitChars = { ' ' };
        public static string GetLongestIncreasingSequence(string inputNumbers)
        {
            var longestIncreasingSequence = new List<int>();
            var splitIntNumberLists = new List<int>();

            var splitStringNumbers = inputNumbers.Split(splitChars).ToList();

            if (splitStringNumbers.Any() && splitStringNumbers.All(n => int.TryParse(n, out int value)))
            {
                splitIntNumberLists = splitStringNumbers.Select(n => int.Parse(n)).ToList();
                var currentSequenceList = new List<int>();

                for (int i = 0; i < splitIntNumberLists.Count; i++)
                {
                    if (currentSequenceList.Count == 0 || splitIntNumberLists[i] - currentSequenceList.Last() > 1)
                    {
                        currentSequenceList.Add(splitIntNumberLists[i]);
                    }
                    else
                    {
                        if (currentSequenceList.Count() > longestIncreasingSequence.Count())
                        {
                            longestIncreasingSequence.Clear();
                            longestIncreasingSequence.AddRange(currentSequenceList);
                        }
                        currentSequenceList.Clear();
                        currentSequenceList.Add(splitIntNumberLists[i]);
                    }
                }

                if (currentSequenceList.Count() > longestIncreasingSequence.Count())
                {
                    longestIncreasingSequence.Clear();
                    longestIncreasingSequence.AddRange(currentSequenceList);
                }
            }


            return longestIncreasingSequence.Count() > 0 ? string.Join(" ", longestIncreasingSequence.Select(c => c)) : InvalidInputString;
        }
    }
}
