using System.Collections.Generic;
using System.Linq;

namespace Pluralsight.DesignPatterns.Command
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> _availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            _availableCommands = availableCommands;
        }

        public ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];
            var command = _availableCommands.FirstOrDefault(c => c.CommandName == requestedCommandName);
            return command.MakeCommand(args);
        }
    }
}
