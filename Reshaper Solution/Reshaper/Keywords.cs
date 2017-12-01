using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reshaper
{
    public abstract class Keywords
    {
        private static readonly string key_AccessModifier = @"(\bprivate\b|\bpublic\b|\bprotected\b|\binternal\b|\bprotected\b\s\binternal\b)";
        private static readonly string key_DataType = @"(\bs?byte\b|\bu?short\b|\bu?int\b|\bu?long\b|\bfloat\b|\bdouble\b|\bdecimal\b|\bchar\b|\bstring\b|\bbool\b|\bobject\b|\bvoid\b)";
        private static readonly string key_ReturnType = @"(\bs?byte\b|\bu?short\b|\bu?int\b|\bu?long\b|\bfloat\b|\bdouble\b|\bdecimal\b|\bchar\b|\bstring\b|\bbool\b|\bobject\b|\bvoid\b)";
        private static readonly string key_Class = @"((<\d*>)*?\s*?(private|public|protected|internal|protected\sinternal)*?\s*?[class]\s*?[A-Z][A-Za-z])";
        private static readonly string key_Interface = @"((<\d*>)*?\s*?[interface])";
        private static readonly string key_Property = @"((<\d*>)*?\s*?[public]\s*(\bs?byte\b|\bu?short\b|\bu?int\b|\bu?long\b|\bfloat\b|\bdouble\b|\bdecimal\b|\bchar\b|\bstring\b|\bbool\b|\bobject\b|\bvoid\b)\s*[A-Z][A-Za-z]*\s*?[{]\s*?[}])";

        public static bool IsAccessModifier(string word)
        {
            Match match = Regex.Match(word, key_AccessModifier);

            if (match.Success)
            {
                return true;
            }

            else return false;
        }

        public static bool IsDataType(string word)
        {
            Match match = Regex.Match(word, key_DataType);

            if (match.Success)
            {
                return true;
            }

            else return false;
        }

        public static bool IsReturnType(string word)
        {
            Match match = Regex.Match(word, key_ReturnType);

            if (match.Success)
            {
                return true;
            }

            else return false;
        }

        public static bool IsClassType(string word)
        {
            Match match = Regex.Match(word, key_Class);

            if (match.Success)
            {
                return true;
            }

            else return false;

        }

        public static bool IsInterfaceType(string word)
        {
            Match match = Regex.Match(word, key_Interface);

            if (match.Success)
            {
                return true;
            }

            else return false;

        }

        public static bool IsProperty(string word)
        {
            Match match = Regex.Match(word, key_Property);

            if (match.Success)
            {
                return true;
            }

            else return false;
        }

    }
}
