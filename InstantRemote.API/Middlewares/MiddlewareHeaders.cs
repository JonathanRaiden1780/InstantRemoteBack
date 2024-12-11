using InstantRemote.Core.Contracts.Factories.Common;
using System.Text;
using InstantRemote.Core.EntitiesStore.Security;
using InstantRemote.Core.Helpers.Security;
using InstantRemote.Core.Messages;
using Microsoft.Extensions.Primitives;
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
