using System.Collections;

namespace MusicExplorer
{
    public class Album
    {
        public string? Id;    // MusicBrainz ReleaseID
        public string? GroupId;  // MusicBrainz ReleaseGroupID
        public string? Title;
        public DateTime Date;
        public byte[]? CoverArtBytes;
        public string? Label;  // e.g. Sony, Warner
        public string? Genre;
        public string? Artist;
        public List<Track> Tracks = new List<Track>();
    }

    public class Track
    {
        public string? Id;     // MusicBrainz ID
        public string? RecordingId;  // MusicBrainz RecordingID
        public int Number;
        public TimeSpan Duration = TimeSpan.Zero;
        public string Title ="";
        public string Artist = "";
        public string Lyrics = "";
    }

    class AlbumComparer : IComparer
    {
        public bool AscendingOrder { get; set; } = true;
        public int ColumnIndex { get; set; } = 0;

        private CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object? x, object? y)
        {
            ListViewItem listviewX = (ListViewItem)x!;
            ListViewItem listviewY = (ListViewItem)y!;

            int compareResult = comparer.Compare(listviewX.SubItems[ColumnIndex].Text, listviewY.SubItems[ColumnIndex].Text);
            return AscendingOrder ? compareResult : -compareResult;
        }
    }
}
