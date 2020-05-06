using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    internal class NumberValidator : BaseValidator
    {
        public override bool IsValidData(object inputData)
        {
            if (inputData.GetType().Equals(typeof(int)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
