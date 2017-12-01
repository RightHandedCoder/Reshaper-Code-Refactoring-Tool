using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reshaper
{
    public abstract class Highlighter
    {
        private static RichTextBox editor;

        public static void InitEditor(RichTextBox box)
        {
            editor = box;

        }

        public static void Highlight()
        {
            MarkDatatypes();
            MarkAccessModifiers();
        }

        private static void MarkDatatypes()
        {
            MatchCollection match = Regex.Matches(editor.Text, Rules.patternDataType);

            foreach (Match m in match)
            {
                editor.Focus();

                editor.SelectionStart = m.Index;
                editor.SelectionLength = m.Length;
                editor.SelectionColor = Color.Blue;

                editor.SelectionStart = editor.TextLength;
                editor.SelectionColor = Color.Black;

            }
        }

        private static void MarkAccessModifiers()
        {
            MatchCollection match = Regex.Matches(editor.Text, Rules.patternAccessModifier);

            foreach (Match m in match)
            {
                editor.Focus();

                editor.SelectionStart = m.Index;
                editor.SelectionLength = m.Length;
                editor.SelectionColor = Color.Red;

                editor.SelectionStart = editor.TextLength;
                editor.SelectionColor = Color.Black;

            }
        }

        


    }


}
