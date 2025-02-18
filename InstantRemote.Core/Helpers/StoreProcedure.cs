


namespace InstantRemote.Core.Helpers
{
    public static class StoreProcedure
    {
        public const string listaClientesComboJerarquiaOtros = "listaClientesComboJerarquiaOtros";
        public const string listaSucursalesComboJerarquiaOtros = "listaSucursalesComboJerarquiaOtros";

        public const string SP_GetSitesV2 = "SP_GetSitesV2"; //TODO
        public const string sp_GetSitesCliente = "sp_GetSitesCliente"; //TODO
        public const string sp_GetSitesSucursal = "sp_GetSitesSucursal"; //TODO

        public const string sp_GetSecciones = "sp_GetSecciones"; //TODO
        public const string sp_GetSeccionesSucursal = "sp_GetSeccionesSucursal"; //TODO

        public const string sp_GetTipoServicioV2 = "sp_GetTipoServicioV2"; //TODO
        public const string sp_GetTipoServicioSucursal = "sp_GetTipoServicioSucursal"; //TODO
        public const string sp_GetTipoServicioSeccion = "sp_GetTipoServicioSeccion"; //TODO


        public const string sp_GetCatalogoCliente = "sp_GetCatalogoCliente"; //TODO
        public const string sp_GetClienteSeccion = "sp_GetClienteSeccion"; //TODO

        public const string sp_InsertaCliente = "sp_InsertaCliente"; 
        public const string sp_ActualizaCliente = "sp_ActualizaCliente";
        public const string sp_EliminaCliente = "sp_EliminaCliente";
        

        public const string sp_updateMasivoSucursalesDomicilioXML = "sp_updateMasivoSucursalesDomicilioXML"; 
        public const string IR_V2_SP_Get_AllCatalogoSucursales = "IR_V2_SP_Get_AllCatalogoSucursales"; 
        public const string sp_GetSucursalSeccion = "sp_GetSucursalSeccion"; //TODO
        public const string sp_GetCatalogoSucursal = "sp_GetCatalogoSucursal"; //TODO
        public const string sp_GetResponsablesDetalle = "sp_GetResponsablesDetalle"; //TODO
        public const string IR_V2_SP_Add_Sucursal = "IR_V2_SP_Add_Sucursal"; 
        public const string IR_V2_SP_Update_Sucursal = "IR_V2_SP_Update_Sucursal";
        public const string IR_V2_RP_Elimina_Sucursal = "IR_V2_RP_Elimina_Sucursal";
        public const string IR_V2_SP_InsertaTelefono = "IR_V2_SP_InsertaTelefono";
        public const string sp_GetSites = "sp_GetSites";
        public const string sp_GetBiometricos = "sp_GetBiometricos";
        public const string sp_GetTelefonosRestriccion = "sp_GetTelefonosRestriccion"; //TODO
        
        public const string IR_V2_SP_GetCatalogoHorario = "IR_V2_SP_GetCatalogoHorario"; 
        public const string IR_V2_SP_Elimina_Horario = "IR_V2_SP_Elimina_Horario"; 
        public const string IR_V2_SP_InsertaCatHorario = "IR_V2_SP_InsertaCatHorario"; 
        public const string IR_V2_SP_ActualizaCatHorario = "IR_V2_SP_ActualizaCatHorario";
        
        
        public const string IR_V2_SP_GET_Tokens = "IR_V2_SP_GET_Tokens"; //TODO
        public const string IR_V2_SP_GET_LiberaToken = "IR_V2_SP_GET_LiberaToken"; 
        public const string IR_V2_SP_DELETE_Token = "IR_V2_SP_DELETE_Token"; 
        public const string IR_V2_SP_ADD_Token = "IR_V2_SP_ADD_Token"; 
        
        
        public const string sp_GetEmpleadosTipoPermiso_V2 = "sp_GetEmpleadosTipoPermiso_V2"; 
        public const string listaEmpleadosParaPermisos = "listaEmpleadosParaPermisos"; 
        public const string sp_GetConfiguracionRepCatEmpleado_v2 = "sp_GetConfiguracionRepCatEmpleado_v2"; 
        public const string sp_InsertPermiso_v2 = "sp_InsertPermiso_v2";
        public const string sp_UpdatePermiso_v2 = "sp_UpdatePermiso_v2";
        public const string sp_EliminaPermiso = "sp_EliminaPermiso";
        public const string sp_GetSeccionEmpleados = "sp_GetSeccionEmpleados";
        public const string IR_V2_SP_GetSucursalesEmpleadoOneOrMoreClientes = "IR_V2_SP_GetSucursalesEmpleadoOneOrMoreClientes";


        public const string IR_V2_RP_Lista_Empleados_V3 = "IR_V2_RP_Lista_Empleados_V3"; 
        public const string IR_V2_SP_Get_DetalleEmpleado = "IR_V2_SP_Get_DetalleEmpleado"; 
        public const string IR_V2_SP_Get_EmpleadoByTelefono = "IR_V2_SP_Get_EmpleadoByTelefono"; 
        public const string IR_V2_SP_ActualizaCatEmpleado = "IR_V2_SP_ActualizaCatEmpleado"; 
        public const string IR_V2_SP_GetCatEmpleadosEstatus = "IR_V2_SP_GetCatEmpleadosEstatus"; 
        public const string IR_V2_SP_GetCatEmpleadosById = "IR_V2_SP_GetCatEmpleadosById"; 
        public const string sp_updateMasivoEmpleadosXML = "sp_updateMasivoEmpleadosXML"; 
        
        
        public const string sp_InsertaDiaFestivo = "sp_InsertaDiaFestivo"; 
        
        public const string IR_V2_SP_Get_Lista_Empleados_Para_Asignar = "IR_V2_SP_Get_Lista_Empleados_Para_Asignar"; 
        public const string IR_V2_SP_Get_Lista_Empleados_Para_Asignar_Edicion = "IR_V2_SP_Get_Lista_Empleados_Para_Asignar_Edicion"; 
        public const string IR_V2_SP_Asigna_Empleado_Temporal = "IR_V2_SP_Asigna_Empleado_Temporal"; 
        public const string IR_V2_SP_Asigna_Empleado_Temporal_Edit = "IR_V2_SP_Asigna_Empleado_Temporal_Edit"; 
        public const string IR_V2_SP_Desasigna_Empleado_Temporal = "IR_V2_SP_Desasigna_Empleado_Temporal";

        public const string IR_V2_RP_ConstantesEnrolados = "IR_V2_RP_ConstantesEnrolados"; 
        public const string sp_GetDispositivos = "sp_GetDispositivos"; 
        public const string sp_GetEmpleadosPorDispositivo = "sp_GetEmpleadosPorDispositivo"; 
        
        
        public const string sp_GetSucursales = "sp_GetSucursales"; 
        
        public const string IR_V2_RP_Log_Asistencia = "IR_V2_RP_Log_Asistencia"; 
        public const string IR_V2_RP_Retardos_Admin = "IR_V2_RP_Retardos_Admin"; 
        public const string IR_V2_RP_Huerfanos = "IR_V2_RP_Huerfanos"; 
        public const string sp_ReporteCliente = "sp_ReporteCliente"; 
        public const string IR_V2_RP_Enrolados_filtro = "IR_V2_RP_Enrolados_filtro"; 
        public const string IR_V2_RP_Asistencia_Estandar_Hrs_Extras = "IR_V2_RP_Asistencia_Estandar_Hrs_Extras"; 
        public const string IR_V2_RP_Asistencia_Estandar_por_Anio = "IR_V2_RP_Asistencia_Estandar_por_Anio"; 
        public const string IR_V2_RP_Asistencia_Estandar_por_Anio_Resumen = "IR_V2_RP_Asistencia_Estandar_por_Anio_Resumen"; 
        public const string IR_V2_RP_Asistencia_Estandar = "IR_V2_RP_Asistencia_Estandar"; 
        public const string IR_V2_RP_Acumulado_Asistencia = "IR_V2_RP_Acumulado_Asistencia"; 
        public const string IR_V2_RP_Ausentismos = "IR_V2_RP_Ausentismos"; 
        
        
        
        public const string sp_GetCalendariosHorasExtras = "sp_GetCalendariosHorasExtras"; 

        





    }
}







