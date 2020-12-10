using System;

namespace Abstracao_POO.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;


        public void Pagar(float valor){
            if(valor <= limite){
                Console.WriteLine("Pagamento Aprovado!");
            }else{
                Console.WriteLine("Limite Excedido - Entre em contato com sua gerência!");
            }

        public string Parcelar(int numeroParcelas){
            if(numeroParcelas <=6){
                valor = valor*0.95f;
            }if(numeroParcelas >6 || numeroParcelas<=12){
                valor = valor*0.92f;
            }else{
                Console.WriteLine("Número de parcelas não autorizado!");
            }
        }
        
        }
        
    }
}