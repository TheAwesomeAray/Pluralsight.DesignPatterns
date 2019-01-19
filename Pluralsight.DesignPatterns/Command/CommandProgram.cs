using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Command
{
    public static class CommandProgram
    {
        public static void Run(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if (args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);

            if (command != null)
                command.Execute();
        }

        private static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
                {
                    new UpdateQuantityCommand(40)
                };

        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            foreach (var command in availableCommands)
                Console.WriteLine(command.Description);
        }
    }
}
