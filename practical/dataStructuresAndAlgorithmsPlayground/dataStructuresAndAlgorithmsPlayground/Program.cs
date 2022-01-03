using Algorithms_DataStruct;
using System;
using System.Diagnostics;
using System.Linq;

namespace dataStructuresAndAlgorithmsPlayground
{
    class Program
    {
        private static string oneThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\1Kints.txt";
        private static string twoThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\2Kints.txt";
        private static string fourThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\4Kints.txt";
        private static string eightThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\8Kints.txt";


        static void Main(string[] args)
        {
            #region Algorithm Runtime
            /*
            //read ints
            var ints = In.ReadInts(eightThousandInts).ToArray();

            //start timer
            var watch = new Stopwatch();
            watch.Start();

            //invoke algorithm
            var triplets = ThreeSum.Count(ints);

            //stop watch
            watch.Stop();

            Console.WriteLine($"The number of \"zero-sum\" triplets: {triplets}");
            Console.WriteLine($"Time taken: {watch.Elapsed:g}");

            //1k ints:
            //The number of "zero-sum" triplets: 70
            //Time taken: 0:00:00,7352898
            
            //2k ints:
            //The number of "zero-sum" triplets: 528
            //Time taken: 0:00:03,6679279
            
            //4k ints:
            //The number of "zero-sum" triplets: 4039
            //Time taken: 0:00:28,8757126 
            
            //8k ints:
            //The number of "zero-sum" triplets: 32074
            //Time taken: 0:05:25,8913709
            */
            #endregion
        }

        private static void ArraysDemo()
        {
            //System.Array
            //no memory allocated yet
            int[] a1;

            //memory will be allocated
            a1 = new int[10];

            //same line
            int[] a2 = new int[5];

            //declare and initiliaze with values
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            //shorthand
            int[] a4 = { 1, 3, -2, 5, 10 };

        }
        private static void MultiDimArray()
        {
            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.WriteLine($"{r2[i, j]}");
                }
            }

            //you can create even larger dimension arrays
            //there are also jagged arrays, which are arrays of arrays
        }

        private static void JaggedArraysDemo()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Enter the numbers for a jagged array.");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();

                    jaggedArray[i][j] = int.Parse(st);
                }
            }
        }

        //unsafe code
        private static unsafe void IterateOver(int[] array)
        {
            fixed (int* b = array)
            {
                int* p = b;

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(*p);
                    p++;
                }
            }
        }
    }
}
