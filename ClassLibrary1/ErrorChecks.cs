using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ErrorChecks
    {

        public static bool checkStringConditions(string text, bool numbers, int maxChars, int minChars, bool specChars)
        {
            bool safe = true;

            if (numbers) // if need to contain nmbr check for nmbr
            {
                bool containsNmbr = false;
                foreach (char c in text)
                {
                    if (int.TryParse(c.ToString(), out int result))
                    { 
                        containsNmbr = true;
                        break;
                    }
                }
                if (!containsNmbr)
                { 
                    safe = false;
                    return safe;
                }
            }


            if (text.Length > maxChars || text.Length < minChars)  // check max min chars
            {
                safe = false;
                return safe;
            }

            if (specChars) // if need to contain nmbr check for nmbr
            {
                bool containsSpec = false;
                foreach (char c in text)
                {
                    if (c == '!' || c == '@' || c == '#' || c == '£' || c == '¤' || c == '$' || c == '%' || c == '&' || c == '/' || c == '(' || c == ')' || c == '[' || c == ']' || c == '{' || c == '}' || c == '=' || c == '+' || c == '?' || c == '*' || c == '^' || c == '~' || c == '|' || c == '`')
                    {
                        containsSpec = true;
                        break;
                    }
                }
                if (!containsSpec)
                {
                    safe = false;
                    return safe;
                }
            }


            return safe;
        }



        public static bool checkNumber(string nmbr) //check if number
        {
            if (int.TryParse(nmbr, out int result))
            { 
                return true;
            }
            return false;
        }

    }
}
