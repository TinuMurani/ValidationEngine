using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Library
{
    internal  class NumberStringValidator : BaseValidator
    {
        public override bool IsValidData(object inputData)
        {
            bool output = false;

            //vreau sa ma asigur ca ceea ce vine de la API este un string, 
            //chiar daca voi face validari si la introducerea datelor
            string transform = inputData.ToString() ?? "";

            //enuntul solicita un string de numere pentru CNP
            //trebuie sa ma asigur ca sunt pozitive si daca nu sunt sa returnam faptul ca nu este valid
            for (int i = 0; i < transform.Length; i++)
            {
                if (uint.TryParse(transform[i].ToString(), out uint result))
                {
                    output = true;
                }
                else
                {
                    output = false;
                    break;
                }
            }

            return output;
        }
    }
}
