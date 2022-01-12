using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_DataStruct
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            // in-place and stable algorithm
            // this algorithm isnt really used anymore
            // you compare the values at array[i] and array[i+1], if larger swop them arround untill you reach the end of the array
            // then the upper limit of the array moves 1 down as the highest value will then be at the end(no need to sort) THE WALL
            // repeat until the array is sorted
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if( array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
            // the complexity for this algorithm isnt quite O(N^2) as the inner loop decreases in iterations everytime the outer loop runs
            // precise runtime isnt needed though as we check for the worst case scenario
        }

        public static void SelectionSort(int[] array)
        {
            // in-place and unstable algorithm
            // the complexity for this algorithm is O(N ^ 2) but its faster than bubble
            // this algorithm works by looking for the largest value in an array then placing that value at the end of the array and moving the wall down 1
            // this repeats until the loops are complete

            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                    Swap(array, largestAt, partIndex);
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            // in-place algorithm
            // stable
            // O(N^2) algorithm
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int curUnsorted = array[partIndex];
                int i = 0;
                for (i = partIndex; i > 0 && array[i-1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = curUnsorted;
            }
            // because this depends on shifting an array until the value is in the correct place, it could be quite slow as it may need to shift an entire arrays values in order to sort a single element
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
