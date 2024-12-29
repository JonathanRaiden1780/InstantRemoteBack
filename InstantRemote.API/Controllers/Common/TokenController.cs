using Microsoft.AspNetCore.Mvc;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Contracts.Factories.Common;
using res = InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Dtos;

namespace InstantRemote.Api.Controllers.Common
{
    [ApiController]
    [Produces(Constants.ContentType)]
    [Route(Constants.RouteToken, Name = Constants.TokenC)]
    public class TokenController : BaseController
    {
        public TokenController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
        }

        [HttpGet(Constants.GetCatalogoToken)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetCatalogoToken(string emplid)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.GetCatalogoToken(emplid);
                result = Ok(response);
            }

            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto
                {
                    Origin = Constants.OriginService, Message = new[] {busex.Message}, Url = Redirect404,
                    TrackingCode = trackingCode
                });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError,
                    new res.CriticalErrorMessageDto
                    {
                        Origin = Constants.OriginService, Message = new[] {ex.ToString()}, TrackingCode = trackingCode
                    });
            }
            finally
            {
            }

            return result;
        }
        
        [HttpPatch(Constants.LiberaToken)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult LiberaToken([FromBody] res.TokenMod token)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.LiberaToken(token);
                result = Ok(response);
            }

            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto
                {
                    Origin = Constants.OriginService, Message = new[] {busex.Message}, Url = Redirect404,
                    TrackingCode = trackingCode
                });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError,
                    new res.CriticalErrorMessageDto
                    {
                        Origin = Constants.OriginService, Message = new[] {ex.ToString()}, TrackingCode = trackingCode
                    });
            }
            finally
            {
            }

            return result;
        }
        
        [HttpPost(Constants.DeleteToken)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteToken([FromBody] res.TokenMod token)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.DeleteToken(token);
                result = Ok(response);
            }

            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto
                {
                    Origin = Constants.OriginService, Message = new[] {busex.Message}, Url = Redirect404,
                    TrackingCode = trackingCode
                });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError,
                    new res.CriticalErrorMessageDto
                    {
                        Origin = Constants.OriginService, Message = new[] {ex.ToString()}, TrackingCode = trackingCode
                    });
            }
            finally
            {
            }

            return result;
        }
        
        [HttpPost(Constants.SaveToken)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult SaveToken([FromBody] res.TokenAdd token)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.SaveToken(token);
                result = Ok(response);
            }

            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto
                {
                    Origin = Constants.OriginService, Message = new[] {busex.Message}, Url = Redirect404,
                    TrackingCode = trackingCode
                });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError,
                    new res.CriticalErrorMessageDto
                    {
                        Origin = Constants.OriginService, Message = new[] {ex.ToString()}, TrackingCode = trackingCode
                    });
            }
            finally
            {
            }

            return result;
        }
        
               
    }
}