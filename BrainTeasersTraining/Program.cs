using System;
using BrainTeasersTraining.BubbleSort;
using BrainTeasersTraining.MergeSort;
using BrainTeasersTraining.InsertionSort;
using BrainTeasersTraining.CompareValues;

namespace BrainTeasersTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bubblesort = new BubbleSortRun();  //Bubble sort
            //var mergesort = new MergeSortRun();  // Merge sort
            //var insertsort = new InsertionSortRun(); //Insertion sort 
            //var insertsort = new InsertionSortRun2(); //Another way for Insertion sort
             var compare = new CompareRun();
             compare.CompareNumber();   //Compare numbers and do math

        }
    }
}
