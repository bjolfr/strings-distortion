namespace Lib.Standard
{
    public static class Numbers
    {
        public static int[] DoubleArrayOfSameElements(int[] input) 
        {
            for (int i = 0; i < input.Length; i++) {
                if (i < input.Length - 1 && input[i] == input[i + 1])
                    doubleAndNull(ref input[i], ref input[i + 1]);
                bubbleNumber(i);
            }
            return input;

            void doubleAndNull(ref int prev, ref int next) {
                if (prev == 0) return;
                prev += next; next = 0;
            }
            
            void bubbleNumber(int idx) {
                if (idx == 0) return;
                for (int i = idx - 1; i > 0; i--) {
                    if (input[i - 1] == 0) continue;
                    if (input[i] != 0) return;
                    Swap(ref input[i], ref input[idx]); }
            }
        }

        public static void Swap(ref int prev, ref int next) { prev ^= next; next ^= prev; prev ^= next; }
    }
}
