namespace InstantRemote.Core.Fucntions
{
   public static class BuildJson
    {
        public static string BuildJsonDigipro(string data, string values, int count, int whole, string resultData)
        {
            string result = string.Empty;

            if (count == 0)
            {
                if (count == whole)
                    result = "{'" + data + "':'" + values + "'}";
                else
                    result = "{'" + data + "':'" + values + "','";

            }
            else if (count == whole)
            {
                result = resultData + data + "':'" + values + "'}";

            }
            else
            {
                result = resultData + data + "':'" + values + "','";

            }


            return result;
        }
    }
}
