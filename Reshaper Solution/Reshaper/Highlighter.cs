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
            if (Keywords.IsDataType(editor.Text))
            {
                Mark(Color.Blue, Rules.patternDataType);
            }

            if (Keywords.IsAccessModifier(editor.Text))
            {
                Mark(Color.Red, Rules.patternAccessModifier);
            }

            if(Keywords.IsClassType(editor.Text))
            {
                Mark(Color.DarkSeaGreen,Rules.patternClassDecleration);
            }

        }

        private static void Mark(Color color, string pattern)
        {
            MatchCollection match = Regex.Matches(editor.Text, pattern);

            foreach (Match m in match)
            {
                editor.Focus();

                editor.SelectionStart = m.Index;
                editor.SelectionLength = m.Length;
                editor.SelectionColor = color;

                editor.SelectionStart = editor.TextLength;
                editor.SelectionColor = Color.Black;
            }
        }

    }

}

