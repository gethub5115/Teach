namespace Calculator
{
    internal interface IVariable<T> : IItem
    {
        T Value { get; set; }
    }
}