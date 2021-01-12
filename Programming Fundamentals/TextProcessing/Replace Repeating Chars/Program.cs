using System;
using System.Collections.Generic;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] arr = text.ToCharArray();
            List<char> list = new List<char>();
            for(int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }
            for(int i=0;i<list.Count;i++)
            {
                int index =i;
                for(int j=index+1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join("", list));
        }
    }
}
