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

        public static string ReverseWords2(string input)                    //O(n3)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException();
            var a = input.Split(null as char[], StringSplitOptions.None);   //First
            Array.Reverse(a);                                               //Second
            return string.Concat(a);                                        //Third
        }
    }
}
