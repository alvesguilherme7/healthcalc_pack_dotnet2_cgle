using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_pack_dotnet
{
    public class MacroNutrientes : IMacroNutrientes
    {
        public ResultadoMacroNutrientesModel CalcularMacronutrientes(double Peso, ObjetivoFisicoEnum ObjetivoFisico)
        {
            var resultado = new ResultadoMacroNutrientesModel();

            if(ObjetivoFisico == ObjetivoFisicoEnum.Cutting)
            {
                resultado.Proteinas = 2.0 * Peso;
                resultado.Gordura = 1.0 * Peso;
                resultado.Carboidratos = 2.0 * Peso;
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Bulking)
            {
                resultado.Proteinas = 2.0 * Peso;
                resultado.Gordura = 1.0 * Peso;
                resultado.Carboidratos = 4.0 * Peso;
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Keep)
            {
                resultado.Proteinas = 2.0 * Peso;
                resultado.Gordura = 1.0 * Peso;
                resultado.Carboidratos = 5.0 * Peso;
            }
            return resultado;
        }
    }
}
