using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reshaper
{
    public class AutoComplete
    {
        private static RichTextBox editor;

        public static void InitEditor(RichTextBox box)
        {
            editor = box;

        }

        public static void AutoCompleteBrackets(int selection, char key)
        {

            switch (key)
            {
                case '(':
                    editor.Text = editor.Text.Insert(selection, "(  )");
                    break;

                case '{':
                    editor.Text = editor.Text.Insert(selection, "{  }");
                    break;

                case '[':
                    editor.Text = editor.Text.Insert(selection, "[  ]");
                    break;

                case '<':
                    editor.Text = editor.Text.Insert(selection, "<  >");
                    break;

                case '\"':
                    editor.Text = editor.Text.Insert(selection, "\" \"");
                    break;

                case '\'':
                    editor.Text = editor.Text.Insert(selection, "\' \'");
                    break;
            }

        }
    }
}
