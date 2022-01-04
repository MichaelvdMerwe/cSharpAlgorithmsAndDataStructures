using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_DataStruct
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
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
