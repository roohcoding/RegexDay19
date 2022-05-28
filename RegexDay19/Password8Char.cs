using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDay19
{
    internal class Password8Char
    {
        public string Regex_Password = "^[a-z A-Z 0-9 @#%$*!&?]{8,}$";
        public bool Passwordmin(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
