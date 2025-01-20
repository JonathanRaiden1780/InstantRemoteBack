using Microsoft.AspNetCore.Mvc;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Contracts.Factories.Common;
using res = InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Dtos;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Api.Controllers.Common
{
    [ApiController]
    [Produces(Constants.ContentType)]
    [Route(Constants.RouteReports, Name = Constants.Reports)]
    public class ReportesController : BaseController
    {
        public ReportesController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
        }


        [HttpPost(Constants.GetLogAsistencia)]
        [ProducesResponseType(typeof(List<res.GetCatZonaClientesRespDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetLogAsistencia(FiltrosReq filtros)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetLogAsistencia(filtros);
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