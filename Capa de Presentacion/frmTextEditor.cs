using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public partial class frmTextEditor : Form
    {
        public frmTextEditor()
        {
            InitializeComponent();
        }

        // METHODS
        private void SaveFile()
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Save file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(openFileDialog.FileName);
                string richText = richTextBox1.Text;
                sw.WriteLine(richText);
                sw.Close();
            }
            else
            {
                return;
            }
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sw = new StreamReader(openFileDialog.FileName);
                richTextBox1.Text = sw.ReadToEnd();
                sw.Close();
            }
            else
            {
                return;
            }
        }

        private void CheckIfRichTxtIsEmtpy()
        {
            if (richTextBox1.TextLength > 0)
            {
                string message = "¿Quieres guardar los cambios?";
                string caption = "Guardar cambios";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes) { 
              
                    SaveFile();

                }
                else if (result == DialogResult.No) {
                    // richText clear
                    richTextBox1.Clear();
                }
            }
        }

        private void SaveTextFileBeforeClose(FormClosingEventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                string message = "¿Quieres guardar los cambios ante de salir?";
                string caption = "Guardar cambios";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes)
                {
                    SaveFile();
                    
                }
                else if (result == DialogResult.No)
                {
                    // Closes the parent form.
                    e.Cancel = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    // cancel 
                    e.Cancel = true;
                }
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIfRichTxtIsEmtpy();
        }

        private void frmTextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTextFileBeforeClose(e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void printDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }
    }
}
