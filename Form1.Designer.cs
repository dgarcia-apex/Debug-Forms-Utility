namespace Debug_Forms_Utility
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputListBox = new ListBox();
            outputListBox = new ListBox();
            inputAddButton = new Button();
            inputRemoveButton = new Button();
            outputRemoveButton = new Button();
            outputAddButton = new Button();
            replaceButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            psOutputTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // inputListBox
            // 
            inputListBox.FormattingEnabled = true;
            inputListBox.ItemHeight = 20;
            inputListBox.Location = new Point(11, 39);
            inputListBox.Name = "inputListBox";
            inputListBox.Size = new Size(317, 324);
            inputListBox.TabIndex = 0;
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 20;
            outputListBox.Location = new Point(469, 39);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(319, 324);
            outputListBox.TabIndex = 1;
            // 
            // inputAddButton
            // 
            inputAddButton.Location = new Point(273, 369);
            inputAddButton.Name = "inputAddButton";
            inputAddButton.Size = new Size(56, 29);
            inputAddButton.TabIndex = 2;
            inputAddButton.Text = "+";
            inputAddButton.UseVisualStyleBackColor = true;
            inputAddButton.Click += inputAddButton_Click;
            // 
            // inputRemoveButton
            // 
            inputRemoveButton.Location = new Point(211, 369);
            inputRemoveButton.Name = "inputRemoveButton";
            inputRemoveButton.Size = new Size(56, 29);
            inputRemoveButton.TabIndex = 3;
            inputRemoveButton.Text = "-";
            inputRemoveButton.UseVisualStyleBackColor = true;
            inputRemoveButton.Click += inputRemoveButton_Click;
            // 
            // outputRemoveButton
            // 
            outputRemoveButton.Location = new Point(670, 369);
            outputRemoveButton.Name = "outputRemoveButton";
            outputRemoveButton.Size = new Size(56, 29);
            outputRemoveButton.TabIndex = 5;
            outputRemoveButton.Text = "-";
            outputRemoveButton.UseVisualStyleBackColor = true;
            outputRemoveButton.Click += outputRemoveButton_Click;
            // 
            // outputAddButton
            // 
            outputAddButton.Location = new Point(731, 369);
            outputAddButton.Name = "outputAddButton";
            outputAddButton.Size = new Size(56, 29);
            outputAddButton.TabIndex = 4;
            outputAddButton.Text = "+";
            outputAddButton.UseVisualStyleBackColor = true;
            outputAddButton.Click += outputAddButton_Click;
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(690, 631);
            replaceButton.Margin = new Padding(3, 4, 3, 4);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(97, 31);
            replaceButton.TabIndex = 6;
            replaceButton.Text = "Replace Files";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += replaceButton_ClickAsync;
            // 
            // psOutputTextBox
            // 
            psOutputTextBox.Location = new Point(12, 442);
            psOutputTextBox.Multiline = true;
            psOutputTextBox.Name = "psOutputTextBox";
            psOutputTextBox.Size = new Size(776, 182);
            psOutputTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 419);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 8;
            label1.Text = "PowerShell Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 675);
            Controls.Add(label1);
            Controls.Add(psOutputTextBox);
            Controls.Add(replaceButton);
            Controls.Add(outputRemoveButton);
            Controls.Add(outputAddButton);
            Controls.Add(inputRemoveButton);
            Controls.Add(inputAddButton);
            Controls.Add(outputListBox);
            Controls.Add(inputListBox);
            Name = "Form1";
            Text = "Replace Files Utility";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox inputListBox;
        private ListBox outputListBox;
        private Button inputAddButton;
        private Button inputRemoveButton;
        private Button outputRemoveButton;
        private Button outputAddButton;
        private Button replaceButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox psOutputTextBox;
        private Label label1;
    }
}