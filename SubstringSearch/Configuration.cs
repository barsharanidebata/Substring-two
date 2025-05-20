using System;


public class StringSearcher
{
    /// <summary>
    /// Check the second string is part of first string or not then return the appear time and index position.
    /// </summary>
    /// <param name="text">The main string to search within.</param>
    /// <param name="sub">The substring to search for.</param>
    public void FindSubstrings(string text, string sub)
    {

        int matchesIndex;
        int count = 0;
        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            bool match = true;

            for (int j = 0; j < sub.Length; j++)
            {
                if (text[i + j] != sub[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                matchesIndex = i;
                Console.WriteLine($"Matches Index Position is: {matchesIndex}");
                count++;
                i += sub.Length - 1;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"'{sub}' matches {count} times in '{text}'.");
        }
        else
        {
            Console.WriteLine($"'{sub}' is not found in '{text}'.");
        }
    }
}