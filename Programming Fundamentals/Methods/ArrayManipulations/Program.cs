using System;
using System.Linq;
namespace ArrayManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split(" ");


                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index > arr.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeArr(arr, index);
                       

                    }

                }
                if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        MinValueEven(arr);
                    }
                    else
                    {
                        MinValueOdd(arr);
                    }

                }
                if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        MaxValueEven(arr);
                    }
                    if (command[1] == "odd")
                    {
                        MaxValueOdd(arr);
                    }

                }
                if (command[0] == "first")
                {
                    int index = int.Parse(command[1]);
                    if (command[2] == "even")
                    {
                        FirstEven(arr, index);
                    }
                    else if (command[2] == "odd")
                    {
                        FirstOdd(arr, index);
                    }
                }
                if (command[0] == "last")
                {
                    int index = int.Parse(command[1]);
                    if (command[2] == "even")
                    {
                        LastEven(arr, index);
                    }
                    else if (command[2] == "odd")
                    {
                        LastOdd(arr, index);
                    }
                }

                input = Console.ReadLine();
            }
            string text = string.Join(", ", arr);
            Console.WriteLine($"[{text}]");

            
        }
        static void ExchangeArr(int[] arr, int index)
        {
            int[] firstArr = new int[arr.Length - index - 1];
            int[] secondArr = new int[index + 1];
            int firstArrCounte = 0;
            for (int i = index + 1; i < arr.Length; i++)
            {
                firstArr[firstArrCounte] = arr[i];
                firstArrCounte += 1;
            }
            for (int i = 0; i < index + 1; i++)
            {
                secondArr[i] = arr[i];
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                arr[i] = firstArr[i];
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                arr[firstArr.Length + i] = secondArr[i];
            }
        }

        static void MinValueEven(int[] arr)
        {
            int minValue = int.MaxValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] <= minValue)
                {
                    minValue = arr[i];
                    index = i;
                }
            }
            if (index <= -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MinValueOdd(int[] arr)
        {
            int minValue = int.MaxValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] <= minValue)
                {
                    minValue = arr[i];
                    index = i;
                }
            }
            if (index <= -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MaxValueEven(int[] arr)
        {
            int maxValue = int.MinValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] >= maxValue)
                {
                    maxValue = arr[i];
                    index = i;
                }
            }
            if (index <= -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MaxValueOdd(int[] arr)
        {
            int maxValue = int.MinValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] >= maxValue)
                {
                    maxValue = arr[i];
                    index = i;
                }
            }
            if (index <= -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void FirstEven(int[] arr, int index)
        {
            if (index > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int counter = 0;
                string number = string.Empty;
                for (int i = 0; i < arr.Length; i++)
                {
                  
                    if (arr[i] % 2 == 0)
                    {
                        number += arr[i] + " ";
                        counter++;
                    }
                    if (index == counter)
                    {
                        break;
                    }
                }
                var first = number.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string text = string.Join(", ", first);
                Console.WriteLine($"[{text}]");
            }
        }

        static void FirstOdd(int[] arr, int index)
        {
            if (index > arr.Length)
            {
                Console.WriteLine("invalid count");
            }
            else
            {
                int counter = 0;
                string number = string.Empty;
                for (int i = 0; i < arr.Length; i++)
                {
                   
                    if (arr[i] % 2 != 0)
                    {
                        number += arr[i] + " ";
                        counter++;
                    }
                    if (index == counter)
                    {
                        break;
                    }
                }
                var first = number.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string text = string.Join(", ", first);
                Console.WriteLine($"[{text}]");
            }
        }

        static void LastEven(int[] arr, int index)
        {
            if (index > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int counter = 0;
                string number = string.Empty;
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    
                    if (arr[i] % 2 == 0)
                    {
                        number += arr[i] + " ";
                        counter++;
                    }
                    if (index == counter)
                    {
                        break;
                    }
                }
                var last = number.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string text = string.Join(", ", last.Reverse());
                Console.WriteLine($"[{text}]");
            }
        }

        static void LastOdd(int[] arr, int index)
        {
            if (index > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int counter = 0;
                string number = string.Empty;
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    
                    if (arr[i] % 2 != 0)
                    {
                        number += arr[i] + " ";
                        counter++;
                    }
                    if (index == counter)
                    {
                        break;
                    }
                }
                var last = number.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string text = string.Join(", ", last.Reverse());
                Console.WriteLine($"[{text}]");
            }
        }
    }
}


