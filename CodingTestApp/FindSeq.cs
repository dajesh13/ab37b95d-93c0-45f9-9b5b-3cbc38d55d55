using System.Text.RegularExpressions;

namespace CodingTestApp;

public static class FindSeq
{
    public static string FindLongestSequence(string inputString)
    {
        string outputArray = "";
        if (inputString != null)
        {
            var iparray = inputString.Split(' ');
            if (iparray.All(x=> Regex.IsMatch(x, @"^[0-9]*$")))
            {
                int[] array = Array.ConvertAll(iparray, int.Parse);
                outputArray = FindLongestIncSequence(array);
            }
            else
            return "Please enter digits only!";
        }
        return outputArray;
    }
    private static string FindLongestIncSequence(int[] array)
    {
        List<int> list = new List<int>();
        List<int> longestList = new List<int>();
        int highestCount = 1;
        for (int i = 0; i < array.Length; i++)
        {
            list.Add(array[i]);
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    list.Add(array[j]);
                    i++;
                }
                else
                {
                    break;
                }
                i = j;
            }
            // Compare with in previous lists  
            if (highestCount < list.Count)
            {
                highestCount = list.Count;
                longestList = new List<int>(list);
            }
            list.Clear();

        }
        return string.Join(" ", longestList); ;
    }
}
