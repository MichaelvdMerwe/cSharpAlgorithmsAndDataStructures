using Algorithms_DataStruct;
using System;
using System.Diagnostics;
using System.Linq;

namespace dataStructuresAndAlgorithmsPlayground
{
    class Program
    {
        private static readonly string oneThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\1Kints.txt";
        private static readonly string twoThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\2Kints.txt";
        private static readonly string fourThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\4Kints.txt";
        private static readonly string eightThousandInts = "C:\\personalGit\\cSharpAlgorithmsAndDataStructures\\practical\\dataStructuresAndAlgorithmsPlayground\\dataStructuresAndAlgorithmsPlayground\\txtFiles\\8Kints.txt";


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
        
        // 1! = 1 * 0! = 1
        // 2! = 2 * 1 = 2 * 1!
        // 3! = 3 * 2 * 1 = 3 * 2!
        // n! = n * (n-1)!

        private static int RecursiveFactorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }

            return n * RecursiveFactorial(n-1);
        }

        private static int IterativeFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
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

        private static void ArrayTimeComplexity(object[] array)
        {
            //access by index
            //O(1) constant runtime
            Console.WriteLine(array[0]);

            //some pseudocode
            //searching for an element takes O(N) time
            int length = array.Length;
            object elementINeedToFind = new object();
            for (int i = 0; i < length; i++)
            {
                if (array[i] == elementINeedToFind)
                {
                    Console.WriteLine("Exists/Found");
                }
            }

            //add to a full array
            var biggArray = new int[length * 2];
            Array.Copy(array, biggArray, length);
            biggArray[length + 1] = 10;

            //add to the end when theres some space
            //O(1)
            array[length - 1] = 10;

            //if you know the index then the algorithm runtime is O(1)
            //if you loop through its O(N)

            //O(1)
            array[6] = null;
        }

        private static void RemoveAt(object[] array, int index)
        {
            //Complexity of this algorithm is O(N) since copy uses a loop
            var newArray = new object[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - 1 - index);
        }
    }
}
