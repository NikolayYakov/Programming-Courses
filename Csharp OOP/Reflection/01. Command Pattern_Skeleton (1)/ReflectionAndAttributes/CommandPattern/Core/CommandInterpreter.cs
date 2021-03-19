using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            ICommand command = null;
            string[] inputTocken = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string commandType = inputTocken[0].ToLower();
            string[] commandArguments = inputTocken.Skip(1).ToArray();
            var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x=>x.Name.ToLower()==$"{commandType}Command".ToLower());
            ICommand instance = (ICommand)Activator.CreateInstance(type);
            string result =  instance.Execute(commandArguments);
             
            return result;
        }
    }
}
