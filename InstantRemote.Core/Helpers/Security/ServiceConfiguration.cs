namespace InstantRemote.Core.Helpers.Security
{


    public static class ServiceConfiguration
    {
        /*public static InternalServicesDto GetConfigurationService(this ServiceReferenceDto reference, IUnitOfWork unitOfWork, IMapper mapper)
        {
            var parameters = mapper.Map<ServiceConfigDto>(reference);

            var serviceConfig = unitOfWork.RepositoryParameter.GetInternalServiceConfig(parameters);

            var config = mapper.Map<InternalServicesDto>(serviceConfig);

            return config;
        }*/

       
  /*      public static string DisableSSLValidation(this string url)
        {
            FlurlHttp.ConfigureClient(url, cli => cli.Settings.HttpClientFactory = new UntrustedCertClientFactory());
            return url;
        }*/


        /// <summary>
        /// Use this method for get services unykoo, SalesForce if return value is null Type Reference is not set
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
    

    }
}
