namespace MusicExplorer
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            panelTop = new Panel();
            checkBoxShowLog = new CheckBox();
            buttonSearch = new Button();
            textBoxArtist = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileExitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpAboutToolStripMenuItem = new ToolStripMenuItem();
            labelStatusBar = new Label();
            panelMiddle = new Panel();
            panelAlbumDetails = new Panel();
            splitter2 = new Splitter();
            panelLog = new Panel();
            linkLabelClearLog = new LinkLabel();
            richTextBoxLog = new RichTextBox();
            label3 = new Label();
            splitter1 = new Splitter();
            panelLeft = new Panel();
            listViewAlbums = new ListView();
            columnHeaderYear = new ColumnHeader();
            columnHeaderTitle = new ColumnHeader();
            label2 = new Label();
            panelBottom = new Panel();
            progressBar = new ProgressBar();
            toolTip1 = new ToolTip(components);
            panelTop.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelLog.SuspendLayout();
            panelLeft.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(checkBoxShowLog);
            panelTop.Controls.Add(buttonSearch);
            panelTop.Controls.Add(textBoxArtist);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(menuStrip1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(948, 83);
            panelTop.TabIndex = 0;
            // 
            // checkBoxShowLog
            // 
            checkBoxShowLog.AutoSize = true;
            checkBoxShowLog.Location = new Point(650, 43);
            checkBoxShowLog.Name = "checkBoxShowLog";
            checkBoxShowLog.Size = new Size(78, 19);
            checkBoxShowLog.TabIndex = 3;
            checkBoxShowLog.Text = "Show Log";
            toolTip1.SetToolTip(checkBoxShowLog, "Shows a log of the HTTP traffic with the various web services called");
            checkBoxShowLog.UseVisualStyleBackColor = true;
            checkBoxShowLog.CheckedChanged += checkBoxShowLog_CheckedChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(555, 39);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            toolTip1.SetToolTip(buttonSearch, "Enter an artist name to search for all the released albums");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(58, 39);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(491, 23);
            textBoxArtist.TabIndex = 3;
            textBoxArtist.Text = "Yes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Artist:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(948, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // fileExitToolStripMenuItem
            // 
            fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            fileExitToolStripMenuItem.Size = new Size(93, 22);
            fileExitToolStripMenuItem.Text = "E&xit";
            fileExitToolStripMenuItem.Click += fileExitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpAboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // helpAboutToolStripMenuItem
            // 
            helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            helpAboutToolStripMenuItem.Size = new Size(116, 22);
            helpAboutToolStripMenuItem.Text = "&About...";
            helpAboutToolStripMenuItem.Click += helpAboutToolStripMenuItem_Click;
            // 
            // labelStatusBar
            // 
            labelStatusBar.Dock = DockStyle.Fill;
            labelStatusBar.Location = new Point(0, 0);
            labelStatusBar.Name = "labelStatusBar";
            labelStatusBar.Size = new Size(752, 20);
            labelStatusBar.TabIndex = 1;
            labelStatusBar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMiddle
            // 
            panelMiddle.BorderStyle = BorderStyle.FixedSingle;
            panelMiddle.Controls.Add(panelAlbumDetails);
            panelMiddle.Controls.Add(splitter2);
            panelMiddle.Controls.Add(panelLog);
            panelMiddle.Controls.Add(splitter1);
            panelMiddle.Controls.Add(panelLeft);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 83);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(948, 458);
            panelMiddle.TabIndex = 2;
            // 
            // panelAlbumDetails
            // 
            panelAlbumDetails.Dock = DockStyle.Fill;
            panelAlbumDetails.Location = new Point(234, 0);
            panelAlbumDetails.Name = "panelAlbumDetails";
            panelAlbumDetails.Size = new Size(377, 456);
            panelAlbumDetails.TabIndex = 5;
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Right;
            splitter2.Location = new Point(611, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 456);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // panelLog
            // 
            panelLog.Controls.Add(linkLabelClearLog);
            panelLog.Controls.Add(richTextBoxLog);
            panelLog.Controls.Add(label3);
            panelLog.Dock = DockStyle.Right;
            panelLog.Location = new Point(614, 0);
            panelLog.Name = "panelLog";
            panelLog.Size = new Size(332, 456);
            panelLog.TabIndex = 3;
            // 
            // linkLabelClearLog
            // 
            linkLabelClearLog.AutoSize = true;
            linkLabelClearLog.BackColor = Color.Blue;
            linkLabelClearLog.LinkColor = Color.White;
            linkLabelClearLog.Location = new Point(262, 4);
            linkLabelClearLog.Name = "linkLabelClearLog";
            linkLabelClearLog.Size = new Size(57, 15);
            linkLabelClearLog.TabIndex = 3;
            linkLabelClearLog.TabStop = true;
            linkLabelClearLog.Text = "Clear Log";
            linkLabelClearLog.LinkClicked += linkLabelClearLog_LinkClicked;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Dock = DockStyle.Fill;
            richTextBoxLog.Location = new Point(0, 23);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.Size = new Size(332, 433);
            richTextBoxLog.TabIndex = 2;
            richTextBoxLog.Text = "";
            // 
            // label3
            // 
            label3.BackColor = Color.Blue;
            label3.Dock = DockStyle.Top;
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(332, 23);
            label3.TabIndex = 1;
            label3.Text = "HTTP Log";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(231, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 456);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(listViewAlbums);
            panelLeft.Controls.Add(label2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(231, 456);
            panelLeft.TabIndex = 0;
            // 
            // listViewAlbums
            // 
            listViewAlbums.Columns.AddRange(new ColumnHeader[] { columnHeaderYear, columnHeaderTitle });
            listViewAlbums.Dock = DockStyle.Fill;
            listViewAlbums.FullRowSelect = true;
            listViewAlbums.Location = new Point(0, 23);
            listViewAlbums.Name = "listViewAlbums";
            listViewAlbums.Size = new Size(231, 433);
            listViewAlbums.TabIndex = 1;
            listViewAlbums.UseCompatibleStateImageBehavior = false;
            listViewAlbums.View = View.Details;
            listViewAlbums.SelectedIndexChanged += listViewAlbums_SelectedIndexChanged;
            // 
            // columnHeaderYear
            // 
            columnHeaderYear.Text = "Year";
            // 
            // columnHeaderTitle
            // 
            columnHeaderTitle.Text = "Title";
            columnHeaderTitle.Width = 100;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(231, 23);
            label2.TabIndex = 0;
            label2.Text = "Albums";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(labelStatusBar);
            panelBottom.Controls.Add(progressBar);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 541);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(948, 22);
            panelBottom.TabIndex = 3;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Right;
            progressBar.Location = new Point(752, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(194, 20);
            progressBar.TabIndex = 2;
            progressBar.Visible = false;
            // 
            // FormMain
            // 
            AcceptButton = buttonSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 563);
            Controls.Add(panelMiddle);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Explorer";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelMiddle.ResumeLayout(false);
            panelLog.ResumeLayout(false);
            panelLog.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private MenuStrip menuStrip1;
        private Label labelStatusBar;
        private Panel panelMiddle;
        private Panel panelLeft;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileExitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpAboutToolStripMenuItem;
        private Button buttonSearch;
        private TextBox textBoxArtist;
        private Label label1;
        private ListView listViewAlbums;
        private ColumnHeader columnHeaderYear;
        private ColumnHeader columnHeaderTitle;
        private Label label2;
        private Splitter splitter1;
        private Panel panelLog;
        private Panel panelAlbumDetails;
        private Splitter splitter2;
        private CheckBox checkBoxShowLog;
        private Label label3;
        private RichTextBox richTextBoxLog;
        private LinkLabel linkLabelClearLog;
        private Panel panelBottom;
        private ProgressBar progressBar;
        private ToolTip toolTip1;
    }
}
