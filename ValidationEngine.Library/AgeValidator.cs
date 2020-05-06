using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    internal class AgeValidator : BaseValidator
    {
        public override bool IsValidData(object inputData)
        {
            if (inputData.GetType().Equals(typeof(int)) && Convert.ToInt32(inputData) >= 18)
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
