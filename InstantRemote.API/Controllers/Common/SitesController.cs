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
    [Route(Constants.RouteSites, Name = Constants.Sites)]
    public class SitesController : BaseController
    {
        public SitesController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
        }

        [HttpGet(Constants.GetSites)]
        [ProducesResponseType(typeof(List<res.GetSitesRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetSites(int emplid, string parameter)
        {

            ActionResult result;
            try
            {
                //listaSucursalesCombo
                var response = serviceFactory("IR").ServiceFiltros.GetSites(emplid, parameter);
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
                result = StatusCode(StatusCodes.Status500InternalServerError, new res.CriticalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { ex.ToString() }, TrackingCode = trackingCode });
            }
            finally
            {

            }
            return result;
        }

        [HttpGet(Constants.GetSitesCliente)]
        [ProducesResponseType(typeof(List<res.GetSitesRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetSitesCliente(int emplid, string parameter)
        {

            ActionResult result;
            try
            {
                //listaSucursalesCombo
                var response = serviceFactory("IR").ServiceFiltros.GetSitesCliente(emplid, parameter);
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
                result = StatusCode(StatusCodes.Status500InternalServerError, new res.CriticalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { ex.ToString() }, TrackingCode = trackingCode });
            }
            finally
            {

            }
            return result;
        }

        
        [HttpGet(Constants.GetSitesSucursal)]
        [ProducesResponseType(typeof(List<res.GetSitesRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetSitesSucursal(int emplid, string parameter)
        {

            ActionResult result;
            try
            {
                //listaSucursalesCombo
                var response = serviceFactory("IR").ServiceFiltros.GetSitesSucursal(emplid, parameter);
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
                result = StatusCode(StatusCodes.Status500InternalServerError, new res.CriticalErrorMessageDto { Origin = Constants.OriginService, Message = new[] { ex.ToString() }, TrackingCode = trackingCode });
            }
            finally
            {

            }
            return result;
        }

    }
}
