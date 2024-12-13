using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using System.Data;
using AutoMapper;
using Dapper;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Helpers;
using System.Net.NetworkInformation;

namespace InstantRemote.Repositories.Context
{
    public class RepositoryCommon : BaseRepository, IRepositoryCommon
    {
        public RepositoryCommon(IDbConnection connection, Func<IDbTransaction> transaction, IMapper mapper) : base(connection, transaction, mapper)
        {

        }

        public void InsertBitacoraInstantRemote(BitacoraRequestDto bitacora)
        {
            var query = "INSERT INTO tblBitacoraInstanRemote values ('" 
                                + bitacora.Usuario + "' ,'" 
                                + bitacora.Accion + "','" 
                                + bitacora.Descripcion + "','"
                                + bitacora.Pantalla + "',GETDATE(),'')"; 
            Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault();
        }

        #region sucursales
        //listaSucursalesCombo / listaSucursalesComboBJ admin

        public List<GetSucursalesRespDto> GetSucursales(string parameter)
        {
            var query = "SELECT idDeptoSucursal as id ,nomSucursal as sucursal FROM  catDeptoSucursal WITH (nolock) ";
            if (parameter != null)
                query += "WHERE idCliente = '" + parameter +"'";

            query += "ORDER BY 1";

            return Connection.Query<GetSucursalesRespDto>(query, commandType: CommandType.Text).ToList();
        }

        //dividir el SP listaSucursalesComboBJ si es @clie = '000' seccion
        public List<GetSucursalesRespDto> GetSucursalesSeccion(int emplid, string cliente)
        {
            var query = "select distinct  idDeptoSucursal as id ,nomSucursal as sucursal " +
                        "from tbl_empleado_seccion a join catSeccion b on a.seccion = b.descripcion " +
                        "join catDeptoSucursal c on b.idSeccion =c.idSeccion " +
                        "join catZonaCliente d on c.idCliente = d.idZonaCliente " +
                        "where emplid =  " + emplid +
                        "and d.idZonaCliente = '" + cliente +"'";

            return Connection.Query<GetSucursalesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaSucursalesComboBJ si es @clie = '000000' site
        public List<GetSucursalesRespDto> GetSucursalesSite(int emplid, string cliente)
        {
            var query = "select  c.idDeptoSucursal as id,c.nomSucursal as sucursal  from tbl_empleado_site a " +
                        "join tbl_sucursalSite b on a.site = b.nameSite " +
                        "join catDeptoSucursal c on b.idSucursal =c.idDeptoSucursal " +
                        "where emplid = "+  emplid  +
                        "and c.idCliente = '" + cliente + "'";

            return Connection.Query<GetSucursalesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaSucursalesComboBJ si es jerarquia u otro
        public List<GetSucursalesRespDto> GetSucursalesJerarquiaOtro(int emplid, string cliente)
        {
            var response = Connection.Query<GetSucursalesRespDto>(StoreProcedure.listaSucursalesComboJerarquiaOtros, new
            {
                @emplid = emplid,
                @cliente = cliente
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        #endregion


        #region Clientes
        //catzonaclientes admin / tambien se uso para el dashcombo
        public List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid, string parameter)
        {
            var query = "SELECT idZonaCliente as id ,nomCliente as cliente FROM  catZonaCliente WITH (nolock)";
            if (parameter != null)
                query += "WHERE idZonaCliente in (" + parameter + ")";

            query += "ORDER BY idZonaCliente";

            return Connection.Query<GetCatZonaClientesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaClientesComboBJ si es @clie = '000' seccion
        public List<GetCatZonaClientesRespDto> GetClienteSeccion(int emplid)
        {
            var query = "select distinct d.idZonaCliente as id , d.nomCliente as cliente " +
                        "from tbl_empleado_seccion a " +
                        "join catSeccion b on a.seccion = b.descripcion " +
                        "join catDeptoSucursal c on b.idSeccion =c.idSeccion " +
                        "join catZonaCliente d on c.idCliente = d.idZonaCliente " +
                        "where emplid = " + emplid;

            return Connection.Query<GetCatZonaClientesRespDto>(query, commandType: CommandType.Text).ToList();
        }

        //dividir el SP listaClientesComboBJ si es @clie = '000000' site
        public List<GetCatZonaClientesRespDto> GetClienteSite(int emplid)
        {
            var query = "select distinct d.idZonaCliente as id , d.nomCliente as cliente " +
                        "from tbl_empleado_site a " +
                        "join tbl_sucursalSite b on a.site = b.nameSite " +
                        "join catDeptoSucursal c on b.idSucursal =c.idDeptoSucursal " +
                        "join catZonaCliente d on c.idCliente = d.idZonaCliente " +
                        "where emplid = " + emplid;

            return Connection.Query<GetCatZonaClientesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaClientesComboBJ si es jerarquia u otro
        public List<GetCatZonaClientesRespDto> GetClienteJerarquiaOtro(int emplid)
        {
            var response = Connection.Query<GetCatZonaClientesRespDto>(StoreProcedure.listaClientesComboJerarquiaOtros, new
            {
                @emplid = emplid
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        #endregion

        #region Seccion

        //TODO SEPARAR sp PARA QUE SEA MÁS DINAMICO
        public List<GetSeccionesRespDto> GetSecciones(int emplid, string otro)
        {
            var response = Connection.Query<GetSeccionesRespDto>(StoreProcedure.sp_GetSecciones, new
            {
                @emplid = emplid,
                @otro2 = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }


        #endregion

        #region Site

        //TODO SEPARAR sp PARA QUE SEA MÁS DINAMICO
        public List<GetSitesRespDto> GetSites(int emplid, string otro)
        {
            var response = Connection.Query<GetSitesRespDto>(StoreProcedure.SP_GetSitesV2, new
            {
                @emplid = emplid,
                @otro = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }


        #endregion

        #region Servicio

        //TODO SEPARAR sp PARA QUE SEA MÁS DINAMICO
        public List<GetServicioRespDto> GetServicio(int emplid, string otro)
        {
            var response = Connection.Query<GetServicioRespDto>(StoreProcedure.sp_GetTipoServicioV2, new
            {
                @emplid = emplid,
                @otro2 = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }


        #endregion
    }
}
