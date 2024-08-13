using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hi_TechDistributionInc.Validation
{
    public static class Validator
    {
        public static bool IsValidId(string input, int size, ref string errMessage)
        {
            if (input.Length == 0)
            {
                errMessage = "EmployeeId is required.";
                return false;
            }
            if (!(Regex.IsMatch(input, @"^\d{" + size + "}$")))
            {
                errMessage = "EmployeeId must be " + size + "-digit number";
                return false;

            }

            return true;
        }
        public static bool IsValidName(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if ((!(Char.IsLetter(input[i]))) && (!(Char.IsWhiteSpace(input[i]))))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
