using System;
using System.Linq;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        string[] words = str.Split(new char[] { ' ' });
        for (int a = 0; a < words.Length; a++)
        {
            words[a] = new string(words[a].Reverse().ToArray());
        }
        return string.Join(" ", words);
    }
}