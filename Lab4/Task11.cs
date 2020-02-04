using System;

namespace Lab4
{
    public sealed class Task11
    {
        /// <summary>
        /// Find sum of max and min elements of the array
        /// </summary>

        public static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] arr2 = new int[] { int.MaxValue - 1, 2, 3, 4, 5, 6, 7, 8, 9, int.MaxValue };
            int[] arr3 = new int[] { int.MaxValue, 2, 3, 4, 5, 6, 7, 8, 9, int.MinValue };
        }

        private static int GetSumOfMinAndMaxArrayElements(int[] array)
        {
            return GetMaxArrayElement(array) + GetMinArrayElement(array);
        }

        private static int GetMaxArrayElement(int[] array)
        {
            int maxEl = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxEl) { maxEl = array[i]; }
            }

            return maxEl;
        }

        private static int GetMinArrayElement(int[] array)
        {
            int minEl = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minEl) { minEl = array[i]; }
            }

            return minEl;
        }
    }
}
