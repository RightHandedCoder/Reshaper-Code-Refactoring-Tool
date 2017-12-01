using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reshaper
{
    public abstract class Rules
    {
        public readonly static string patternDataType = @"(\bs?byte\b|\bu?short\b|\bu?int\b|\bu?long\b|\bfloat\b|\bdouble\b|\bdecimal\b|\bchar\b|\bstring\b|\bbool\b|\bobject\b|\bvoid\b)";
        public readonly static string patternAccessModifier = @"(\bprivate\b|\bpublic\b|\bprotected\b|\binternal\b|\bprotected\b\s\binternal\b)";
        public readonly static string patternMethodDecleration = @"(<\d*>)*?\s*?(private|public|protected|internal|protected\sinternal)*?\s*?(\bs?byte\b|\bu?short\b|\bu?int\b|\bu?long\b|\bfloat\b|\bdouble\b|\bdecimal\b|\bchar\b|\bstring\b|\bbool\b|\bobject\b|\bvoid\b)(\s*?)(\w)(\s*?)(\w*?)";
        public readonly static string patternVariableDecleration = @"((<\d*>)*?\s*?(private|public|protected|internal|protected\sinternal)*?\s*?(\bs?byte\b|\bu?short\b|\bu?int\b|\bu?long\b|\bfloat\b|\bdouble\b|\bdecimal\b|\bchar\b|\bstring\b|\bbool\b|\bobject\b|\bvoid\b)\s+\b\w+\b\s*?)(;|=\s*?\d*;)";
        public readonly static string patternClassDecleration = @"((<\d*>)*?\s*?(private|public|protected|internal|protected\sinternal)*?\s*?[class])";

    }
}
