using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDay19
{
    internal class PasswordOneUC
    {
        public String Regex_Pwd_1UpperCase = "^(?=.*[A-Z])[A-Z a-z 0-9 $#@!&*?|]{8,}$";
        public bool UpperCase(string UpperCase)
        {
            return Regex.IsMatch(UpperCase, Regex_Pwd_1UpperCase);
        }
    }
}
