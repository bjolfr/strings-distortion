using System;
using System.Text.RegularExpressions;

namespace Lib.Standard
{
    public static class Strings
    {
        public static string ReverseWords(string input) //O(n2)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException();
            var a = input.Split();                      //First
            var r = string.Empty;
            for (int i = a.Length - 1; i >= 0; i--)     //Second
                r += a[i] + (i > 0 ? " " : "");
            return r;
        }

        public static string ReverseWords1(string input)        //O(n3)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException();
            var a = input.Split();                              //First
            var sb = new System.Text.StringBuilder(a.Length);
            for (int i = a.Length - 1; i >= 0; i--)             //Second
                sb.Append(a[i] + (i > 0 ? " " : ""));
            return sb.ToString();                               //Third
        }

        public static char[] ReverseCharArray(char[] input)
        {
            for (int i = 0, j = input.Length - 1; i < input.Length && i < j; i++, j--) {
                input[i] ^= input[j];
                input[j] ^= input[i];
                input[i] ^= input[j]; }
            return input;
        }
    }
}
