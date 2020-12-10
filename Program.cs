using System;
using Abstracao_POO.classes;

namespace Abstracao_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            Cartao debito = new Cartao();
            Cartao credito = new Cartao();

            
            string opcao;
            do
            {
            Console.WriteLine("");
            Console.WriteLine("--------CAIXA ABERTO----------");
            Console.WriteLine("");
            Console.WriteLine("SELECIONE A FORMA DE PAGAMENTO:");
            Console.WriteLine("");
            Console.WriteLine("[1] - Boleto Bancário ** Desconto de 12% **");
            Console.WriteLine("[2] - Cartão de Crédito");
            Console.WriteLine("[3] - Cartão de Débito");
            Console.WriteLine("[0] - Fechar o caixa");
            opcao = Console.ReadLine();
            Console.Write("Valor da compra: R$ ");
            float valor = float.Parse(Console.ReadLine());

            switch (opcao)
            {
                case "1":
                // boleto
                Console.Write($"Data de vencimento: ");
                DateTime dataVencimento = DateTime.Parse(Console.ReadLine());
                boleto.Registrar();
                
                break;
                
                case "2":
                // credito
                Console.WriteLine("Cadastrar Cartão");
                // credito.CadastrarCartão();
                
                break;
                
                case "3":
                // debito
                
                break;

                case "0":
                    Console.WriteLine("-----CAIXA FECHADO-----");
                break;
                
                default:
                    Console.WriteLine("FORMA DE PAGAMENTO INEXISTENTE !");
                    break;
            }
            
            } while (opcao != "0");

        }
    }
}
