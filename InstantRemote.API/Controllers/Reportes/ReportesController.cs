using Microsoft.AspNetCore.Mvc;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Contracts.Factories.Common;
using res = InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Dtos;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using Microsoft.Reporting.NETCore;


namespace InstantRemote.Api.Controllers.Reportes
{
    [ApiController]
    [Produces(Constants.ContentType)]
    [Route(Constants.RouteReportes, Name = Constants.Reports)]
    public class ReportesController : BaseController
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        public ReportesController(Func<string, IServiceFactory> serviceFactory, IWebHostEnvironment hostEnvironment) :
            base(serviceFactory)
        {
            _hostEnvironment = hostEnvironment;
        }


        [HttpPost(Constants.GetLogAsistencia)]
        [ProducesResponseType(typeof(List<res.LogAsistenciaResp>), StatusCodes.Status200OK)]
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

        [HttpPost(Constants.GetRetardos)]
        [ProducesResponseType(typeof(List<res.RetardosResp>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetRetardos(FiltrosRepReq filtros)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetRetardos(filtros);
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

        [HttpPost(Constants.GetHuerfanos)]
        [ProducesResponseType(typeof(List<res.HuerfanosResp>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetHuerfanos(FiltroHuerfanos filtros)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetHuerfanos(filtros);
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

        [HttpPost(Constants.GetReportClientes)]
        [ProducesResponseType(typeof(List<res.GetReportesClientes>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportClientes([FromBody] int emplid)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportClientes(emplid);
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

        [HttpPost(Constants.GetReportEdoEnrola)]
        [ProducesResponseType(typeof(List<res.GetReportesEnrolados>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportEdoEnrola([FromBody] FiltroEdoEnrola filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportEdoEnrola(filtro);
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

        [HttpPost(Constants.GetReportHorasExtras)]
        [ProducesResponseType(typeof(List<res.GetReportesHrsExtras>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportHrsExtra([FromBody] FiltroHrsExtra filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportHrsExtra(filtro);
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

        [HttpPost(Constants.GetReportAsistenciaAnual)]
        [ProducesResponseType(typeof(List<res.GetReportAsistenciaAnual>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportAsistenciaAnual([FromBody] FiltroAsistenciaAnual filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportAsistenciaAnual(filtro);
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

        [HttpPost(Constants.GetReportAsistenciaAnualResumen)]
        [ProducesResponseType(typeof(List<res.GetReportAsistenciaAnualResumen>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportAsistenciaAnualResumen([FromBody] FiltroAsistenciaAnualResumen filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportAsistenciaAnualResumen(filtro);
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

        [HttpPost(Constants.GetReportAsistenciaEstandar)]
        [ProducesResponseType(typeof(List<res.GetReportAsistenciaEstandar>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportAsistenciaEstandar([FromBody] FiltroAsistenciaAnualResumen filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportAsistenciaEstandar(filtro);
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
      
        [HttpPost(Constants.GetReportAcumuladoAsistencia)]
        [ProducesResponseType(typeof(List<res.GetReportAcumuladoAsistencia>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportAcumuladoAsistencia([FromBody] FiltroAsistenciaAcumulado filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportAcumuladoAsistencia(filtro);
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
        
        [HttpPost(Constants.GetReportAusentismos)]
        [ProducesResponseType(typeof(List<res.GetReportAusentismos>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportAusentismos([FromBody] FiltroAusentismos filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportAusentismos(filtro);
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
        
        [HttpPost(Constants.GetReportAsistencia)]
        [ProducesResponseType(typeof(List<res.GetReportAsistencia>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportAsistencia([FromBody] FiltroAsistencia filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportAsistencia(filtro);
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
      
        [HttpPost(Constants.GetReportAsistenciaTemperatura)]
        [ProducesResponseType(typeof(List<res.GetReportAsistenciaTemp>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportAsistenciaTemperatura([FromBody] FiltroAsistencia filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportAsistenciaTemperatura(filtro);
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
        
        [HttpPost(Constants.GetReportApp)]
        [ProducesResponseType(typeof(List<res.GetReportApp>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetReportApp([FromBody] FiltroApp filtro)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceReports.GetReportApp(filtro);
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