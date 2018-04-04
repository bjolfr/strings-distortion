using System;
using System.Linq;
using System.Text;

namespace Lib.Standart.Strings
{
    public static class Strings
    {
        public static string WordsDescent(string input)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException();
            var a = input.Split(' ');
            //string[] r = { };
            //var r = Enumerable.Repeat(string.Empty, a.Length);
            //var sb = new StringBuilder(a.Length); //sb.Append(a[i]); sb.ToString()
            var r = string.Empty;
            for (int i = a.Length; i >= 0; i--)
                r += $"{a[i]} ";
            return r;
        }
    }
}
