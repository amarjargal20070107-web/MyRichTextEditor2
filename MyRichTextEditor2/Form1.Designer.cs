namespace MyRichTextEditor2
{
    partial class frmRichTextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>/
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
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            seperatorToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            findNextToolStripMenuItem = new ToolStripMenuItem();
           
            formatToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            fontsToolStripMenuItem = new ToolStripMenuItem();
            alignmentToolStripMenuItem = new ToolStripMenuItem();
            leftToolStripMenuItem = new ToolStripMenuItem();
            centerToolStripMenuItem = new ToolStripMenuItem();
            rightToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(613, 416);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(613, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem, seperatorToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(157, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(157, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(157, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // seperatorToolStripMenuItem
            // 
            seperatorToolStripMenuItem.Name = "seperatorToolStripMenuItem";
            seperatorToolStripMenuItem.Size = new Size(157, 26);
            seperatorToolStripMenuItem.Text = "Seperator";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem, findToolStripMenuItem, findNextToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(151, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(151, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(151, 26);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.Size = new Size(151, 26);
            findNextToolStripMenuItem.Text = "FindNext";
            findNextToolStripMenuItem.Click += findNextToolStripMenuItem_Click;
            // 
            // findNextTextToolStripMenuItem
            // 
           
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorsToolStripMenuItem, fontsToolStripMenuItem, alignmentToolStripMenuItem, leftToolStripMenuItem, centerToolStripMenuItem, rightToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(73, 24);
            formatToolStripMenuItem.Text = "Format:";
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(161, 26);
            colorsToolStripMenuItem.Text = "Colors";
            colorsToolStripMenuItem.Click += colorsToolStripMenuItem_Click;
            // 
            // fontsToolStripMenuItem
            // 
            fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            fontsToolStripMenuItem.Size = new Size(161, 26);
            fontsToolStripMenuItem.Text = "Fonts";
            fontsToolStripMenuItem.Click += fontsToolStripMenuItem_Click;
            // 
            // alignmentToolStripMenuItem
            // 
            alignmentToolStripMenuItem.Name = "alignmentToolStripMenuItem";
            alignmentToolStripMenuItem.Size = new Size(161, 26);
            alignmentToolStripMenuItem.Text = "Alignment";
            alignmentToolStripMenuItem.Click += alignmentToolStripMenuItem_Click;
            // 
            // leftToolStripMenuItem
            // 
            leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            leftToolStripMenuItem.Size = new Size(161, 26);
            leftToolStripMenuItem.Text = "Left";
            leftToolStripMenuItem.Click += leftToolStripMenuItem_Click;
            // 
            // centerToolStripMenuItem
            // 
            centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            centerToolStripMenuItem.Size = new Size(161, 26);
            centerToolStripMenuItem.Text = "Center";
            centerToolStripMenuItem.Click += centerToolStripMenuItem_Click;
            // 
            // rightToolStripMenuItem
            // 
            rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            rightToolStripMenuItem.Size = new Size(161, 26);
            rightToolStripMenuItem.Text = "Right";
            rightToolStripMenuItem.Click += rightToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(160, 26);
            zoomInToolStripMenuItem.Text = "Zoom in";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(160, 26);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(613, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(130, 20);
            toolStripStatusLabel1.Text = "Мөр: 1 | Багана: 1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(132, 20);
            toolStripStatusLabel2.Text = "Тэмдэгтийн тоо: 0";
            // 
            // frmRichTextEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 444);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmRichTextEditor";
            Text = "My Rich Text Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem findNextToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem fontsToolStripMenuItem;
        private ToolStripMenuItem alignmentToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem centerToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem seperatorToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripStatusLabel toolStripStatusLabel1;
       
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}
