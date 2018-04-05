using System.Collections.Generic;

namespace Lib.Standard.Test.Helpers
{
    public class ArrayComparer<T> : IEqualityComparer<T[]>
    {
        public bool Equals(T[] x, T[] y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x?.Length == y.Length) {
                for (int i = 0; i < x.Length; i++)
                    if (!Equals(x[i], y[i]))
                        return false;
                return true; }
            return false;
        }

        public int GetHashCode(T[] array)
        {
            if (array == null) return 0;
            unchecked {
                int hash = 17;
                foreach (var item in array)
                    hash = hash * 23 + (item?.GetHashCode()).GetValueOrDefault();
                return hash; }
        }
    }
}
