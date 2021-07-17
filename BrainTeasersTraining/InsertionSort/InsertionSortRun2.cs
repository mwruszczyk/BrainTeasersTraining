using System;
using System.Collections.Generic;
using System.Text;

namespace BrainTeasersTraining.InsertionSort
{
    class InsertionSortRun2
    {
        public InsertionSortRun2()
        {
            int[] arr = new int[5] { 8, 5, 7, 3, 1 };
            int n = 5, i, j, val;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > val)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = val;
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
