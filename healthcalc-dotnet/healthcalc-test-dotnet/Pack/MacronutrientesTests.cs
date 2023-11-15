using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_test_dotnet.Pack
{
    public class MacronutrientesTests    
    {
        [Fact]
        public void CalculaResultadoMacro()
        {
            //Arrange
            IMacroNutrientes macros = new MacroNutrientes();
            double Peso = 66;
            var ObjetivoFisico = ObjetivoFisicoEnum.Cutting;
            var MacrosEsperados = new ResultadoMacroNutrientesModel()
            {
                Proteinas = 132.0,
                Gordura = 66.0,
                Carboidratos = 132.0
            };

            //Act
            var resultadoMacros = macros.CalcularMacronutrientes(Peso, ObjetivoFisico);

            //Asserts
            Assert.Equivalent(MacrosEsperados, resultadoMacros);
        }
    }
}