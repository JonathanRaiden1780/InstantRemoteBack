using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.EntitiesStore.Security;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;
using System.Threading.Tasks;
using InstantRemote.Core.Helpers.Security;
using enums = InstantRemote.Core.Enums;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Constants = InstantRemote.Core.Helpers.Constants;

namespace InstantRemote.Api.Middlewares
{
    public class MiddlewareHeaders
    {
        private readonly RequestDelegate next;

        public MiddlewareHeaders(RequestDelegate next) => this.next = next;

        public async Task Invoke(HttpContext ctx, IUnitOfWork unitOfwork)
        {
            try
            {
                var endpoint = ctx.Request.Path.Value.Split(Constants.Slash).Last();

             //   string providerGroup = GetProviderGroup(endpoint);

                switch (endpoint)
                {
                    case Constants.GenerateRedirect:
                    case Constants.IdentityTransfer:
                    case Constants.IdentityTransferTechreo:
//                        await ValidateHeadresProvidersAsync(ctx, unitOfwork, providerGroup, endpoint);
                        break;
                }                


                await this.next.Invoke(ctx);
            }
            catch (Exception ex)
            {
                await this.next.Invoke(ctx);
            }
            finally
            {
            }
        }
        #region Validate Headers provider
    /*    private async Task ValidateHeadresProvidersAsync(HttpContext ctx, IUnitOfWork unitOfwork, string providerGroup, string endpoint)
        {
            int response = 0;
            var headers = new HeadersProvider();
            ctx.Request.Headers.TryGetValue(Constants.UserAccessControl, out StringValues userAccessControl);
            ctx.Request.Headers.TryGetValue(Constants.TchAccessControl, out StringValues tchAccessControl);
            
            var requestContent = ReadRequestBody(ctx.Request).Result;

            unitOfwork.RepositoryProviderLog.AddProviderLog(new Core.EntitiesStore.Common.ProvidersLog
            {
                RequestExId = "AuthController",
                Provider = Constants.ProviderOnsigna,
                Method = endpoint,
                Response = "",
                Request = requestContent
            });            


            if (!String.IsNullOrEmpty(userAccessControl) && !String.IsNullOrEmpty(tchAccessControl))
            {
                headers.UserAccessControl = userAccessControl.ToString().Encrypt();
                headers.TchAccessControl = tchAccessControl.ToString().Encrypt();
                headers.Provider = providerGroup;

                response = unitOfwork.RepositoryProvidersCredentials.ExistsProvider(headers);                
            }


            if (response <= 0)
            {
                ctx.Response.StatusCode = 401;
                ctx.Response.Headers.Add(Constants.XBasicAuth, MessageServices.BadHeaders);
                ctx.Response.ContentType = "application/json";
                _ = ctx.Response.WriteAsync($"{Constants.XBasicAuth} {MessageServices.BadHeaders}");
                await this.next.Invoke(ctx);
            }
        }

        private string GetProviderGroup(string endpoint)
        {
            string providerGroup = null;



            switch (endpoint)
            {
                case Constants.IdentityTransfer:
                    providerGroup = nameof(enums.Providers.Onsigna);
                    break;
                case Constants.WebhookDigipro:
                    providerGroup = nameof(enums.Providers.Digipro);
                    break;
                case Constants.IdentityTransferTechreo:
                    providerGroup = nameof(enums.Providers.Freedom);
                    break;
                case Constants.GenerateRedirect:
                    providerGroup = nameof(enums.Providers.Freedom);
                    break;
            }

            return providerGroup;
        }
*/
        private async Task<string> ReadRequestBody(HttpRequest request)
        {
            HttpRequestRewindExtensions.EnableBuffering(request);
            byte[] buffer = new byte[Convert.ToInt32((object)request.ContentLength)];
            int num = await request.Body.ReadAsync(buffer, 0, buffer.Length);
            string bodyAsText = Encoding.UTF8.GetString(buffer);
            request.Body.Seek(0L, (SeekOrigin)0);
            string str = bodyAsText;
            buffer = (byte[])null;
            bodyAsText = (string)null;
            return str;
        }
        #endregion
    }
}
