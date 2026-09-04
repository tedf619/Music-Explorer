namespace MusicExplorer
{
    partial class AlbumDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            pictureBoxAlbumCover = new PictureBox();
            labelDate = new Label();
            label12 = new Label();
            labelGenre = new Label();
            label10 = new Label();
            labelLabel = new Label();
            label8 = new Label();
            labelArtist = new Label();
            label6 = new Label();
            labelTitle = new Label();
            label3 = new Label();
            label2 = new Label();
            panelMiddle = new Panel();
            panelLyrics = new Panel();
            textBoxLyrics = new TextBox();
            label1 = new Label();
            splitter1 = new Splitter();
            panelTracks = new Panel();
            listViewTracks = new ListView();
            columnHeaderTrack = new ColumnHeader();
            columnHeaderDuration = new ColumnHeader();
            columnHeaderTrackTitle = new ColumnHeader();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumCover).BeginInit();
            panelMiddle.SuspendLayout();
            panelLyrics.SuspendLayout();
            panelTracks.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBoxAlbumCover);
            panelTop.Controls.Add(labelDate);
            panelTop.Controls.Add(label12);
            panelTop.Controls.Add(labelGenre);
            panelTop.Controls.Add(label10);
            panelTop.Controls.Add(labelLabel);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(labelArtist);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(labelTitle);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(375, 123);
            panelTop.TabIndex = 0;
            // 
            // pictureBoxAlbumCover
            // 
            pictureBoxAlbumCover.Location = new Point(279, 32);
            pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            pictureBoxAlbumCover.Size = new Size(88, 82);
            pictureBoxAlbumCover.TabIndex = 2;
            pictureBoxAlbumCover.TabStop = false;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(56, 94);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(85, 15);
            labelDate.TabIndex = 12;
            labelDate.Text = "<release date>";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 94);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 11;
            label12.Text = "Date:";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(56, 79);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(95, 15);
            labelGenre.TabIndex = 10;
            labelGenre.Text = "<type of music>";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 79);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 9;
            label10.Text = "Genre:";
            // 
            // labelLabel
            // 
            labelLabel.AutoSize = true;
            labelLabel.Location = new Point(56, 64);
            labelLabel.Name = "labelLabel";
            labelLabel.Size = new Size(102, 15);
            labelLabel.TabIndex = 8;
            labelLabel.Text = "<recording label>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 64);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "Label:";
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(59, 34);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(82, 15);
            labelArtist.TabIndex = 6;
            labelArtist.Text = "<artist name>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 34);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Artist:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(56, 49);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(80, 15);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "<album title>";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 49);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Title:";
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(375, 23);
            label2.TabIndex = 1;
            label2.Text = "Album Details";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMiddle
            // 
            panelMiddle.Controls.Add(panelLyrics);
            panelMiddle.Controls.Add(splitter1);
            panelMiddle.Controls.Add(panelTracks);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 123);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(375, 342);
            panelMiddle.TabIndex = 1;
            // 
            // panelLyrics
            // 
            panelLyrics.Controls.Add(textBoxLyrics);
            panelLyrics.Controls.Add(label1);
            panelLyrics.Dock = DockStyle.Fill;
            panelLyrics.Location = new Point(0, 180);
            panelLyrics.Name = "panelLyrics";
            panelLyrics.Size = new Size(375, 162);
            panelLyrics.TabIndex = 3;
            // 
            // textBoxLyrics
            // 
            textBoxLyrics.BackColor = SystemColors.Control;
            textBoxLyrics.Dock = DockStyle.Fill;
            textBoxLyrics.Location = new Point(0, 23);
            textBoxLyrics.Multiline = true;
            textBoxLyrics.Name = "textBoxLyrics";
            textBoxLyrics.ScrollBars = ScrollBars.Vertical;
            textBoxLyrics.Size = new Size(375, 139);
            textBoxLyrics.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.Blue;
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(375, 23);
            label1.TabIndex = 3;
            label1.Text = "Lyrics";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 175);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(375, 5);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panelTracks
            // 
            panelTracks.Controls.Add(listViewTracks);
            panelTracks.Dock = DockStyle.Top;
            panelTracks.Location = new Point(0, 0);
            panelTracks.Name = "panelTracks";
            panelTracks.Size = new Size(375, 175);
            panelTracks.TabIndex = 0;
            // 
            // listViewTracks
            // 
            listViewTracks.BackColor = SystemColors.Control;
            listViewTracks.Columns.AddRange(new ColumnHeader[] { columnHeaderTrack, columnHeaderDuration, columnHeaderTrackTitle });
            listViewTracks.Dock = DockStyle.Fill;
            listViewTracks.FullRowSelect = true;
            listViewTracks.Location = new Point(0, 0);
            listViewTracks.MultiSelect = false;
            listViewTracks.Name = "listViewTracks";
            listViewTracks.Size = new Size(375, 175);
            listViewTracks.TabIndex = 1;
            listViewTracks.UseCompatibleStateImageBehavior = false;
            listViewTracks.View = View.Details;
            listViewTracks.SelectedIndexChanged += ListViewTracks_SelectedIndexChanged;
            // 
            // columnHeaderTrack
            // 
            columnHeaderTrack.Text = "Track";
            // 
            // columnHeaderDuration
            // 
            columnHeaderDuration.Text = "Duration";
            columnHeaderDuration.Width = 80;
            // 
            // columnHeaderTrackTitle
            // 
            columnHeaderTrackTitle.Text = "Title";
            columnHeaderTrackTitle.Width = 200;
            // 
            // AlbumDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMiddle);
            Controls.Add(panelTop);
            Name = "AlbumDetails";
            Size = new Size(375, 465);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbumCover).EndInit();
            panelMiddle.ResumeLayout(false);
            panelLyrics.ResumeLayout(false);
            panelLyrics.PerformLayout();
            panelTracks.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelMiddle;
        private PictureBox pictureBoxAlbumCover;
        private Label label2;
        private Label labelTitle;
        private Label label3;
        private Label labelDate;
        private Label label12;
        private Label labelGenre;
        private Label label10;
        private Label labelLabel;
        private Label label8;
        private Label labelArtist;
        private Label label6;
        private Panel panelTracks;
        private ListView listViewTracks;
        private ColumnHeader columnHeaderTrack;
        private ColumnHeader columnHeaderDuration;
        private ColumnHeader columnHeaderTrackTitle;
        private Panel panelLyrics;
        private TextBox textBoxLyrics;
        private Label label1;
        private Splitter splitter1;
    }
}
