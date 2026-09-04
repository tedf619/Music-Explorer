using System.Net;

namespace MusicExplorer
{
    internal class CoverArtArchive: WebService
    {
        public CoverArtArchive() : base("https://coverartarchive.org/")
        {
        }

        public async Task<byte[]?> GetAlbumCoverArtBytesAsync(string releaseGroupId)
        {
            string uri = $"release-group/{releaseGroupId}/front-250";  // 250x250 px front cover image

            using HttpResponseMessage response = await GetAsync(uri);
            if (response.StatusCode == HttpStatusCode.NotFound) return null;
            response.EnsureSuccessStatusCode();

            byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();
            return imageBytes;
        }
    }
}
