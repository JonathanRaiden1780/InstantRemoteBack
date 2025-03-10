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
    [Route(Constants.RouteFiltro, Name = Constants.Filtros)]
    public class FiltrosController : BaseController
    {
        public FiltrosController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
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
        [HttpGet(Constants.GetYearsMatriz)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetYearsMatriz()
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetYearsMatriz();
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
        [HttpGet(Constants.GetCalMatriz)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequestDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(res.FunctionalErrorMessageDto), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(res.CriticalErrorMessageDto), StatusCodes.Status500InternalServerError)]
        public ActionResult GetCalMatriz(string year)
        {
            ActionResult result;
            try
            {
                var response = serviceFactory("IR").ServiceParameter.GetCalMatriz(year);
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
        public ActionResult GetWeeks(int year)
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
        
    }
}
