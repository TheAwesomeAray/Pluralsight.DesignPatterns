namespace Pluralsight.DesignPatterns.LazyLoad.ValueHolder
{
    public interface IValueLoader<T>
    {
        T Load();
    }
}
