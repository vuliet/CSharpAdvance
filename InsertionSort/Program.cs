using System;

namespace InsertionSort
{
    class Program
    {
        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nSap xep chen (Insertion Sort) trong C#:");
            Console.WriteLine("----------------------------------------");

            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nMang cac phan tu ban dau:");
            PrintIntegerArray(numbers);
            Console.WriteLine("\nMang cac phan tu da qua sap xep:");
            PrintIntegerArray(InsertionSort(numbers));
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
