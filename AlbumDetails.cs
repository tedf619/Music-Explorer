using System.ComponentModel;

namespace MusicExplorer
{
    public partial class AlbumDetails : UserControl
    {
        Album? album;
        Bitmap? notAvailable;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
        public byte[]? CoverArtBytes { get; set; } = null;

        public AlbumDetails()
        {
            InitializeComponent();

            columnHeaderTrackTitle.Width = -2;  // autosize last column

            notAvailable = Properties.Resources.NotAvailable;
            pictureBoxAlbumCover.Image = notAvailable;
        }
        public void ShowInfo(Album theAlbum)
        {
            album = theAlbum;

            ShowDetails();
            ShowCoverArt();
            ShowTracks();

            textBoxLyrics.Text = string.Empty;
        }

        void ShowDetails()
        {
            if (album == null) return;

            labelTitle.Text = album.Title;
            labelArtist.Text = album.Artist;
            labelLabel.Text = album.Label;
            labelDate.Text = album.Date.ToString("d");
            labelGenre.Text = album.Genre;
        }

        async void ShowCoverArt()
        {
            if (album == null) return;
            if (album.CoverArtBytes == null)
                pictureBoxAlbumCover.Image = notAvailable;
            else
            {
                using var stream = new MemoryStream(album.CoverArtBytes);
                pictureBoxAlbumCover.Image = stream.Length == 0 ? notAvailable : Image.FromStream(stream);
            }
        }

        public void ShowTracks()
        {
            if (album == null) return;

            listViewTracks.Items.Clear();
            int i = 1;
            foreach (Track track in album.Tracks)
            {
                ListViewItem lvi = listViewTracks.Items.Add(i.ToString());
                string duration = string.Empty;
                if (track.Duration != TimeSpan.Zero)
                    duration = string.Format("{0}:{1:00}", track.Duration.Minutes, track.Duration.Seconds);
                lvi.SubItems.Add(duration);
                lvi.SubItems.Add(track.Title);
                lvi.Tag = track;
                i++;
            }
            columnHeaderTrackTitle.Width = -2;  // autosize last column
        }

        public void ShowLyrics(Track track)
        {
            if (track == null) return;
            textBoxLyrics.Text = track.Lyrics.Replace("\n", "\r\n"); // so textbox splits text across lines
        }

        private void ListViewTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTracks.SelectedItems == null) return;
            if (listViewTracks.SelectedItems.Count == 0) return;

            Track? selectedTrack = listViewTracks.SelectedItems[0].Tag as Track;
            if (selectedTrack == null) return;
            FireTrackSelected(selectedTrack);   
        }

        public delegate void TrackHandler(Track track);
        public event TrackHandler? TrackSelected;
        void FireTrackSelected(Track track)
        {
            TrackSelected?.Invoke(track);
        }
    }
}
