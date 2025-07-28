namespace DesignPatternsDemo.PrototypeDP
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}