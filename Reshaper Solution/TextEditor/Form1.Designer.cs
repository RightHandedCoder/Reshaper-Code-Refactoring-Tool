namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.TextBoxError = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBoxEditor
            // 
            this.TextBoxEditor.Location = new System.Drawing.Point(12, 32);
            this.TextBoxEditor.Name = "TextBoxEditor";
            this.TextBoxEditor.Size = new System.Drawing.Size(736, 344);
            this.TextBoxEditor.TabIndex = 0;
            this.TextBoxEditor.Text = "";
            this.TextBoxEditor.TextChanged += new System.EventHandler(this.TextBoxEditor_TextChanged);
            this.TextBoxEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEditor_KeyPress);
            // 
            // TextBoxError
            // 
            this.TextBoxError.Location = new System.Drawing.Point(12, 395);
            this.TextBoxError.Name = "TextBoxError";
            this.TextBoxError.ReadOnly = true;
            this.TextBoxError.Size = new System.Drawing.Size(736, 94);
            this.TextBoxError.TabIndex = 1;
            this.TextBoxError.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 501);
            this.Controls.Add(this.TextBoxError);
            this.Controls.Add(this.TextBoxEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxEditor;
        private System.Windows.Forms.RichTextBox TextBoxError;
    }
}

