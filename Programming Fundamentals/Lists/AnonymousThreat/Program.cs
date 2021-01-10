using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lineOfDate = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .ToList();
            List<string> comand = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
            while (comand[0].ToLower() != "3:1")
            {
                switch (comand[0].ToLower())
                {
                    case "merge":
                        int startIndexMerge = int.Parse(comand[1]);
                        int endIndexMerge = int.Parse(comand[2]);
                        Merge(lineOfDate, startIndexMerge, endIndexMerge);
                        break;
                    case "divide":
                        int index = int.Parse(comand[1]);
                        int parts = int.Parse(comand[2]);
                        Divide(lineOfDate, index, parts);
                        break;
                }
                comand = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
            }
            Console.WriteLine(string.Join(" ", lineOfDate));
        }
        static void Merge(List<string> listOfDate,int startIndex,int lastIndex)
        {
            if (startIndex > listOfDate.Count)
            {
                startIndex = listOfDate.Count-1;
            }
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (lastIndex > listOfDate.Count)
            {
                lastIndex = listOfDate.Count - 1;
            }
            if (lastIndex < 0)
            {
                lastIndex = 0;
            }
            for(int i = startIndex+1; i <= lastIndex; i++)
            {
                listOfDate[startIndex] += listOfDate[i];
                 
            }
            listOfDate.RemoveRange(startIndex + 1, lastIndex - startIndex);
        }

        static void Divide(List<string> listOfDate,int index,int parts)
        {
                List<string> newWord = new List<string>();
                string word = listOfDate[index];
                int wordParts = word.Length / parts;
                int startIndex = 0;
                for(int i = 0; i < parts; i++)
                {
                if (i == parts - 1)
                {
                    newWord.Add(word.Substring(startIndex, word.Length - startIndex));

                }
                else
                {
                    newWord.Add(word.Substring(startIndex, wordParts));
                    startIndex += wordParts;
                }
                   
                }
                listOfDate.RemoveAt(index);
                listOfDate.InsertRange(index, newWord);
           
        }


    }
}
