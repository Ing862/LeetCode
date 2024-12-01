using System;

public class Solution
{
	public char FindTheDifference(string s, string t)
	{
		char[] stringS;
		stringS = new char[s.Length];
		char[] stringT;
		stringT = new char[t.Length];

		int i = 0;

		for (i = 0; i < s.Length; i++)
		{
			stringS[i] = s[i];
			stringT[i] = t[i];
		}
		stringT[t.Length - 1] = t[t.Length - 1];

		Array.Sort(stringS);
		Array.Sort(stringT);

		for (i = 0; i < stringS.Length; i++)
		{
			if (stringS[i] != stringT[i])
			{
				return stringT[i];
			}
		}

		return stringT[stringT.Length - 1];
	}
}

public class Program
{
	public static void Main()
	{
		string s = "abcde";
		string t = "dcqabe";

		Solution solution = new Solution();

		Console.WriteLine(solution.FindTheDifference(s, t));
	}
}