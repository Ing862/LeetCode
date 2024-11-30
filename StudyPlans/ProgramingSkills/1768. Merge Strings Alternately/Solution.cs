using System;

public class Solution
{
	public string MergeAlternately(string word1, string word2)
	{
		string longerWord = "";
		string mergedWords = "";

		if (word1.Length >= word2.Length)
		{
			longerWord = word1;
		}
		else
		{
			longerWord = word2;
		}

		for (int i = 0; i < longerWord.Length; i++)
		{
			if (i < word1.Length)
			{
				mergedWords += word1[i];
			}
			if (i < word2.Length)
			{
				mergedWords += word2[i];
			}
		}

		return mergedWords;
	}
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        string word1 = "abc";
        string word2 = "defgh";

        string result = solution.MergeAlternately(word1, word2);

        Console.WriteLine(result);
    }
}
