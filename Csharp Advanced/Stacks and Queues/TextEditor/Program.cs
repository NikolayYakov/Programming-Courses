using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            int count = int.Parse(Console.ReadLine());
            Stack<string> commandStack = new Stack<string>();
            commandStack.Push(text.ToString());
            for(int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "1":
                        string append = command[1];
                        text.Append(append);
                        commandStack.Push(text.ToString());
                        break;
                    case "2":
                        int removeCount = int.Parse(command[1]);
                        text = text.Remove(text.Length - removeCount,removeCount) ;
                        commandStack.Push(text.ToString());
                        break;
                    case "3":
                        int index = int.Parse(command[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text = text.Clear();
                        commandStack.Pop();
                        text.Append(commandStack.Peek());
                        break;
                }
                 
            }
        }
    }
}
