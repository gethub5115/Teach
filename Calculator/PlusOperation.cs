using System;

namespace Calculator
{
    internal class AdditionOperation : IOperation
    {
        public OperationValue Value => OperationValue.Addition;
    }
}