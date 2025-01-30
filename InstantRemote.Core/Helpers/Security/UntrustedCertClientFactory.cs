namespace InstantRemote.Core.Helpers.Security
{
    public class UntrustedCertClientFactory 
    {

        public HttpMessageHandler CreateMessageHandler()
        {
            return new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (a, b, c, d) => true
            };
        }
    }
}
