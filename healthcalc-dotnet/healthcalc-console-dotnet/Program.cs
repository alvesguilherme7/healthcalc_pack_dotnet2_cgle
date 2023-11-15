using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

IIMC imcCalc  = new IMC();

var imc = imcCalc.CalcularIMC(74.20, 1.75);
var resultado = imcCalc.RetornarClassificacaoIMC(imc);

Console.WriteLine("Seu resultado e: " + resultado);