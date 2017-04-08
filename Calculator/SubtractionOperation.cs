using System;

namespace Calculator
{
    internal class SubtractionOperation : IOperation
    {
        public OperationValue Value => OperationValue.Substraction;
    }
}