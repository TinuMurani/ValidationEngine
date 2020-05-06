using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    public static class ValidationMethods
    {
        public static bool IsValid(object inputData, UserDataTypes dataType)
        {
            BaseValidator validator;

            switch (dataType)
            {
                case UserDataTypes.StringType:
                    validator = new StringValidator();
                    break;
                case UserDataTypes.NumberStringType:
                    validator = new NumberStringValidator();
                    break;
                case UserDataTypes.NumberType:
                    validator = new NumberValidator();
                    break;
                case UserDataTypes.AgeType:
                    validator = new AgeValidator();
                    break;
                default:
                    validator = null;
                    break;
            }

            return validator.IsValidData(inputData);
        }
        #region FirstAttempt
        /*
        public static bool IsValidString(string name)
        {
            return new StringValidator().IsValidData(name);
        }

        public static bool IsValidAge(int age)
        {
            if (new NumberValidator().IsValidData(age) && age >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidCNP(string cnp)
        {
            if (new NumberStringValidator().IsValidData(cnp))
            {
                if (ValidateCNP(cnp))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static bool ValidateCNP(string cnp)
        {
            if (cnp.Length == 13)
            {
                return IsSimpleCNPValid(cnp);
            }
            else
            {
                return false;
            }
        }

        private static bool IsSimpleCNPValid(string cnp)
        {
            string validator = "279146358279";
            float sum = 0f;

            for (int i = 0; i < validator.Length; i++)
            {
                sum += float.Parse(cnp[i].ToString()) * float.Parse(validator[i].ToString());
            }

            float modulus = sum % 11;

            if (modulus == int.Parse(cnp[12].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */ 
        #endregion
    }
}
