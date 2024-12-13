using Microsoft.AspNetCore.Mvc;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Exceptions;
using Microsoft.AspNetCore.Authorization;
using InstantRemote.Core.Contracts.Factories.Common;
using req = InstantRemote.Core.Dtos.Common.Request;
using res = InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Helpers.Security;
using InstantRemote.Core.Dtos;
using Microsoft.Extensions.Primitives;

namespace InstantRemote.Api.Controllers.security
{
    [ApiController]
    [Produces(Constants.ContentType)]
    [Route(Constants.RouteSecurity, Name = Constants.Authentication)]
    public class AuthController : BaseController
    {
        public AuthController(IServiceFactorySecurity serviceFactory,  IConfiguration configuration) : base(serviceFactory,  configuration)
        {
        }

        [AllowAnonymous]
        [HttpPost(Constants.SignIn)]
        [ProducesResponseType(typeof(res.TokenRespDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult SignIn([FromBody]req.SingInReqDto singInDto)
        {
            
            ActionResult result;
            try
            {
                var response = serviceFactorySecurity.ServiceAuth.SignIn(singInDto);
                result = Ok(response);
            }
           
            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { busex.Message }, Url = Redirect404, TrackingCode = trackingCode });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError, new res.CriticalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { ex .ToString()}, TrackingCode = trackingCode });
            }
            finally
            {
                
            }
            return result;
        }
        
        [HttpPost(Constants.ValidateToken)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult ValidateToken([FromBody] req.ValidateTokenDto tokenDto)
        {
            ActionResult result = null;
            try
            {
                Request.Headers.TryGetValue(Constants.Authorization, out StringValues token);
                tokenDto.Token = token.ToString().Split(" ").Last();

                serviceFactorySecurity.ServiceAuth.ValidateToken(tokenDto);
                return Ok();
            }
            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { busex.Message }, Url = Redirect404, TrackingCode = trackingCode });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError, new res.CriticalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { Constants.InternalServerError }, TrackingCode = trackingCode });
            }
            finally
            {
                
            }
            return result;
        }


        [AllowAnonymous]
        [HttpGet(Constants.Encrypt)]
        private ActionResult Encrypt([FromQuery] string value)
        {

            
            ActionResult result;
            try
            {
                var key = Environment.GetEnvironmentVariable("SecurityManagerKey");
                if (key == null)
                {
                   // eventLog.RegistrarError(new BusinessException($"ERROR VARIABLES DE ENTORNO SecurityManagerKey: {key}"));
                }

                result = Ok(value.Decrypt());
            }

            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { busex.Message }, Url = Redirect404, TrackingCode = trackingCode });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError, new res.CriticalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { Constants.InternalServerError }, TrackingCode = trackingCode });
            }
            finally
            {
                
            }
            return result;
        }
    }
}
