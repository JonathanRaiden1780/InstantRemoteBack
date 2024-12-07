namespace InstantRemote.Core.Fucntions
{
    public static class FuncOnboarding
    {
        public static string FuncGetPldCode(this string pldQuestion) 
        {
            string code = null;

            
            if (pldQuestion.Contains("monto de efectivo estimado"))
                code = "Monto_Efectivo_Estimado";
            else if (pldQuestion.Contains("Cuál es su ocupación"))
                code = "Ocupacion_pld";
            else if (pldQuestion.Contains("ingresos son exclusivos") || pldQuestion.Contains("Actuó por cuenta propia y el dinero"))
                code = "Ingresos_exclusivos_actividad";
            else if (pldQuestion.Contains("ingresos son exclusivos") || pldQuestion.Contains("Declaro que el dinero que yo disponga"))
                code = "Ingresos_exclusivos_actividad2";
            else if (pldQuestion.Contains("Declaro bajo protesta") || pldQuestion.Contains("disponer del dinero"))
                code = "Declaro_Protesta";
            else if (pldQuestion.Contains("Declaro bajo protesta") || pldQuestion.Contains(".1"))
                code = "Declaro_Protesta2";
            else if (pldQuestion.Contains("Reside, contribuye") || pldQuestion.Contains("No tengo residencia en el extranjero"))
                code = "Reside_contribuye_accionista";
            else if (pldQuestion.Contains("Usted o algún familiar")|| pldQuestion.Contains("todos mis datos registrados"))
                code = "Reside_contribuye_accionista2";
            else if (pldQuestion.Contains("Usted o algún familiar")|| pldQuestion.Contains("No soy familiar de alguien que ocupe"))
                code = "ocupa_cargo_politico";
            else if (pldQuestion.Contains("Usted o algún familiar")|| pldQuestion.Contains("No he ocupado un cargo público actualmente"))
                code = "ocupa_cargo_politico2";
            else if (pldQuestion.Contains("actividad económica alterna"))
                code = "Actividad_Economica_Alterna";
            else if (pldQuestion.Contains("actividad económica?"))
                code = "Actividad_Economica_pld";
            else if (pldQuestion.Contains("Tipo de actividad")) 
                code = "Trans_De_Identidad";
            else if (pldQuestion.Contains("operaciones mensuales estimadas"))
                code = "Monto_OpMensualCuenta";
            else if (pldQuestion.Contains("desempeño de mi ocupación, profesión o actividad manifiesta")|| pldQuestion.Contains("Confirmo que mis ingresos mensuales provienen exclusivamente del desempeño"))
                code = "ConfirmoQue_MisIngMensual";
            return code;

        }
    }
}
