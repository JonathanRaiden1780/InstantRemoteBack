using System.Net;
using Microsoft.AspNetCore.Http;

namespace InstantRemote.Core.Helpers
{
    public static class Files
    {
        public static Stream ConvertBase64ToStream(this string base64encodedstring)
        {
            var bytes = Convert.FromBase64String(base64encodedstring);
            var stream = new MemoryStream(bytes);

            return stream;
        }

        public static Byte[] ConvertBase64ToBytes(this IFormFile fromFile)
        {
            MemoryStream memoryStream = new MemoryStream();
            fromFile.CopyTo((Stream)memoryStream);

            return memoryStream.ToArray();
        }

        public static string UrlToBase64(string url)
        {
            string base64String = "";

            using (WebClient client = new WebClient())
            {
                var bytes = client.DownloadData(url);
                base64String = Convert.ToBase64String(bytes);
            }
            return base64String;
        }

       


    }
}
