using System;

namespace AlmostIncresaingSequence
{
    class Program
    {
        /// <summary>
        /// Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence by removing no more than one element from the array.
        /// Note: sequence a0, a1, ..., an is considered to be a strictly increasing if a0<a1< ... < an.
        /// Sequence containing only one element is also considered to be strictly increasing.
        /// </summary>
        static void Main(string[] args)
        {
            //int[] array = new int[] { 1, 2, 1, 2 };
            //int[] array = new int[] { 1, 3, 2, 1 };
            //int[] array = new int[] { 1, 3, 2, 3 };
            //int[] array = new int[] { 10, 1, 2, 3, 4, 5 };
            //int[] array = new int[] { 5, 6, 7, 8, 9, 10, 1 };
            //int[] array = new int[] { 40, 50, 60, 10, 20, 30 };
            //int[] array = new int[] { 40, 50, 60, 70 };
            //int[] array = new int[] { 1, 1, 2, 3, 4, 4 };
            int[] array = new int[] { 1, 2, 5, 3, 5 };
            var answ = IsInereasing(array);
            Console.WriteLine(answ);
        }

        static bool IsInereasing(int[] sequence)
        {
            if (sequence.Length > 0 && sequence.Length < 2)
            {
                return true;
            }
            int temp = 0;
            int j = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    j = i;
                    temp++;
                }
                if (temp > 1)
                {
                    return false;
                }
            }
            if (j == 0 || j == sequence.Length - 1)
            {
                return true;
            }

            int[] arr1(int[] array)
            {
                int[] newSeq = new int[array.Length - 1];
                for (int i = 0; i < j; i++)
                {
                    newSeq[i] = array[i];
                }
                for (int i = j; i < array.Length - 1; i++)
                {
                    newSeq[i] = array[i + 1];
                }
                return newSeq;
            }

            int[] arr2(int[] array)
            {
                int[] newSeq = new int[array.Length - 1];
                j++;
                for (int i = 0; i < j; i++)
                {
                    newSeq[i] = array[i];
                }
                for (int i = j; i < array.Length - 1; i++)
                {
                    newSeq[i] = array[i + 1];
                }
                return newSeq;
            }

            bool IsInc(int[] array)
            {
                int k = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] >= array[i + 1])
                    {
                        k++;
                    }
                }
                if (k > 0)
                    return false;
                return true;
            }
            bool c1 = IsInc(arr1(sequence));
            if (c1)
            {
                return true;
            }
            bool c2 = IsInc(arr2(sequence));
            if (c2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
