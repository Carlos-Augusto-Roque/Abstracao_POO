using System;

namespace Abstracao_POO.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "23794.02510 96515.412375 11000.060001 3 00000000000000";
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Registrar(float valor,DateTime dataEmissao, string codigoDeBarras){
            Console.WriteLine($"Valor da Documento: R$ {valor*0.88f}!");
            Console.WriteLine($"Emissão do Documeto: {dataEmissao}");
            Console.WriteLine($"Data de Vencimento: {dataEmissao.AddDays(10)}");
            Console.WriteLine($"Linha Digitável (Cod.Barras) : {codigoDeBarras}");
            Console.WriteLine($"Informações : -- NÃO RECEBER APÓS O VENCIMENTO --");
        }

       
    }
}