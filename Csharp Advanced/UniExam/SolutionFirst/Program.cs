using System;
using System.IO;

namespace SolutionFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int[] arrNumber = ReadArrayFromFile(path);
            Console.WriteLine($"Toва е масива {string.Join(", ", arrNumber)}");
            int[] reversed = ReverseInplace(arrNumber);
            int count = MostCommonCount(arrNumber);
            Console.WriteLine($"Това е обътнатия масив {string.Join(", ", reversed)}");
            Console.WriteLine($"Това е броя на най-често повтарящия се елемент {count}");
        }
        static int[] ReadArrayFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {

                while (!reader.EndOfStream)
                {
                    string[] arr = reader.ReadLine().Split(", ");
                    int[] numberArr = new int[arr.Length];
                    for (int i = 0; i < numberArr.Length; i++)
                    {
                        int number = int.Parse(arr[i]);
                        numberArr[i] = number;
                    }
                    return numberArr;
                }
                return null;
            }
        }
        static int[] ReverseInplace(int[] arr)
        {

            int firstIndex = 0;
            int secondIndex = arr.Length - 1;
            while (firstIndex < secondIndex)
            {
                int element = arr[firstIndex];
                arr[firstIndex] = arr[secondIndex];
                arr[secondIndex] = element;
                firstIndex++;
                secondIndex--;
            }
            return arr;
        }
        static int MostCommonCount(int[] arrCommon)
        {
            int mostCommonElement = 0;
            int finalResult = 1;
            for (int i = 0; i < arrCommon.Length; i++)
            {
                int count = 1;
                mostCommonElement = arrCommon[i];
                for (int j = 0; j < arrCommon.Length; j++)
                {
                    if (i != j && arrCommon[i] == arrCommon[j])
                    {
                        count++;
                        if (count > finalResult)
                        {
                            finalResult = count;
                        }
                    }
                }
            }
            return finalResult;

        }
    }
}
