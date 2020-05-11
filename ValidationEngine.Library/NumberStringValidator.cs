using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    internal  class NumberStringValidator : BaseValidator
    {
        public override bool IsValidData(object inputData)
        {
            string data = inputData as string;

            foreach (Char c in data.ToCharArray())
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
