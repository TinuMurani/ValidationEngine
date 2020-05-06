using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    internal class StringValidator : BaseValidator
    {
        public override bool IsValidData(object inputData)
        {
            if (inputData.GetType().Equals(typeof(string)) && !string.IsNullOrWhiteSpace(inputData.ToString()))
            {
                return true;
            }

            else return false;
        }
    }
}
