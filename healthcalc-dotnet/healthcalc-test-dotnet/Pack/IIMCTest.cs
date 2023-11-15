using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_test_dotnet.Pack
{
    public class IIMCTest
    {
        [Fact]
        public void CalculaIMCQuandoPesoEAlturaValidosEntaoRetornaIndice()
        {
            //Arrange
            IIMC imc = new IMC();
            double Peso = 66;
            double Altura = 1.59;
            double IndiceIMC = 26.109999999999999;

            //Act
            var IndiceIMCRetornardo = imc.CalcularIMC(Peso, Altura);

            //Asserts
            Assert.Equal(IndiceIMC, IndiceIMCRetornardo);
        }

        [Fact]
        public void CalculaIMCQuandoPesoEAlturaValidosEntaoRetornaExcecao()
        {
            //Arrange
            IIMC imc = new IMC();
            double Peso = 66;
            double Altura = 1.59;

            //Act
            try
            {
                imc.CalcularIMC(Peso, Altura);
            }
            catch (Exception ex)
            {
                Assert.Equal("ALTURA INVÁLIDA!", ex.Message.ToString().ToUpper());
            }
        }

        [Fact]
        public void RetornarClassificacaoIMCAcimaDoPesoIndiceDentroDaFaixa()
        {
            //Arrange
            IIMC imc = new IMC();
            double IndiceIMC = 26.1;

            //Act
            var Classificacao = imc.RetornarClassificacaoIMC(IndiceIMC);

            //Asserts
            Assert.Equal("SOBREPESO", Classificacao);
        }

        [Theory]
        [InlineData(15.23, "ABAIXO DO PESO")]
        [InlineData(17.66, "ABAIXO DO PESO")]
        [InlineData(18.50, "ABAIXO DO PESO")]

        [InlineData(18.60, "PESO NORMAL")]
        [InlineData(22.00, "PESO NORMAL")]
        [InlineData(24.90, "PESO NORMAL")]

        [InlineData(25.00, "SOBREPESO")]
        [InlineData(26.21, "SOBREPESO")]
        [InlineData(27.81, "SOBREPESO")]
        [InlineData(28.35, "SOBREPESO")]
        [InlineData(29.90, "SOBREPESO")]

        [InlineData(30.00, "OBESIDADE I")]
        [InlineData(32.00, "OBESIDADE I")]
        [InlineData(34.99, "OBESIDADE II")]

        [InlineData(35.00, "OBESIDADE II")]
        [InlineData(38.33, "OBESIDADE II")]
        [InlineData(39.90, "OBESIDADE II")]

        [InlineData(40.00, "OBESIDADE III")]
        [InlineData(40.10, "OBESIDADE III")]
        [InlineData(50.00, "OBESIDADE III")]
        
        public void RetornaClassificacaoIMCAcimaDoPesoQuandoIndiceDentroFaixa(double IndiceIMC, string Classificacao)
        {
            //Arrange
            IIMC imc = new IMC();

            //Act
            var Classificado = imc.RetornarClassificacaoIMC(IndiceIMC);

            //Asserts
            Assert.Equal(Classificacao, Classificado);
        }
    }
}
