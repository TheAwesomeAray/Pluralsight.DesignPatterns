namespace Pluralsight.DesignPatterns.Bridge
{
    internal interface IManuscript
    {
        void Print(ITextFormat formatter);
    }
}