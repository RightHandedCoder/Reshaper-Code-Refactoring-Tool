using Reshaper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        List<Line> Lines = new List<Line>();   

        public Form1()
        {
            InitializeComponent();
            AutoComplete.InitEditor(this.TextBoxEditor);
            Highlighter.InitEditor(this.TextBoxEditor);
        }

        private void TextBoxEditor_TextChanged(object sender, EventArgs e)
        {
  
           

           
        }

        private void TextBoxEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (AutoComplete.BracketsList.Exists(b => b == key))    // Auto Complete Brackets
            {
                int selection = TextBoxEditor.SelectionStart;
                AutoComplete.AutoCompleteBrackets(selection, key);
                e.Handled = true;
                TextBoxEditor.SelectionStart = selection + 2;
            }

            if(e.KeyChar == (char)Keys.Space)
            {
                Highlighter.Highlight();
            }

            if (e.KeyChar == (char)Keys.Enter)  //Adding New Lines To List
            {
                int lineNumber = this.TextBoxEditor.Lines.Length - 1;
                string linetext = TextBoxEditor.Lines[lineNumber - 1];

                Line line = new Line()
                {
                    LineNumber = lineNumber,
                    LineText = linetext
                };

                Lines.Add(line);
            }
        }
    }
}
