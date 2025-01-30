using System.Text;
using System.IO.Compression;

namespace InstantRemote.Core.Helpers
{
    public static class CompressText
    {
        private static readonly char[] padding = { '=' };
        private static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];
            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static byte[] Zip(this string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public static string Unzip(this byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        public static Stream ConvertStringToStream(this string value)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(value);
            MemoryStream stream = new MemoryStream(byteArray);

            return stream;
        }

        public static string RenderUrlBase64(this string value) =>
            value.Trim(padding).Replace(Constants.Slash, Constants.SlashBase64).Replace(Constants.Plus, Constants.Base64Plus);

        public static string FormatUrlBase64(this string cadena)
        {
            string incoming = cadena.Replace(Constants.SlashBase64, Constants.Slash).Replace(Constants.Base64Plus, Constants.Plus);
            switch (cadena.Length % 4)
            {
                case 2: incoming += Constants.DoubleEqual; break;
                case 3: incoming += Constants.Equal; break;
            }
            return incoming;
        }

        public static int GetAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
    }
}
