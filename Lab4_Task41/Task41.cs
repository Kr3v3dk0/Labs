using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public sealed class Task41
    {

        /// <summary>
        /// Визначити   середнє   арифметичне   максимального   та   третього   мінімального елементів масиву
        /// </summary>

        public static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] arr2 = new int[] { int.MaxValue - 1, 2, 3, 4, 5, 6, 7, 8, 9, int.MaxValue };
            int[] arr3 = new int[] { int.MaxValue, 2, 33, 156, 999, 543, 951, 8, 9, int.MinValue };
        }

        private static double GetAvgOfThirdMinAndMaxArrayElements(int[] array)
        {
            return (GetMaxArrayElement(array) + GetThirdMinArrayElement(array)) / 2;
        }

        private static double GetMaxArrayElement(int[] array)
        {
            int maxEl = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxEl) { maxEl = array[i]; }
            }

            return maxEl;
        }

        private static double GetThirdMinArrayElement(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        // sort array from low to high
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr[2];
        }
    }
}
