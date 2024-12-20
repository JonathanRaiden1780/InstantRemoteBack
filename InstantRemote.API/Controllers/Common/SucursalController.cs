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
    [Route(Constants.RouteSucursal, Name = Constants.Sucursal)]
    public class SucursalController : BaseController
    {
        public SucursalController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
        }

        [HttpGet(Constants.GetSucursales)]
        [ProducesResponseType(typeof(List<res.GetSucursalesRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetSucursales(string clientId)
        {

            ActionResult result;
            try
            {
                //listaSucursalesCombo
                var response = serviceFactory("IR").ServiceFiltros.GetSucursalList(clientId);
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


        [HttpGet(Constants.GetSucursalesXPermisos)]
        [ProducesResponseType(typeof(List<res.GetSucursalesRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetSucursalesXPermisos(int emplid, string cliente)
        {

            ActionResult result;
            try
            {
                //listaClientesComboDash
                var response = serviceFactory("IR").ServiceFiltros.GetSucursalesXPermisos(emplid,cliente);
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


        [HttpGet(Constants.GetSucursalSecciones)]
        [ProducesResponseType(typeof(List<res.GetSucursalesRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetSucursalSecciones(int emplid, int secciones)
        {

            ActionResult result;
            try
            {
                //listaClientesComboDash
                var response = serviceFactory("IR").ServiceFiltros.GetSucursalSecciones(emplid, secciones);
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
