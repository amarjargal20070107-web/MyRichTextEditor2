
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyRichTextEditor2
{

    public partial class frmRichTextEditor : Form
    {
        string searchText = "";
        int searchIndex = 0;
        ColorDialog colorDialog1 = new ColorDialog();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(
                    openFileDialog1.FileName,
                    RichTextBoxStreamType.PlainText
                );

                this.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);
            }
        }
        
        public frmRichTextEditor()
        {
            InitializeComponent();
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;

            this.Text = "My Rich Text Editor";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            }
        

        private void richTextBox1_TextChanged(object? sender, EventArgs e)
        {
            toolStripStatusLabel2.Text =
        "Тэмдэгтийн тоо: " + richTextBox1.Text.Length;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(
                    saveFileDialog1.FileName,
                    RichTextBoxStreamType.PlainText
                );
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Copy();

            pasteToolStripMenuItem.Enabled = true;
        }



        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }
        private void alignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 5)
                richTextBox1.ZoomFactor += 0.5f;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.5f)
                richTextBox1.ZoomFactor -= 0.5f;
        }
        private void richTextBox1_SelectionChanged(object? sender, EventArgs e)
        {
            int position = richTextBox1.SelectionStart;

            int line = richTextBox1.GetLineFromCharIndex(position);

            int firstChar = richTextBox1.GetFirstCharIndexFromLine(line);

            int column = position - firstChar;

            toolStripStatusLabel1.Text =
                "Мөр: " + (line + 1) +
                " | Багана: " + (column + 1);
        }

       

        private void findToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            searchText = Microsoft.VisualBasic.Interaction.InputBox(
                "Хайх үгээ оруулна уу:",
                "Find");

            searchIndex = 0;
            FindNextText();
        }

        private void findNextToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FindNextText();
        }

        private void FindNextText()
        {
            if (string.IsNullOrEmpty(searchText))
                return;

            int found = richTextBox1.Find(
                searchText,
                searchIndex,
                RichTextBoxFinds.None);

            if (found >= 0)
            {
                richTextBox1.Select(found, searchText.Length);
                richTextBox1.Focus();
                searchIndex = found + searchText.Length;
            }
            else
            {
                MessageBox.Show("Текст олдсонгүй!");
                searchIndex = 0;
            }
        }
            private void findNextTextToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FindNextText();
        }
    }
    }
