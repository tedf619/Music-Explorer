namespace MusicExplorer
{
    public partial class FormMain : Form
    {
        AlbumDetails albumDetails;
        MusicBrainz musicBrainz;
        CoverArtArchive coverArtArchive;
        LrcLib lrcLib;

        public FormMain()
        {
            InitializeComponent();

            // web service for artist, album and track info
            musicBrainz = new MusicBrainz();
            musicBrainz.LogMessage += WebService_LogMessage;
            musicBrainz.LogException += WebService_LogException;
            musicBrainz.ProgressChanged += WebService_ProgressChanged;

            // web service for album cover art
            coverArtArchive = new CoverArtArchive();
            coverArtArchive.LogMessage += WebService_LogMessage;
            coverArtArchive.LogException += WebService_LogException;

            // web service for song lyrics
            lrcLib = new LrcLib();

            albumDetails = new AlbumDetails();
            albumDetails.TrackSelected += AlbumDetails_TrackSelected;
            albumDetails.Dock = DockStyle.Fill;
            panelAlbumDetails.Controls.Add(albumDetails);
            panelAlbumDetails.Visible = false;
            panelLog.Visible = false;

            columnHeaderTitle.Width = -2;  // autosize last column

            textBoxArtist.Text = Properties.Settings.Default.Artist;
        }

        void WebService_ProgressChanged(int value, int total)
        {
            if (value > total)
                value = total;
            progressBar.Value = (int)((double)value / total * 100);
        }

        void WebService_LogMessage(string message)
        {
            AppendColoredText(message, Color.Black);
        }

        void WebService_LogException(Exception ex, string message)
        {
            AppendColoredText(message, Color.Red);
        }

        void AppendColoredText(string text, Color color)
        {
            if (text != string.Empty)
                text = $"{DateTime.Now.ToString("HH:mm:ss.fff")} - {text}";

            richTextBoxLog.SelectionStart = richTextBoxLog.TextLength;
            richTextBoxLog.SelectionLength = 0;
            richTextBoxLog.SelectionColor = color;
            richTextBoxLog.AppendText(text + Environment.NewLine);
        }

        string StatusMessage
        {
            get { return labelStatusBar.Text; }
            set { labelStatusBar.Text = value; labelStatusBar.Update(); }
        }

        async void buttonSearch_Click(object sender, EventArgs e)
        {
            listViewAlbums.Items.Clear();
            panelAlbumDetails.Visible = false;  // we'll make visible it when an album is selected
            richTextBoxLog.Text = string.Empty;
            progressBar.Visible = true;
            WebService_ProgressChanged(0, 100);

            Cursor = Cursors.WaitCursor;
            StatusMessage = "Searching for artist...";
            string? artistId = await musicBrainz.FindArtist(textBoxArtist.Text);
            if (artistId == null)
            {
                Cursor = Cursors.Default;
                StatusMessage = "Artist not found. Keep in mind that artist names are case-sensitive.";
                return;
            }

            Properties.Settings.Default.Artist = textBoxArtist.Text;
            Properties.Settings.Default.Save();

            StatusMessage = "Retrieving albums...";
            List<Album>? albums = await musicBrainz.FindAlbums(artistId, textBoxArtist.Text);
            Cursor = Cursors.Default;

            if (albums == null) return;  // an error occurred while retrieving list

            if (albums.Count == 0)
            {
                Cursor = Cursors.Default;
                StatusMessage = "No albums found";
                progressBar.Visible = false;
                return;
            }

            StatusMessage = string.Format("Albums found: {0}", albums.Count);

            var sortedAlbums = albums
                .OrderBy(p => p.Date)
                .ThenBy(p => p.Title)
                .ToList<Album>();

            listViewAlbums.BeginUpdate();
            foreach (Album album in sortedAlbums)
            {
                string year = album.Date == DateTime.MinValue ? string.Empty : album.Date.Year.ToString();
                ListViewItem lvi = new ListViewItem(year);
                lvi.SubItems.Add(album.Title);
                lvi.Tag = album;
                listViewAlbums.Items.Add(lvi);
            }
            listViewAlbums.EndUpdate();

            columnHeaderTitle.Width = -2;  // autosize last column
            progressBar.Visible = false;
        }

        async void listViewAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAlbums.SelectedItems.Count == 0) return;
            richTextBoxLog.Text = string.Empty;
            ListViewItem lvi = listViewAlbums.SelectedItems[0];
            Album? album = lvi.Tag as Album;
            if (album == null) return;

            UseWaitCursor = true;
            panelAlbumDetails.Visible = false;
            StatusMessage = "Retrieving album info...";

            await musicBrainz.GetDetailedAlbumInfo(album);

            if (album.CoverArtBytes == null)
            {
                StatusMessage = "Retrieving cover art...";
                album.CoverArtBytes = await coverArtArchive.GetAlbumCoverArtBytesAsync(album.GroupId!);
            }

            StatusMessage = string.Empty;
            UseWaitCursor = false;

            albumDetails.ShowInfo(album);
            panelAlbumDetails.Visible = true;
        }

        async void AlbumDetails_TrackSelected(Track track)
        {
            Cursor = Cursors.WaitCursor;
            StatusMessage = "Retrieving lyrics ...";

            track.Lyrics = await lrcLib.GetLyricsForSong(track.Artist, track.Title);

            StatusMessage = "";
            Cursor = Cursors.Default;

            albumDetails.ShowLyrics(track);
        }

        void checkBoxShowLog_CheckedChanged(object sender, EventArgs e)
        {
            panelLog.Visible = checkBoxShowLog.Checked;
        }

        void linkLabelClearLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBoxLog.Clear();
        }

        void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
