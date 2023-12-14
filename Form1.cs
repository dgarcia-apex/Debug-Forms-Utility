using DefaultRunspaceStarter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Debug_Forms_Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void replaceButton_ClickAsync(object sender, EventArgs e)
        {
            if (inputListBox.Items.Count <= 0)
            {
                MessageBox.Show("Add Items to Input List Box!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (outputListBox.Items.Count <= 0)
            {
                MessageBox.Show("Add Items to Output List Box!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            psOutputTextBox.Text = string.Empty;

            foreach (var output in outputListBox.Items)
            {

                foreach (var input in inputListBox.Items)
                {
                    var scriptContents = new StringBuilder();
                    scriptContents.AppendLine("$input=\"" + input + "\";");
                    scriptContents.AppendLine("$output=\"" + output + "\";");
                    scriptContents.AppendLine("");
                    scriptContents.AppendLine("Write-Output \"Starting script\"");
                    scriptContents.AppendLine("Write-Output \"input:\"");
                    scriptContents.AppendLine("Write-Output $input");
                    scriptContents.AppendLine("Write-Output \"output:\"");
                    scriptContents.AppendLine("Write-Output $output");
                    scriptContents.AppendLine("cd $input;");
                    scriptContents.AppendLine("$inputItems = (Get-ChildItem | ForEach-Object { '{0}{1}' -f $_.BaseName, $_.Extension });");
                    scriptContents.AppendLine("");
                    scriptContents.AppendLine("cd $output;");
                    scriptContents.AppendLine("$outputItems = (Get-ChildItem | ForEach-Object { '{0}{1}' -f $_.BaseName, $_.Extension });");
                    scriptContents.AppendLine("foreach ($f in $inputItems) {");
                    scriptContents.AppendLine("if($outputItems -contains$f)");
                    scriptContents.AppendLine("{ Copy-Item -Path $input\\$f -Destination $output\\$f -Force;");
                    scriptContents.AppendLine("try { $tempF = $f.Replace(\"dll\",\"pdb\");");
                    scriptContents.AppendLine("Copy-Item -Path $input\\$tempF -Destination $output\\$tempF -Force -ErrorAction stop;}");
                    scriptContents.AppendLine("catch{");
                    scriptContents.AppendLine(" # Catch any error");
                    scriptContents.AppendLine("}");
                    scriptContents.AppendLine("}");
                    scriptContents.AppendLine("}");
                    scriptContents.AppendLine("Write-Output \"Ending script\"");

                    var hosted = new HostedRunspace();
                    string scriptOutput = await hosted.RunScript(scriptContents.ToString());
                    psOutputTextBox.Text += scriptOutput;
                }
            }
        }

        private void inputAddButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    inputListBox.Items.Add(fbd.SelectedPath);
                }
            }
        }

        private void inputRemoveButton_Click(object sender, EventArgs e)
        {
            if (inputListBox.Items.Count <= 0)
            {
                MessageBox.Show("Add Items to Input List Box!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inputListBox.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select Items to Remove from Input List Box!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            inputListBox.Items.Remove(inputListBox.SelectedItem);
        }

        private void outputAddButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    outputListBox.Items.Add(fbd.SelectedPath);
                }
            }
        }

        private void outputRemoveButton_Click(object sender, EventArgs e)
        {
            if (outputListBox.Items.Count <= 0)
            {
                MessageBox.Show("Add Items to Output List Box!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (outputListBox.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select Items to Remove from Output List Box!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            outputListBox.Items.Remove(outputListBox.SelectedItem);
        }
    }
}