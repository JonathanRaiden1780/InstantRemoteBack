using Microsoft.AspNetCore.Mvc;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Contracts.Factories.Common;
using req = InstantRemote.Core.Dtos.Common.Request;
using res = InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Dtos;
using InstantRemote.Core.EntitiesStore.Common;
using Microsoft.AspNetCore.Authorization;

namespace InstantRemote.Api.Controllers.Common
{
    [ApiController]
    [Produces(Constants.ContentType)]
    [Route(Constants.RouteCommon, Name = Constants.Services)]
    public class CommonController : BaseController
    {
        public CommonController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
        }
            

        [HttpGet(Constants.GetReports)]
        [ProducesResponseType(typeof(List<GetParameter>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReports()
        {
            
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetParameterByGroup(Constants.Reportes);
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

        [AllowAnonymous]
        [HttpPost(Constants.Bitacora)]
        [ProducesResponseType( StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult InsertBitacora([FromBodyAttribute] req.BitacoraRequestDto bitacora)
        {

            ActionResult result;
            try
            {
                serviceFactory("IR").ServiceParameter.InsertBitacora(bitacora);
                result = Ok();
            }

            catch (BusinessException busex)
            {
                var trackingCode = new Guid().ToString();
                result = Conflict(new res.FunctionalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { busex.Message }, Url = Redirect404, TrackingCode = trackingCode });
            }
            catch (Exception ex)
            {
                var trackingCode = new Guid().ToString();
                result = StatusCode(StatusCodes.Status500InternalServerError, new res.CriticalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { ex.ToString() }, TrackingCode = trackingCode });
            }
            finally
            {

            }
            return result;
        }

      
    }
}
