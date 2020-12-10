using System;
using Abstracao_POO.classes;

namespace Abstracao_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.Write("Valor da compra: R$ ");
            float valordaCompra = float.Parse(Console.ReadLine());
            Console.ResetColor();
                        
            string opcao;

            do
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("--------CAIXA ABERTO----------");
            Console.WriteLine("");
            Console.WriteLine("SELECIONE A FORMA DE PAGAMENTO:");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[1] - Boleto Bancário ** Desconto de 12% **");
            Console.WriteLine("[2] - Cartão de Crédito");
            Console.WriteLine("[3] - Cartão de Débito");
            Console.WriteLine("[0] - Fechar o caixa");
            opcao = Console.ReadLine();
            Console.ResetColor();

            switch (opcao)
            {
                case "1":
                // boleto
                Boleto boleto = new Boleto();
                boleto.Valor = valordaCompra;
                boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);
                Console.WriteLine("Imprimindo boleto....");
                Console.WriteLine("----Obrigado pela Preferência----");
                return;
                
                case "2":
                // credito
                Credito credito = new Credito();
                Console.Write("Digite o nome do titular: ");
                credito.titular = Console.ReadLine();
                Console.Write("Digite o número do cartão: ");
                credito.numero = Console.ReadLine();
                Console.Write("Digite o código de segurança: ");
                credito.cvv = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                credito.Pagar(valordaCompra);
                Console.ResetColor();                
                
                return;
                
                case "3":
                // debito
                Debito debito = new Debito();
                Console.Write("Digite o nome do titular: ");
                debito.titular = Console.ReadLine();
                Console.Write("Digite o número do cartão: ");
                debito.numero = Console.ReadLine();
                Console.Write("Digite o código de segurança: ");
                debito.cvv = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                debito.Pagar(valordaCompra);
                Console.ResetColor();
                return;

                case "0":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-----CAIXA FECHADO-----");
                    Console.ResetColor();
                break;
                
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FORMA DE PAGAMENTO INEXISTENTE !");
                    Console.ResetColor();
                    break;
            }
            
            } while (opcao != "0");

        }
    }
}
