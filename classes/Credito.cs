using System;

namespace Abstracao_POO.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;


        public virtual void Pagar(float valor){
            if(valor <= this.limite){
                

                int parcelas;

                do
                {
                    Console.WriteLine("Atenção : Para essa forma de Pagamento haverá um acréscimo de juros!");
                    Console.WriteLine("Número máximo de parcelas : 12");
                    Console.WriteLine("Números de parcelas de 0 até 6 : Juros de 5% ");
                    Console.WriteLine("Números de parcelas de 7 até 12 : Juros de 8%");
                    Console.WriteLine("");
                    Console.Write("Digite o número de parcelas: ");
                    parcelas = int.Parse(Console.ReadLine());

                } while (parcelas >12);

                float juros;

                if(parcelas <= 6){
                    juros = 0.05f;
                }else{
                    juros = 0.08f;
                }

                float total = valor + (valor*juros);
                
                ExibirNota(this.titular, total);
                Console.WriteLine("Parabéns pela compra - Pagamento Aprovado!");

            }else{
                Console.WriteLine("Ops! Limite Excedido - Entre em contato com sua gerência!");
            }
               
        }

        public void ExibirNota(string titular, float total){
            Console.WriteLine($"Titular {titular}  - Valor da Compra : {total}");
        }
        
    }
}