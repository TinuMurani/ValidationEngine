using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    internal abstract class BaseValidator
    {
        public abstract bool IsValidData(object inputData);
    }
}
