using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reshaper
{
    public class TokenGenerator
    {
        public static bool IsAccessModifier(string word)
        {
            Match match = Regex.Match(word, Rules.patternAccessModifier);

            if (match.Success)
            {
                return true;
            }

            else return false;
        }

        public static bool IsDataType(string word)
        {
            Match match = Regex.Match(word, Rules.patternDataType);

            if (match.Success)
            {
                return true;
            }

            else return false;
        }

        public static bool IsReturnType(string word)
        {
            Match match = Regex.Match(word, Rules.patternDataType);

            if (match.Success)
            {
                return true;
            }

            else return false;
        }

        public static bool IsVariableDecleration(string line)
        {
            if (line != null)
            {
                Match match = Regex.Match(line, Rules.patternVariableDecleration);

                if (match.Success)
                {

                    return true;

                }
                else return false;
            }

            else return false;

        }
    }
}
