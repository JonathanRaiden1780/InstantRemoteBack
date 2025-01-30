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

        [AllowAnonymous]
        [HttpPost(Constants.Bitacora)]
        [ProducesResponseType(StatusCodes.Status200OK)]
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

        [AllowAnonymous]
        [HttpGet(Constants.GetEstado)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetEstados()
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetEstados();
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

        [AllowAnonymous]
        [HttpGet(Constants.GetYears)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetYears()
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetYears();
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
        
        [AllowAnonymous]
        [HttpGet(Constants.GetWeeks)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetWeeks( int year)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetWeeks(year);
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

        [AllowAnonymous]
        [HttpGet(Constants.GetMunicipios)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetMunicipios(int estado)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetMunicipio(estado);
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

        [AllowAnonymous]
        [HttpGet(Constants.GetColonia)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetColonia(int estado, int mun)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetColonia(estado, mun);
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

        [AllowAnonymous]
        [HttpGet(Constants.GetCP)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetCP(int estado, int mun, int col)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetCP(estado, mun, col);
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

        [AllowAnonymous]
        [HttpGet(Constants.GetZonaHoraria)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetZonaHoraria()
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetZonaHoraria();
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

        [HttpGet(Constants.GetCatalogoHorario)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetCatalogoHorario(int cliente, int idDeptoSucursal)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.GetCatalogoHorario(cliente, idDeptoSucursal);
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


        [HttpGet(Constants.GetConstEnrola)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetConstEnrola(int tipo)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.GetConstEnrola(tipo);
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

        [HttpGet(Constants.GetDispositivos)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetDispositivos(int emplid)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.GetDispositivos(emplid);
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

        [HttpGet(Constants.GetDispositivoDetalle)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetDispositivoDetalle(string serie)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceFiltros.GetDispositivoDetalle(serie);
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

        [HttpGet(Constants.GetParameterByReference)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetParameterByReference(string reference)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetParameterByReference(reference);
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

        [HttpPost(Constants.UpdateParameter)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateParameter([FromQuery] string reference, string value)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.UpdateParameter(reference, value);
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