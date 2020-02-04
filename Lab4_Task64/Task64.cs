using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public sealed class Task64
    {
        /// <summary>
        /// Задано масив цілих чисел. Сформувати новий масив у наступний спосіб: 
        /// всі від’ємні елементи помножити на -1; 
        /// всі додатні елементи   зменшити на 3;
        /// елементи, які дорівнюють 0, замінити на -2.
        /// </summary>

        public static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] arr3 = new int[] { int.MaxValue, 2, 33, 156, 999, 543, 951, 8, 9, int.MinValue };
            int[] arr2 = new int[] { int.MaxValue - 1, 2, 3, 4, 5, 6, 7, 8, 9, int.MaxValue };
        }

        private static int[] CreateNewArray(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] < 0) { newArray[i] = array[i] * (-1); }
                if (array[i] > 0) { newArray[i] = array[i] - 3; }
                if (array[i] == 0) { newArray[i] -=2; }
            }

            return newArray;
        }
    }
}
