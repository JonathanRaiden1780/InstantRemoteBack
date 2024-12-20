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
    [Route(Constants.RouteServicios, Name = Constants.Servicios)]
    public class ServiciosController : BaseController
    {
        public ServiciosController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
        }

        [HttpGet(Constants.GetServicio)]
        [ProducesResponseType(typeof(List<res.GetServicioRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetServicio( int emplid, string parameter)
        {

            ActionResult result;
            try
            {
                //listaSucursalesCombo
                var response = serviceFactory("IR").ServiceFiltros.GetServicios(emplid, parameter);
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

        [HttpGet(Constants.GetServicioSucursal)]
        [ProducesResponseType(typeof(List<res.GetServicioRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetServicioSucursal(int emplid, int parameter)
        {

            ActionResult result;
            try
            {
                //listaSucursalesCombo
                var response = serviceFactory("IR").ServiceFiltros.GetServicioSucursal(emplid, parameter);
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

        [HttpGet(Constants.GetServicioSeccion)]
        [ProducesResponseType(typeof(List<res.GetServicioRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetServicioSeccion(int emplid, int parameter)
        {

            ActionResult result;
            try
            {
                //listaSucursalesCombo
                var response = serviceFactory("IR").ServiceFiltros.GetServicioSeccion(emplid, parameter);
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
