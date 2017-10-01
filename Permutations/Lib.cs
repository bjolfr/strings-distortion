using System;

namespace Permutations
{
    public static class Lib
    {
        public static string FindPattern(string pattern, string text)//O(n4)
        {
            int match = 0;
            for (int i = 0; i < text.Length - (pattern.Length - 1) && match != pattern.Length; i++, match = pattern.Length == match ? match : 0)
                for (int j = 0; j < pattern.Length; j++)
                    if (pattern[j] == text[i])
                        for (int i1 = i; i1 < i + pattern.Length; i1++)
                            for (int j1 = 0; j1 < pattern.Length; j1++)
                                if (text[i1] == pattern[j1]) { match++; break; }
            return match >= pattern.Length ? "YES" : "NO";
        }

        public static string CalcPattern(string pattern, string text) //O(2n2)
        {
            int p = 0, m = 0;
            foreach (var s in pattern) p += Convert.ToByte(s);
            for (int i = 0; i < text.Length - (pattern.Length - 1) && p != m; i++, m = p == m ? m : 0)
                for (int j = i; j < i + pattern.Length; j++)
                    m += Convert.ToByte(text[j]);
            return p == m ? "YES" : "NO";
        }
    }
}
