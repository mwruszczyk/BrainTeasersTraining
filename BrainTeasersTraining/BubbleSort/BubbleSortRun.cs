using System;
using System.Collections.Generic;
using System.Text;

namespace BrainTeasersTraining.BubbleSort
{
    class BubbleSortRun
    {
        public BubbleSortRun()
        {
            int count = 0;
            int[] intArray = new int[5];
            Console.WriteLine("Please Enter 5 Array Elements : ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            //Sorting the array
            for (int j = 0; j <= intArray.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= intArray.Length - 2; i++)
                {
                    count = count + 1;
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting Array :");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The Loop iterates :" + count);
            Console.ReadKey();
        }

    }
}

//The Bubble Sort Algorithm works on the concept of iterating
//through the array from the first index to the last index and
//comparing with the adjacent elements and then swapping the
//elements if they appear in the wrong order i.e. if the next
//element is smaller than the current element, they are swapped.
