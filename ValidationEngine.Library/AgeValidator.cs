using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    internal class AgeValidator : BaseValidator
    {
        public AgeValidator(int from, int to)
        {
            From = from;
            To = to;
        }

        public int From { get; }
        public int To { get; }

        public override bool IsValidData(object inputData)
        {
            if (inputData is int data)
            {
                return (data >= From) && (To >= data);
            }

            return false;
        }
    }
}
