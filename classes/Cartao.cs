using System;

namespace Abstracao_POO.classes
{
    public abstract class Cartao
    {
        public string bandeira;

        public string numero;

        public string titular;

        public string cvv;

        public string CadastrarCartão(string bandeira, string numero, string titular, string cvv){
            Console.WriteLine("Digite a bandeira do cartão");
            bandeira = Console.ReadLine();
            Console.WriteLine("Digite o número do cartão");
            numero = Console.ReadLine();
            Console.WriteLine("Digite o nome completo do titular");
            titular = Console.ReadLine();
            Console.WriteLine("Digite o cvv do cartão: ");
            cvv = Console.ReadLine();
            return "Cartão salvo!";
        }

        public void Pagar(){
            
        }
    }
}