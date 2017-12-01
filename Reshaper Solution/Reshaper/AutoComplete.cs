using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reshaper
{
    public class AutoComplete
    {
        private static RichTextBox editor;
        public static List<char> BracketsList;

        public static void InitEditor(RichTextBox box)
        {
            editor = box;

            BracketsList = new List<char>();
            BracketsList.Add('(');
            BracketsList.Add('{');
            BracketsList.Add('[');
            BracketsList.Add('<');
            BracketsList.Add('\'');
            BracketsList.Add('\"');

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
