using System;

namespace Pluralsight.DesignPatterns.Command
{
    public class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        private int _newQuantity;

        public UpdateQuantityCommand()
        { }

        public UpdateQuantityCommand(int newQuantity)
        {
            _newQuantity = newQuantity;
        }

        public string CommandName => "UpdateQuantity";
        public string Description => "UpdateQuantity number";

        public void Execute()
        {
            Console.WriteLine("Database Updated");

            Console.WriteLine($"Log: Updated order quantity to {_newQuantity}");
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new UpdateQuantityCommand(int.Parse(arguments[1]));
        }
    }
}
