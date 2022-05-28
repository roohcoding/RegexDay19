using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDay19
{
    internal class PWDSpecialChar
    {
        public string Regex_SpecialChar_Pwd = "^(?=.*[*&^%$#@!?_-])(?=.*[0-9])(?=.*[A-Z])(?=.[a-z A-Z 0-9]{8,}).*$";// $2ankush
        public bool SpecialCharPwd(string PWD)
        {
            return Regex.IsMatch(Regex_SpecialChar_Pwd, PWD);
        }
    }
}
