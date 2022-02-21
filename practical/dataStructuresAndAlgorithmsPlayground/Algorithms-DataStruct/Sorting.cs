using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_DataStruct
{
    public class Sorting
    {
        // swap elements in an array
        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        
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

        public static void ShellSort(int[] array)
        {
            // in-place algorithm and unstable algorithm
            // O(n^3/2) time complexity (if sequence is (1/2(3^k -1)), can even be O(n^6/5)
            // based on the insertion sort
            // insertion sort is fast on pre-sorted arrays
            // Basic idea: pre-sort the input and switch to insertion sort
            // Gap is used for pre-sorting => swap distant elements
            // shell sort starts with a 'large' gap and gradually reduces it
            // when gap = 1, insertion sort finishes the sorting process
            // Shell sort performance depends on a concrete gap value, in 99% of cases we can rely on the "universal" sequence of gap values

            int gap = 1;

            while(gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while(gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for(int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }
        }

        public static void MergeSort(int[] array)
        {
            // divide and conquer
            // Two Phases: Splitting and Merging
            // Splitting is logical: Provides an organized way to sequence the merges
            // Not an in-place algorithm(uses a lot of memory, depends on N)
            // Stable
            // O(nlogn) tiime complixity (linearithmic)

            int[] aux = new int[array.Length];

            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if(high <= low)
                {
                    return;
                }

                int mid = (high + low) / 2;

                Sort(low, mid);
                Sort(mid + 1, high);

                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if(array[mid] <= array[mid + 1])
                {
                    return;
                }

                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);

                for (int k = low; k <= high; k++)
                {
                    if(i > mid)
                    {
                        array[k] = aux[j++];
                    }
                    else if(j > high)
                    {
                        array[k] = aux[i++];
                    }
                    else if(aux[j] < aux[i])
                    {
                        array[k] = aux[j++];
                    }
                    else
                    {
                        array[k] = aux[i++];
                    }
                }
            }
        }

        public static void QuickSort(int[] array)
        {
            // divide and conquer
            // recursice
            // splitting based on pivot elements
            // elements < pivot go to its left, elements > pivot go to its right
            // pivot gets into its place in the end of each pass
            // In-place and unstable algorithm
            // O(nlogn) time complexity(linearithmic) at best O(n^2) time complexity(quadratic) in extremely rare cases

            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if(high <= low)
                {
                    return;
                }

                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }
            int Partition(int low, int high)
            {
                int i = low;
                int j = high + 1;

                int pivot = array[low];

                while (true)
                {
                    while(array[++i] < pivot)
                    {
                        if(i == high)
                        {
                            break;
                        }
                    }
                    while(pivot < array[--j])
                    {
                        if(j == low)
                        {
                            break;
                        }
                    }

                    if(i >= j)
                    {
                        break;
                    }

                    Swap(array, i, j);
                }
                Swap(array, low, j);

                return j;
            }
        }
    }
}
