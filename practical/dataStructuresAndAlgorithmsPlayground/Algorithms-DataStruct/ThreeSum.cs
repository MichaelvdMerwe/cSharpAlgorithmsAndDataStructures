using System;

namespace Algorithms_DataStruct
{
    public class ThreeSum
    {
        public static int Count(int[] a)
        {
            int n = a.Length;
            int counter = 0;

            //1, 3, -2, 1, -3, 0, 2
            //1, 3, -2
            //1, 3, 1
            //1, 3, -3
            //1, 3, 0
            //1, 3, 2
            //... all other triplets

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    for(int k = j + 1; k < n; k++)
                    {
                        if(a[i] + a[j] + a[k] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;

            //how much time will it take to run the algorithm with varying amounts of inputs
        }
    }
}
