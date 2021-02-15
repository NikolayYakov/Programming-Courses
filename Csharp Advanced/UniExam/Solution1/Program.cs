using System;
using System.IO;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int[] arrNumber = ReadArrayFromFile(path);
            int[] reversed = ReverseInplace(arrNumber);
            int count = MostCommonCount(arrNumber);
            Console.WriteLine($"Toва е масива {string.Join(", ", arrNumber)}");
            Console.WriteLine($"Това е обътнатия масив {string.Join(", ", reversed)}");
            Console.WriteLine($"Това е броя на най-често повтарящия се елемент {count}");
        }
        static int[] ReadArrayFromFile(string path)
        {
            using(StreamReader reader  = new StreamReader(path))
            {
                 
                while (!reader.EndOfStream)
                {
                    string[] arr = reader.ReadLine().Split(", ");
                    int[] numberArr = new int[arr.Length];
                    for(int i = 0; i < numberArr.Length; i++)
                    {
                        int number = int.Parse(arr[i]);
                        numberArr[i] = number;
                    }
                    return numberArr;
                }
                return null;
            }
        }
        static int[] ReverseInplace(int[] arrNumber)
        {

            int firstIndex = 0;
            int secondIndex = arrNumber.Length - 1;
            while (firstIndex < secondIndex)
            {
                int element = arrNumber[firstIndex];
                arrNumber[firstIndex] = arrNumber[secondIndex];
                arrNumber[secondIndex] = element;
                firstIndex++;
                secondIndex--;
            }
            return arrNumber;
        }
        static int MostCommonCount(int[] arrNumber)
        {
            int mostCommonElement = 0;
            int finalResult = 0;
            for(int i = 0; i < arrNumber.Length; i++)
            {
                int count = 1;
                mostCommonElement = arrNumber[i];
                for(int j = 0; j < arrNumber.Length; j++)
                {
                    if (i != j && arrNumber[i] == arrNumber[j])
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
