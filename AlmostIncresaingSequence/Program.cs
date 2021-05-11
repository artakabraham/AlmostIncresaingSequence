using System;

namespace AlmostIncresaingSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 1, 2 };

            var answ = IsInereasing(array);

            Console.WriteLine(answ);

        }

        static bool IsInereasing(int[] array)
        {

            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }


            if (array.Length > 0 && array.Length < 2)
            {
                return true;
            }
            int t = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    t++;
                }
                if (t > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
