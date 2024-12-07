using System.Text;
using System.Security.Cryptography;

namespace InstantRemote.Core.Helpers.Security
{
    public static class SecurityManager
    {
        private static readonly string SecretKey = Environment.GetEnvironmentVariable(Constants.SecurityManager);

        public static string RandomString {
            get {

                Random random = new Random();
                int length = random.Next(1, 15);
                const string chars = Constants.Char;
                return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            } 
        }
        public static string RandomSeed(this string seed) => $"{seed}|{RandomString}";

        public static string GetSeed(this string seed) 
        {
            int startChar = 0;
            var endChar = seed.IndexOf(Constants.Pipe);
            var seedSubString = seed.Substring(startChar, endChar);

            return seedSubString;
        }

        public static string Encrypt(this string plainText)
        {
            if (plainText == null)
            {
                return null;
            }
            var bytesToBeEncrypted = Encoding.UTF8.GetBytes(plainText);
            var passwordBytes = Encoding.UTF8.GetBytes(SecretKey);

            passwordBytes = SHA512.Create().ComputeHash(passwordBytes);

            var bytesEncrypted = Encrypt(bytesToBeEncrypted, passwordBytes);
            var renderUrlBase64 = Convert.ToBase64String(bytesEncrypted).RenderUrlBase64();
            var stringCompress = renderUrlBase64.Zip();
            var secondBytesEncrypted = Encrypt(stringCompress, passwordBytes);

            return Convert.ToBase64String(secondBytesEncrypted).RenderUrlBase64();
        }

        public static string Decrypt(this string encryptedText)
        {
            if (encryptedText == null)
                return null;

            var passwordBytes = Encoding.UTF8.GetBytes(SecretKey);
            passwordBytes = SHA512.Create().ComputeHash(passwordBytes);

            encryptedText = encryptedText.FormatUrlBase64();

            var stringUnCompress = Convert.FromBase64String(encryptedText);
            var bytesDecrypted = Decrypt(stringUnCompress, passwordBytes);

            var text = bytesDecrypted.Unzip();


            var bytesToBeDecrypted = Convert.FromBase64String(text.FormatUrlBase64());
            bytesDecrypted = Decrypt(bytesToBeDecrypted, passwordBytes);

            return Encoding.UTF8.GetString(bytesDecrypted);
        }
        private static byte[] Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using RijndaelManaged AES = new RijndaelManaged();
#pragma warning disable S2053 // Hashes should include an unpredictable salt
                var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
#pragma warning restore S2053 // Hashes should include an unpredictable salt

                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                AES.Mode = CipherMode.CBC;

                using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                    cs.Close();
                }

                encryptedBytes = ms.ToArray();
            }

            return encryptedBytes;
        }
        private static byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using RijndaelManaged AES = new RijndaelManaged();
#pragma warning disable S2053 // Hashes should include an unpredictable salt
                var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
#pragma warning restore S2053 // Hashes should include an unpredictable salt

                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Mode = CipherMode.CBC;

                using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                    cs.Close();
                }

                decryptedBytes = ms.ToArray();
            }

            return decryptedBytes;
        }

    }
}
