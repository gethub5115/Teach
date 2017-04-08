namespace Calculator
{
    internal interface IOperation : IItem
    {
        OperationValue Value { get; }
    }
}